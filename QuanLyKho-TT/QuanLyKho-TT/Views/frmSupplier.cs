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

namespace QuanLyKho_TT.Views
{
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        //Cho phép Admin
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
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

        private void tbNameB_KeyDown(object sender, KeyEventArgs e)
        {
            //nhấn nút F12 để tìm kiếm nhanh thông tin
            //giống frmCustomer
        }

        private void tbNameB_Click(object sender, EventArgs e)
        {
            //hiện thông báo 'nhấn nút f12'
            //giống frmCustomer
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void frmSupplier_FormClosing(object sender, FormClosingEventArgs e)
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