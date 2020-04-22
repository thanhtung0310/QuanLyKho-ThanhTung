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
using DevExpress.Data.Async;
using QuanLyKho_TT.Model;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;

namespace QuanLyKho_TT.Views
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase khachhang = new AccessDataBase();
        DataTable dtCus = new DataTable();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load danh sách khách hàng có trong CSDL
            loadData();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            //thêm mới vật tư 

            loadData();
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

        private void loadData()
        {
            //Lấy danh sách thông tin khách hàng vào bảng
            /*SqlDataAdapter da = new SqlDataAdapter("select * from Customer", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgv.DataSource = dt;*/
        }

        private void clearData()
        {
            /*tbNameB.Clear();
            tbAddressB.Clear();
            tbPhoneB.Clear();
            tbEmailB.Clear();
            tbInfoB.Clear();*/
        }

        private void dataGridViewCustomer_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin khách hàng
            loadData();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int i = dgv.CurrentRow.Index;

            tbNameB.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbAddressB.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbPhoneB.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbEmailB.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tbInfoB.Text = dgv.Rows[i].Cells[4].Value.ToString();*/
        }

        private void dataGridViewCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }*/
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
    }
}