using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKho_TT.Model;

namespace QuanLyKho_TT
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        frmSignUp signUp = new frmSignUp();
        frmMain main = new frmMain();        

        AccessDataBase dbAccess = new AccessDataBase();
        DataTable dtUsers = new DataTable();
        
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        public static string tendangnhap;
        public static string matkhaucu;
        public static string quyen;

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            signUp.Show();
            Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            string query = "select * from users where Username = '" + username + "' and Password = '" + password + "'";

            dbAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count != 0)
            {
                quyen = dtUsers.Rows[0]["IdRole"].ToString();
                MessageBox.Show("Đăng nhập thành công!!!", "Thông báo.");
                tendangnhap = username;
                matkhaucu = password;
                
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại!!!", "Lỗi.");
            }            
        }
        
        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
        }
        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            txbUsername.ForeColor = txbPassword.ForeColor;
        }
        
        private void checkButtonShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButtonShow.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn_Click(this, new EventArgs());
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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
