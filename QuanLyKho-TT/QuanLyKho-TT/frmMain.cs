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

namespace QuanLyKho_TT
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        //Cho phép Admin, Nhân viên, Khách hàng
        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            Views.frmImport frmImport = new Views.frmImport();
            frmImport.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Views.frmExport frmExport = new Views.frmExport();
            frmExport.Show();
        }

        private void buttonObject_Click(object sender, EventArgs e)
        {
            Views.frmObject frmObject = new Views.frmObject();
            frmObject.Show();
        }

        private void buttonUnit_Click(object sender, EventArgs e)
        {
            Views.frmUnit frmUnit = new Views.frmUnit();
            frmUnit.Show();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            Views.frmSupplier frmSupplier = new Views.frmSupplier();
            frmSupplier.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Views.frmCustomer frmCustomer = new Views.frmCustomer();
            frmCustomer.Show();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            Views.frmUser frmUser = new Views.frmUser();
            frmUser.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với phần mềm QUẢN LÝ KHO HÀNG", "Thông báo.");

            //cập nhật tên người dùng

            //cập nhật số lượng hàng nhập, hàng xuất, hàng tồn kho
        }

        private void groupControl1_Click(object sender, EventArgs e)
        {
            //cập nhật số lượng hàng nhập
        }

        private void groupControl2_Click(object sender, EventArgs e)
        {
            //cập nhật số lượng hàng xuất
        }

        private void groupControl3_Click(object sender, EventArgs e)
        {
            //cập nhật số lượng hàng tồn
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin vật tư
        }
    }
}