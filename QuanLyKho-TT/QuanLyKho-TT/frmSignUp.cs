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
using QuanLyKho_TT.Model;
using System.Data.SqlClient;

namespace QuanLyKho_TT
{
    public partial class frmSignUp : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase dbAccess = new AccessDataBase();
        DataTable dtUsers = new DataTable();

        public frmSignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
            txbPasswordR.Text = "";
        }
        
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string search = "select * from Users where Username = '" + txbUsername.Text + "'";

            SqlCommand insert = new SqlCommand("insert into Users(DisplayName,Username,Password, IdRole) values('Guest','" + txbUsername.Text + "','" + txbPassword.Text + "', 3)");            
            dbAccess.readDatathroughAdapter(search, dtUsers);
            if (dtUsers.Rows.Count == 0 && txbPasswordR.Text == txbPassword.Text)
            {
                dbAccess.executeQuery(insert);
                MessageBox.Show("Đăng ký thành công!!!", "Thông báo.");
                frmLogin login = new frmLogin();
                login.Show();
                Hide();
            }
            if (dtUsers.Rows.Count != 0)
            {
                MessageBox.Show("Đã tồn tại tên đăng nhập. Vui lòng kiểm tra lại!!!", "Lỗi.");
                dtUsers.Clear();
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            Hide();
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
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