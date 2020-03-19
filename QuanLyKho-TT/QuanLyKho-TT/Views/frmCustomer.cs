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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        //cho phép Admin, Nhân viên, Khách hàng
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng

            //load thông tin người dùng có displayName
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin người dùng theo yêu cầu
        }
    }
}