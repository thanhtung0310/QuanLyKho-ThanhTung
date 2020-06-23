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
using System.Data.SqlClient;
using QuanLyKho_TT.Model;

namespace QuanLyKho_TT.Views
{
    public partial class frmObject : DevExpress.XtraEditors.XtraForm
    {        
        AccessDataBase vatTu = new AccessDataBase();
        DataTable dtObject = new DataTable();

        public frmObject()
        {
            InitializeComponent();
        }

        private void frmObject_Load(object sender, EventArgs e)
        {
            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";

            //load danh sách vật tư có trong CSDL
            loadData();
        }

        private void loadData()
        {
            //Lấy danh sách thông tin khách hàng vào bảng
            SqlDataAdapter da = new SqlDataAdapter("select * from Object", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgv.DataSource = dt;

            //lấy danh sách đơn vị đo
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Unit", AccessDataBase.connection);
            DataTable dt1 = new DataTable();

            da1.Fill(dt1);
            dgv1.DataSource = dt1;
            cbbUnitA.DataSource = dt1;
            cbbUnitA.DisplayMember = "Id";
            cbbUnitB.DataSource = dt1;
            cbbUnitB.DisplayMember = "Id";

            //lấy danh sách nhà cung cấp
            SqlDataAdapter da2 = new SqlDataAdapter("select Id, DisplayName from Supplier", AccessDataBase.connection);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            dgv2.DataSource = dt2;
            cbbSupplierA.DataSource = dt2;
            cbbSupplierA.DisplayMember = "Id";
            cbbSupplierB.DataSource = dt2;
            cbbSupplierB.DisplayMember = "Id";
        }

        void clearData()
        {
            tbNameA.Clear();
            tbNameB.Clear();
            cbbSupplierA.Text = "1";
            cbbSupplierB.Text = "1";
            cbbUnitA.Text = "1";
            cbbUnitB.Text = "1";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            //thêm mới vật tư 
            if (tbNameA.Text == "" & cbbUnitA.Text == "1" & cbbSupplierA.Text == "1")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập.", "Thông báo.");
            }
            else
            {
                SqlCommand add = new SqlCommand("insert into Object values ('" + tbNameA.Text + "','" + cbbUnitA.Text + "','" + cbbSupplierA.Text + "')");
                vatTu.executeQuery(add);
                MessageBox.Show("Thêm mới thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //chỉnh sửa các thông tin vật tư
            if (tbNameB.Text == "" & cbbUnitB.Text == "" & cbbSupplierB.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin chỉnh sửa.", "Thông báo.");
            }
            else
            {
                SqlCommand edit = new SqlCommand("update Object set IdUnit = '" + cbbUnitB.Text + "', IdSupplier = '" + cbbSupplierB.Text + "' where DisplayName = N'" + tbNameB.Text + "'");
                vatTu.executeQuery(edit);
                MessageBox.Show("Chỉnh sửa thành công.", "Thông báo.");
                clearData();
            }
            loadData();
        }

        public void search()
        {
            dtObject.Clear();
            string search = "select * from Object where DisplayName = N'" + tbNameB.Text + "'";
            vatTu.readDatathroughAdapter(search, dtObject);
            if (dtObject.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên hiển thị.", "Thông báo.");
            }
            else
            {
                //lấy thông tin nhân viên từ dtb
                cbbUnitB.Text = dtObject.Rows[0]["IdUnit"].ToString();
                cbbSupplierB.Text = dtObject.Rows[0]["IdSupplier"].ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //xóa thông tin vật tư
            if (tbNameB.Text == "" & cbbUnitB.Text == "" & cbbSupplierB.Text == "")
            {

            }
            else
            {     
                SqlCommand delete = new SqlCommand("delete from Object where DisplayName = N'" + tbNameB.Text + "'");
                vatTu.executeQuery(delete);
                MessageBox.Show("Xóa thành công.", "Thông báo.");
            }
            loadData();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
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

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }

        private void frmObject_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tbNameB_KeyDown(object sender, KeyEventArgs e)
        {
            //nhấn F10 để tìm kiếm nhanh thông tin
            if (e.KeyCode == Keys.F10)
            {
                search();
            }
        }

        private void tbNameB_Click(object sender, EventArgs e)
        {
            dtObject.Clear();
            MessageBox.Show("Sau khi nhập tên hiển thị vui lòng ấn nut F10 để tự động nhập nốt các thông tin còn lại.", "Thông báo.");
            clearData();
        }
    }
}