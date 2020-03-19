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
    public partial class frmObject : DevExpress.XtraEditors.XtraForm
    {
        //Cho phép Admin, Nhân viên
        public frmObject()
        {
            InitializeComponent();
        }

        private void frmObject_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng

            //load danh sách vật tư có trong CSDL
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            //thêm mới vật tư 
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //chỉnh sửa các thông tin vật tư
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //lấy nhanh thông tin vật tư
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //xóa thông tin vật tư
        }

        private void dataGridViewObject_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin vật tư
        }
    }
}