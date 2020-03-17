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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            signUp.Show();
            Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            /*if ()
            {*/
                MessageBox.Show("Đăng nhập thành công.", "Thông báo");
                main.Show();
                Hide();

           /* }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại. Vui lòng đăng ký trước khi đăng nhập.", "Thông báo");
            }*/
        }
        
        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "";
        }
        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            txbUsername.ForeColor = txbPassword.ForeColor;
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Text = "";
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
    }
}
