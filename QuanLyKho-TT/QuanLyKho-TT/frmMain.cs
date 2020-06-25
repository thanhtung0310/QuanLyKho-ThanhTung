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
using QuanLyKho_TT.Views;

namespace QuanLyKho_TT
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase main = new AccessDataBase();

        Views.frmImport frmImport = new Views.frmImport();
        Views.frmObject frmObject = new Views.frmObject();
        Views.frmCustomer frmCustomer = new Views.frmCustomer();
        Views.frmSupplier frmSupplier = new Views.frmSupplier();
        Views.frmUnit frmUnit = new Views.frmUnit();
        Views.frmExport frmExport = new Views.frmExport();
        Views.frmUser frmUser = new Views.frmUser();

        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Chào mừng đến với phần mềm QUẢN LÝ KHO HÀNG", "Thông báo.");

            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //cập nhật số lượng hàng nhập, hàng xuất, hàng tồn kho
            loadData();

            checkQuyen();
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
            
            frmImport.Show();
            Hide();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            frmExport.Show();
            Hide();
        }

        private void buttonObject_Click(object sender, EventArgs e)
        {
            frmObject.Show();
            Hide();
        }

        private void buttonUnit_Click(object sender, EventArgs e)
        {
            frmUnit.Show();
            Hide();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier.Show();
            Hide();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer.Show();
            Hide();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
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

        void checkQuyen()
        {
            string permission = frmLogin.quyen;
            if (permission == "1")
            {
                MessageBox.Show("Chào ADMIN.");
                frmImport.Enabled = true;
                frmExport.Enabled = true;
                frmCustomer.Enabled = true;
                frmObject.Enabled = true;
                frmSupplier.Enabled = true;
                frmUnit.Enabled = true;
                frmUser.Enabled = true;
            }
            else if (permission == "2")
            {
                MessageBox.Show("Chào STAFF.");
                frmImport.Enabled = true;
                frmExport.Enabled = true;
                frmCustomer.Enabled = true;
                buttonObject.Enabled = false;
                buttonSupplier.Enabled = false;
                buttonUnit.Enabled = false;
                frmUser.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chào BẠN?");
                buttonImport.Enabled = false;
                buttonExport.Enabled = false;
                buttonCustomer.Enabled = false;
                buttonObject.Enabled = false;
                buttonSupplier.Enabled = false;
                buttonUnit.Enabled = false;
                frmUser.Enabled = true;
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelIn_Click(object sender, EventArgs e)
        {

        }
    }
}