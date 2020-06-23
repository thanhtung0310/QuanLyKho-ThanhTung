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

namespace QuanLyKho_TT.Views
{
    public partial class frmUnit : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase unit = new AccessDataBase();
        DataTable dtUnit = new DataTable();
        public frmUnit()
        {
            InitializeComponent();
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            //cập nhật danh sách đơn vị đo
            loadData();

            //cập nhật tên người dùng
            labelHello.Text = "Chào " + frmLogin.tendangnhap + ", ";
        }

        private void loadData()
        {
            //Lấy danh sách thông tin đơn vị đo vào bảng
            SqlDataAdapter da = new SqlDataAdapter("select * from Unit", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            //trở về màn hình chính
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int dem = 0;
            SqlCommand query_name = new SqlCommand("select DisplayName from Unit where DisplayName like N'" + tbNameA.Text + "'", AccessDataBase.connection);
            using (SqlDataReader reader = query_name.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Đọc kết quả
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader[0].ToString());
                        if (reader[0].ToString().Equals(tbNameA.Text))
                            dem = 1;
                    }
                }
            }
            if (dem == 1)
                XtraMessageBox.Show("Đơn vị đo đã tồn tại.", "Thông báo.");
            else
            {
                //Thêm mới đơn vị đo
                SqlCommand add = new SqlCommand("insert into Unit values('" + tbNameA.Text + "')");
                unit.executeQuery(add);
                MessageBox.Show("Thêm thành công.", "Thông báo.");
                loadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Xóa đi đơn vị đo
            SqlCommand delete = new SqlCommand("Delete from Unit where DisplayName = '" + tbNameB.Text + "'");
            unit.executeQuery(delete);
            MessageBox.Show("Xóa thành công.", "Thông báo.");
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            tbNameB.Text = dgv.Rows[i].Cells[1].Value.ToString();
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

        private void frmUnit_FormClosing(object sender, FormClosingEventArgs e)
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