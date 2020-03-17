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

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "";
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Text = "";
        }

        private void txbPasswordR_Click(object sender, EventArgs e)
        {
            txbPasswordR.Text = "";
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand search = new SqlCommand("select * from Users where Username = '" + txbUsername.Text + "'");
            SqlCommand insert = new SqlCommand("insert into Users(Username,Password) values('" + txbUsername.Text + "','" + txbPassword.Text + "')");

            if (txbPasswordR.Text == txbPassword.Text && txbUsername.Text != "" && txbPassword.Text != "" && txbPasswordR.Text != "")
            {
                MessageBox.Show("Đăng ký thành công.", "Thông báo");
                frmLogin login = new frmLogin();
                login.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng xem lại các thông tin ở trên.", "Thông báo");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}