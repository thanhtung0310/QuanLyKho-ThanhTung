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
using DevExpress.Data.Async;
using QuanLyKho_TT.Model;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;

namespace QuanLyKho_TT.Views
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase khachhang = new AccessDataBase();
        DataTable dtCus = new DataTable();

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load danh sách khách hàng có trong CSDL
            loadData();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            //thêm mới khách hàng
            if (tbNameA.Text == "" || tbAddressA.Text == "" || tbPhoneA.Text == "" || tbEmailA.Text == "" || tbInfoA.Text == "" || dateA.Value == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập.", "Thông báo.");
            }
            else
            {
                SqlCommand add = new SqlCommand("insert into Customer values ('" + tbNameA.Text + "','" + tbAddressA.Text + "','" +
                    tbPhoneA.Text + "','" + tbEmailA.Text + "','" + tbInfoA.Text + "','" + dateA.Value.ToString() + "')");
                khachhang.executeQuery(add);
                MessageBox.Show("Thêm mới thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //chỉnh sửa các thông tin khách hàng
            if (tbNameB.Text == "" || tbAddressB.Text == "" || tbPhoneB.Text == "" || tbEmailB.Text == "" || tbInfoB.Text == "" || dateB.Value == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin chỉnh sửa.", "Thông báo.");
            }
            else
            {
                SqlCommand edit = new SqlCommand("update Customer set Address = '" + tbAddressB.Text
                    + "', ContactNum = '" + tbPhoneB.Text + "', Email = '" + tbEmailB.Text + "', AddInfo = '" + tbInfoB.Text + "', ContractDate = '" + dateB.Value.ToString()
                    + "' where DisplayName = N'" + tbNameB.Text + "'");
                khachhang.executeQuery(edit);
                MessageBox.Show("Chỉnh sửa thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //xóa thông tin khách hàng
            if (tbNameB.Text == "" || tbAddressB.Text == "" || tbPhoneB.Text == "" || tbEmailB.Text == "" || tbInfoB.Text == "" || dateB.Value == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin xóa.", "Thông báo.");
            }
            else
            {     
                SqlCommand delete = new SqlCommand("delete from Customer where DisplayName = N'" + tbNameB.Text + "'");
                khachhang.executeQuery(delete);
                MessageBox.Show("Xóa thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        private void loadData()
        {
            //Lấy danh sách thông tin khách hàng vào bảng
            SqlDataAdapter da = new SqlDataAdapter("select * from Customer", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void clearData()
        {
            tbNameB.Clear();
            tbAddressB.Clear();
            tbPhoneB.Clear();
            tbEmailB.Clear();
            tbInfoB.Clear();
            tbNameA.Clear();
            tbAddressA.Clear();
            tbPhoneA.Clear();
            tbEmailA.Clear();
            tbInfoA.Clear();
        }

        private void dataGridViewCustomer_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin khách hàng
            loadData();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int i = dgv.CurrentRow.Index;

            tbNameB.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbAddressB.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbPhoneB.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbEmailB.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tbInfoB.Text = dgv.Rows[i].Cells[4].Value.ToString();*/
        }

        private void dataGridViewCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }*/
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận đăng xuất ?", "Thông báo.", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Hide();
                frmLogin form = new frmLogin();
                form.Show();
            }
        }

        public void search()
        {
            string search = "select * from Customer where DisplayName = N'" + tbNameB.Text + "'";
            khachhang.readDatathroughAdapter(search, dtCus);
            if (dtCus.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên hiển thị.", "Thông báo.");
            }
            else
            {
                string date;
                //lấy thông tin nhân viên từ dtb
                tbAddressB.Text = dtCus.Rows[0]["Address"].ToString();
                tbPhoneB.Text = dtCus.Rows[0]["ContactNum"].ToString();
                tbEmailB.Text = dtCus.Rows[0]["Email"].ToString();
                tbInfoB.Text = dtCus.Rows[0]["AddInfo"].ToString();
                date = dtCus.Rows[0]["ContractDate"].ToString();
                dateB.Text = date;
            }
        }

        private void tbNameB_KeyDown(object sender, KeyEventArgs e)
        {
            //nhấn F11 để tìm kiếm nhanh thông tin
            if (e.KeyCode == Keys.F11)
            {
                if (tbNameB.Text == "")
                {
                    MessageBox.Show("Vui lòng kiêm tra lại thông tin tìm kiếm.", "Thông báo.");
                }    
                else
                {
                    search();
                }    
            }
        }

        private void tbNameB_Click(object sender, EventArgs e)
        {
            dtCus.Clear();
            MessageBox.Show("Sau khi nhập tên hiển thị vui lòng ấn nut F11 để tự động nhập nốt các thông tin còn lại.", "Thông báo.");
            clearData();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}