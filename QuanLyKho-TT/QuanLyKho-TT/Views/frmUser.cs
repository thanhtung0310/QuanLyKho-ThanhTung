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
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase user = new AccessDataBase();

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";
            labelName.Text = frmLogin.tendangnhap;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin người dùng
            if (tbOldPass.Text != frmLogin.matkhaucu)
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu cũ.", "Thông báo.");
            }
            else
            {
                if (tbNewPass.Text != tbNewPass2.Text)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu mới.","Thông báo.");
                }
                else
                {
                    if (tbOldPass.Text == tbNewPass.Text)
                    {
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ.", "Thông báo.");
                    }
                    else
                    {
                        SqlCommand edit = new SqlCommand("update Users set Password = '" + tbNewPass.Text + "' where Username = '" + labelName.Text + "'");
                        user.executeQuery(edit);
                        MessageBox.Show("Cập nhật mật khẩu thành công. Vui lòng đăng nhập lại.", "Thông báo.");
                        Hide();
                        frmLogin form = new frmLogin();
                        form.Show();
                    }                        
                }   
            }
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận đăng xuất ?", "Thông báo.", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Hide();
                frmLogin form = new frmLogin();
                form.Show();
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
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