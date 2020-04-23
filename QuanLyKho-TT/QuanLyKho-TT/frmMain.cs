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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase main = new AccessDataBase();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Chào mừng đến với phần mềm QUẢN LÝ KHO HÀNG", "Thông báo.");

            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //cập nhật số lượng hàng nhập, hàng xuất, hàng tồn kho
            loadData();
            
        }

        private void loadData()
        {
            //load tất cả thông tin có trong form 
            SqlDataAdapter da = new SqlDataAdapter("select DisplayName, SUM(input.Count) LuongNhap, SUM(output.Count) LuongXuat " +
                "from INPUTINFO input, OUTPUTINFO output, OBJECT obj " +
                "where input.IdObject = obj.Id and output.IdInputInfo = input.Id " +
                "group by DisplayName", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgv.DataSource = dt;

            //số lượng nhập
            SqlCommand soNhap = new SqlCommand("select SUM(Count)from INPUTINFO", AccessDataBase.connection);
            int numIn = (int)soNhap.ExecuteScalar();
            labelIn.Text = numIn.ToString();
            //số lượng xuất
            SqlCommand soXuat = new SqlCommand("select SUM(Count)from OUTPUTINFO", AccessDataBase.connection);
            int numOut = (int)soXuat.ExecuteScalar();
            labelOut.Text = numOut.ToString();
            //số lượng tồn
            int numStore = numIn - numOut;
            labelStore.Text = numStore.ToString();
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

        private void buttonImport_Click(object sender, EventArgs e)
        {
            Views.frmImport frmImport = new Views.frmImport();
            frmImport.Show();
            Hide();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Views.frmExport frmExport = new Views.frmExport();
            frmExport.Show();
            Hide();
        }

        private void buttonObject_Click(object sender, EventArgs e)
        {
            Views.frmObject frmObject = new Views.frmObject();
            frmObject.Show();
            Hide();
        }

        private void buttonUnit_Click(object sender, EventArgs e)
        {
            Views.frmUnit frmUnit = new Views.frmUnit();
            frmUnit.Show();
            Hide();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            Views.frmSupplier frmSupplier = new Views.frmSupplier();
            frmSupplier.Show();
            Hide();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Views.frmCustomer frmCustomer = new Views.frmCustomer();
            frmCustomer.Show();
            Hide();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            Views.frmUser frmUser = new Views.frmUser();
            frmUser.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buttonUser_Click(this, new EventArgs());
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
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