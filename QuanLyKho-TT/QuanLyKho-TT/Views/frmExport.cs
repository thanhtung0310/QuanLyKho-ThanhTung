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
    public partial class frmExport : DevExpress.XtraEditors.XtraForm
    {
        //Cho phép Admin, Nhân viên
        public frmExport()
        {
            InitializeComponent();
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load 2 bảng và 2cbb
            loadData();
        }

        private void loadData()
        {
            //load thông tin 2 dgv và 2cbb khách hàng
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
            //nhập mã (mã INputInfo)
            //Nhập số lượng -> OutputInfo
            //chọn khách hàng
            //chọn ngày -> Outputs
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //nhập mã InputInfo -> lấy thông tin
            //thay đổi số lượng, khách hàng, thời gian
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

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