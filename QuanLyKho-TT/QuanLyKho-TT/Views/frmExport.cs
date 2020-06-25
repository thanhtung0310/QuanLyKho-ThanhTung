using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QuanLyKho_TT.Model;

namespace QuanLyKho_TT.Views
{
    public partial class frmExport : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase xuat = new AccessDataBase();
        DataTable dtXuat = new DataTable();

        public frmExport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load 2 bảng và 2cbb
            loadData();

            MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn (mã đơn, số lượng) và tìm kiếm thông tin đơn trước khi chỉnh sửa hoặc xóa đơn.");
        }

        private void loadData()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select i1.Id, o.DisplayName, i1.Count, i1.OutputPrice " +
               "from INPUTINFO i1, OBJECT o where i1.IdObject = o.Id", AccessDataBase.connection);
            DataTable dtNhap = new DataTable();

            da1.Fill(dtNhap);
            dgv1.DataSource = dtNhap;
            cbbIDA.ValueMember = "Id";
            cbbIDA.DataSource = dtNhap;

            //combobox khách hàng
            SqlDataAdapter da2 = new SqlDataAdapter("select Id, DisplayName from CUSTOMER", AccessDataBase.connection);
            DataTable dtCus = new DataTable();

            da2.Fill(dtCus);
            cbbCusA.DisplayMember = "DisplayName";
            cbbCusA.ValueMember = "Id";
            cbbCusA.DataSource = dtCus;
            cbbCusB.DisplayMember = "DisplayName";
            cbbCusB.ValueMember = "Id";
            cbbCusB.DataSource = dtCus;

            //danh sách đơn đã xuất
            SqlDataAdapter da3 = new SqlDataAdapter("select o2.Id, o.DisplayName, o2.Count, i.OutputPrice, c.DisplayName, o2.Status, o1.OutputDate " +
                "from OUTPUT o1, OUTPUTINFO o2, OBJECT o, CUSTOMER c, INPUTINFO i " +
                "where (o1.Id = o2.Id) and (o2.IdCustomer = c.Id) and (o2.IdInputInfo = i.Id) and (i.IdObject = o.Id)", AccessDataBase.connection);
            DataTable dtXuat1 = new DataTable();

            da3.Fill(dtXuat1);
            dgv.DataSource = dtXuat1;
            cbbIDB.DisplayMember = "Id";
            cbbIDB.DataSource = dtXuat1;
        }

        void clearData()
        {
            cbbIDA.Text = "0";
            num1.Text = "0";
            numberA.Text = "0";
            numberB.Text = "0";
            tbStatus.Clear();
            cbbCusA.Text = "1";
            cbbCusB.Text = "1";
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận đăng xuất ?", "Thông báo.", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Hide();
                frmLogin form = new frmLogin();
                form.Show();
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (cbbIDA.Text == "0" || numberA.Text == "0" || cbbCusA.Text == "Chris")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập.", "Thông báo.");
            }
            else
            {
                string check = "select * from OUTPUT o1, OUTPUTINFO o2 where (o1.Id = o2.Id) and (o1.Id = '" + num1.Value + "')";
                xuat.readDatathroughAdapter(check, dtXuat);
                if (dtXuat.Rows.Count != 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mã xuất.", "Thông báo.");
                }
                else
                {
                    SqlCommand add1 = new SqlCommand("insert into OUTPUT(Id,OutputDate) values ('" + num1.Text + "','" + dateA.Value.ToString() + "')");
                    SqlCommand add2 = new SqlCommand("insert into OUTPUTINFO(Id,IdInputInfo,IdCustomer,Count) values ('" + num1.Text + "','" + cbbIDA.Text
                        + "','" + cbbCusA.SelectedValue + "','" + numberA.Text + "')");
                    xuat.executeQuery(add2);
                    xuat.executeQuery(add1);
                    MessageBox.Show("Thêm đơn thành công.", "Thông báo.");
                    clearData();
                }
            }
            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (cbbIDB.Text == "0" || numberB.Text == "0" || cbbCusB.Text == "Chris" || tbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng kiêm tra lại thông tin chỉnh sửa.", "Thông báo.");
            }
            else
            {
                SqlCommand edit = new SqlCommand("update OUTPUTINFO set Count = '" + numberB.Text + "', IdCustomer = '" + cbbCusB.SelectedValue +
                    "', Status = '" + tbStatus.Text + "' where Id = '" + cbbIDB.Text + "'");
                xuat.executeQuery(edit);
                MessageBox.Show("Chỉnh sửa thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string check = "select * from OUTPUT o, OUTPUTINFO o1 where (o.Id = o1.Id) and (o.Id = '" + cbbIDB.Text + "')";
            xuat.readDatathroughAdapter(check, dtXuat);
            if (dtXuat.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã đơn xuất.", "Thông báo.");
            }
            else
            {
                SqlCommand del1 = new SqlCommand("delete from OUTPUT where Id = '" + cbbIDB.Text + "'");
                SqlCommand del2 = new SqlCommand("delete from OUTPUTINFO where Id = '" + cbbIDB.Text + "'");
                xuat.executeQuery(del1);
                xuat.executeQuery(del2);
                MessageBox.Show("Xóa đơn xuất thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        private void frmExport_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát khỏi phần mềm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /IM QuanLyKho-TT.exe");
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            Views.frmUser frmUser = new Views.frmUser();
            frmUser.Show();
            Hide();
        }

        void search()
        {
            dtXuat.Clear();
            string search = "select * " +
                "from OUTPUT o1, OUTPUTINFO o2, CUSTOMER c " +
                "where (o1.Id = o2.Id) and (c.Id = o2.IdCustomer) and (o1.Id = '" + cbbIDB.Text + "')";
            xuat.readDatathroughAdapter(search, dtXuat);
            if (dtXuat.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã đơn xuất.", "Thông báo.");
            }
            else
            {
                //lấy thông tin nhân viên từ dtb
                numberB.Text = dtXuat.Rows[0]["Count"].ToString();
                cbbCusB.Text = dtXuat.Rows[0]["DisplayName"].ToString();
                tbStatus.Text = dtXuat.Rows[0]["Status"].ToString();
                MessageBox.Show("Tìm kiếm thành công.", "Thông báo.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (cbbIDB.Text == "0")
            {
                MessageBox.Show("Vui lòng kiêm tra lại thông tin tìm kiếm.", "Thông báo.");
            }   
            else
            {
                search();
            }
        }

        private void cbbIDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearData();
        }
    }
}