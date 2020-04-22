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
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        //Cho phép Admin, Nhân viên
        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load thông tin trong bảng và cbb
            loadData();
        }

        private void loadData()
        {
            //load thông tin ở 2 bảng và 2 cbb
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
            //theo mã đơn hàng, nhập hàng theo yêu cầu
            //nếu mã đã có thì thêm vào InputInfo
            //nếu mã chưa có thì thêm vào Input + InputInfo
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //theo mã đơn hàng và mã vật tư, chỉnh sửa thông tin
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //theo mã đơn hàng và mã vật tư, xóa thông tin 
        }

        private void cbbObjB_TextChanged(object sender, EventArgs e)
        {
            //sau khi nhập mã đơn
            //chọn vật tư thì tự động điền thông tin đơn
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }
    }
}