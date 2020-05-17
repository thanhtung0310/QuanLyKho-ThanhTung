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
        //Cho phép Admin, Nhân viên
        public frmExport()
        {
            InitializeComponent();
        }
        AccessDataBase xuat = new AccessDataBase();
        DataTable dtXuat = new DataTable();
        private void frmExport_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load 2 bảng và 2cbb
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select i1.Id, o.DisplayName, i1.Count, i1.OutputPrice " +
               "from INPUTINFO i1, OBJECT o where i1.IdObject = o.Id", AccessDataBase.connection);
            DataTable dtNhap = new DataTable();

            da1.Fill(dtNhap);
            dgv1.DataSource = dtNhap;
            cbbIDA.DisplayMember = "Id";
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
                "where o1.Id = o2.Id and o2.IdCustomer = c.Id and o2.IdInputInfo = i.Id and i.IdObject = o.Id", AccessDataBase.connection);
            DataTable dtXuat = new DataTable();

            da3.Fill(dtXuat);
            dgv.DataSource = dtXuat;
            cbbIDB.DisplayMember = "Id";
            cbbIDB.DataSource = dtXuat;
            //cbb mã nhập
            SqlDataAdapter da4 = new SqlDataAdapter("select * from INPUtINFO", AccessDataBase.connection);
            DataTable dtMaNhap = new DataTable();

            da4.Fill(dtMaNhap);
            cbbIDA.DisplayMember = "Id";
            cbbIDA.DataSource = dtMaNhap;
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

        private void labelHome_Click_1(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (cbbIDA.Text == "0" && numberA.Value.ToString() == "0" && cbbCusA.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập.", "Thông báo.");
            }
            else
            {
                string check = "select * from OUTPUT where Id ='" + tbIDOA.Text + "'";
                xuat.readDatathroughAdapter(check, dtXuat);
                if (dtXuat.Rows.Count != 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mã xuất.", "Thông báo.");
                }
                else
                {
                    SqlCommand add1 = new SqlCommand("insert into OUTPUT(Id,OutputDate) values ('" + tbIDOA.Text + "','" + dateA.Value.ToString() + "')");
                    SqlCommand add2 = new SqlCommand("insert into OUTPUTINFO(Id,IdInputInfo,IdCustomer,Count) values ('" + tbIDOA.Text + "','" + cbbIDA.Text
                        + "','" + cbbCusA.SelectedValue + "','" + numberA.Value.ToString() + "')");
                    xuat.executeQuery(add1);
                    xuat.executeQuery(add2);
                    MessageBox.Show("Thêm đơn thành công.", "Thông báo.");
                }
            }
            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (cbbIDB.Text == "0" && numberB.Value.ToString() == "0" && cbbCusB.Text == "" && tbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng kiêm tra lại thông tin chỉnh sửa.", "Thông báo.");
            }
            else
            {
                SqlCommand edit = new SqlCommand("update OUTPUTINFO set Count = '" + numberB.Value.ToString() + "', IdCustomer = '" + cbbCusB.SelectedValue +
                    "', Status = '" + tbStatus.Text + "' where Id = '" + cbbIDB.Text + "'");
                xuat.executeQuery(edit);
                MessageBox.Show("Chỉnh sửa thành công.", "Thông báo.");
            }
            loadData();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string check = "select * from OUTPUT o, OUTPUTINFO o1 where o.Id = o1.Id and o.Id = '" + cbbIDB.Text + "'";
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
    }
}