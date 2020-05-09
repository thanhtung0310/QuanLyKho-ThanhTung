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
using DevExpress.DirectX.Common.DirectWrite;

namespace QuanLyKho_TT.Views
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        AccessDataBase nhap = new AccessDataBase();
        DataTable dtNhap = new DataTable();
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

        public void loadData()
        {
            //load thông tin ở 2 bảng và 2 cbb
            //bảng vật tư
            SqlDataAdapter da1 = new SqlDataAdapter("select Id, DisplayName from Object", AccessDataBase.connection);
            DataTable dtObject = new DataTable();

            da1.Fill(dtObject);
            dgv1.DataSource = dtObject;
            //combobox Vật tư
            cbbObjA.ValueMember = "Id";
            cbbObjA.DataSource = dtObject;
            cbbObjB.ValueMember = "Id";
            cbbObjB.DataSource = dtObject;
            //bảng đơn nhập
            SqlDataAdapter da2 = new SqlDataAdapter("select input.Id, obj.DisplayName, Count, InputPrice, OutputPrice, Status, InputDate " +
                "from INPUT input, INPUTINFO inputinfo, OBJECT obj " +
                "where input.Id = inputinfo.IdInput and inputinfo.IdObject = obj.Id", AccessDataBase.connection);
            DataTable dtNhap1 = new DataTable();

            da2.Fill(dtNhap1);
            dgv.DataSource = dtNhap1;
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
            DataTable d1 = new DataTable();
            DataTable d2 = new DataTable();
            DataTable d3 = new DataTable();
            //theo mã đơn hàng, nhập hàng theo yêu cầu
            //nếu mã đã có thì thêm vào InputInfo
            //nếu mã chưa có thì thêm vào Input + InputInfo
            if (tbIDA.Text == "0" && cbbObjA.Text == "" && numberA.Value.ToString() == "" && tbInpPriceA.Text == "0" && tbOutPriceA.Text == "0")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập.", "Thông báo.");
            }
            else
            {
                //nếu có mã nhập
                nhap.readDatathroughAdapter("Select i1.Id from INPUT i1, INPUTINFO i2 where (i1.Id = i2.IdInput) and (i1.Id = '" + tbIDA.Text + "')", dtNhap);
                if (dtNhap.Rows.Count != 0)
                {
                    string check1 = "Select IdInput, IdObject from INPUTINFO where (IdInput = '" + tbIDA.Text + "') and (IdObject = '" + cbbObjA.SelectedValue + "')";
                    nhap.readDatathroughAdapter(check1, d1);
                    //nếu có vật tư 
                    if (d1.Rows.Count != 0)
                    {
                        string check2 = "Select IdInput, IdObject, InputPrice from INPUTINFO where (IdInput = '" + tbIDA.Text + "') and (IdObject = '" + cbbObjA.SelectedValue + "') and (InputPrice = '" + tbInpPriceA.Text + "')";
                        nhap.readDatathroughAdapter(check2, d2);
                        //nếu có giá nhập -> kiêm tra tiếp
                        if (d2.Rows.Count != 0)
                        {
                            string check3 = "Select IdInput, IdObject, InputPrice, OutputPrice from INPUTINFO where (IdInput = '" + tbIDA.Text + "') and (IdObject = '" + cbbObjA.SelectedValue + "') and (InputPrice = '" + tbInpPriceA.Text + "') and (OutputPrice = '" + tbOutPriceA.Text + "')";
                            nhap.readDatathroughAdapter(check3, d3);
                            //nếu có giá xuất -> cộng thêm count
                            if (d3.Rows.Count == 0)
                            {
                                SqlCommand add32 = new SqlCommand("insert into INPUTINFO(IdObject,IdInput,Count,InputPrice,OutputPrice) values ('" + cbbObjA.Text + "','" + tbIDA.Text + "','" + numberA.Value.ToString() + "','" +
                                    tbInpPriceA.Text + "','" + tbOutPriceA.Text + "')");
                                nhap.executeQuery(add32);
                                MessageBox.Show("Thêm mới vật tư thành công.", "Thông báo.");
                            }
                            //chưa có giá xuất -> thêm mới
                            else
                            {
                                SqlCommand add3 = new SqlCommand("update INPUTINFO set Count = Count + '" + numberA.Value.ToString() + "' where (IdObject = '" + cbbObjA.SelectedValue
                            + "') and (InputPrice = '" + tbInpPriceA.Text + "') and (OutputPrice = '" + tbOutPriceA.Text + "')");
                                nhap.executeQuery(add3);
                                MessageBox.Show("Cập nhật thành công.", "Thông báo.");
                            }
                        }
                        //nếu chưa có giá nhập -> thêm mới
                        else
                        {
                            SqlCommand add2 = new SqlCommand("insert into INPUTINFO(IdObject,IdInput,Count,InputPrice,OutputPrice) values ('" + cbbObjA.Text + "','" + tbIDA.Text + "','" + numberA.Value.ToString() + "','" +
                        tbInpPriceA.Text + "','" + tbOutPriceA.Text + "')");
                            nhap.executeQuery(add2);
                            MessageBox.Show("Thêm mới vật tư thành công.", "Thông báo.");
                        }
                    }
                    //nếu chưa có vật tư
                    else
                    {
                        SqlCommand add1 = new SqlCommand("insert into INPUTINFO(IdObject,IdInput,Count,InputPrice,OutputPrice) values ('" + cbbObjA.Text + "','" + tbIDA.Text + "','" + numberA.Value.ToString() + "','" +
                        tbInpPriceA.Text + "','" + tbOutPriceA.Text + "')");
                        nhap.executeQuery(add1);
                        MessageBox.Show("Thêm mới vật tư thành công.", "Thông báo.");
                    }
                }
                //nếu chưa có mã nhâp
                else
                {
                    SqlCommand add01 = new SqlCommand("insert into INPUTINFO(IdObject,IdInput,Count,InputPrice,OutputPrice) values ('" + cbbObjA.Text + "','" + tbIDA.Text + "','" + numberA.Value.ToString() + "','" +
                        tbInpPriceA.Text + "','" + tbOutPriceA.Text + "')");
                    SqlCommand add02 = new SqlCommand("insert into INPUT(Id,InputDate) values ('" + tbIDA.Text + "','" + dateA.Value.ToString() + "')");
                    nhap.executeQuery(add02);
                    nhap.executeQuery(add01);
                    MessageBox.Show("Thêm đơn nhập mới thành công.", "Thông báo.");
                }
            }
            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataTable d1 = new DataTable();
            if (tbIDB.Text == "0" & cbbObjB.Text == "" & numberB.Value.ToString() == "" & tbInpPriceB.Text == "0" & tbOutPriceB.Text == "0" & tbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin chỉnh sửa.", "Thông báo.");
            }
            else
            {
                //nếu có mã nhập
                nhap.readDatathroughAdapter("Select i1.Id from INPUT i1, INPUTINFO i2 where (i1.Id = i2.IdInput) and (i1.Id = '" + tbIDB.Text + "')", dtNhap);
                if (dtNhap.Rows.Count != 0)
                {
                    string check1 = "Select IdInput, IdObject from INPUTINFO where (IdInput = '" + tbIDB.Text + "') and (IdObject = '" + cbbObjB.SelectedValue + "')";
                    nhap.readDatathroughAdapter(check1, d1);
                    //nếu có vật tư 
                    if (d1.Rows.Count != 0)
                    {
                        SqlCommand edit1 = new SqlCommand("Update INPUTINFO set InputPrice = '" + tbInpPriceB.Text + "', OutputPrice = '" + tbOutPriceB.Text + "', Status = '" + tbStatus.Text
                            + "' where IdInput = '" + tbIDB.Text + "' and IdObject = '" + cbbObjB.Text + "'");
                        nhap.executeQuery(edit1);
                        MessageBox.Show("Chỉnh sửa đơn thành công.", "Thông báo.");
                    }
                    //nếu chưa có vật tư
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại vật tư.", "Thông báo.");
                    }
                }
                //nếu chưa có mã nhâp
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mã đơn.", "Thông báo.");
                }
            }
            loadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataTable d1 = new DataTable();
            if (tbIDB.Text == "0" & cbbObjB.Text == "" & numberB.Value.ToString() == "" & tbInpPriceB.Text == "0" & tbOutPriceB.Text == "0" & tbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin chỉnh sửa.", "Thông báo.");
            }
            else
            {
                //nếu có mã nhập
                nhap.readDatathroughAdapter("Select i1.Id from INPUT i1, INPUTINFO i2 where (i1.Id = i2.IdInput) and (i1.Id = '" + tbIDB.Text + "')", dtNhap);
                if (dtNhap.Rows.Count != 0)
                {
                    SqlCommand del1 = new SqlCommand("delete from INPUTINFO where IdInput = '" + tbIDB.Text + "'");
                    SqlCommand del2 = new SqlCommand("delete from OUTPUTINFO where IdObject = '" + cbbObjB.SelectedValue + "'");
                    SqlCommand del3 = new SqlCommand("delete from INPUT where Id = '" + tbIDB.Text + "'");
                    nhap.executeQuery(del1);
                    nhap.executeQuery(del2);
                    nhap.executeQuery(del3);
                    MessageBox.Show("Xóa đơn thành công.", "Thông báo.");
                }
                //nếu chưa có mã nhâp
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mã đơn.", "Thông báo.");
                }
            }
            loadData();
        }

        private void cbbObjB_TextChanged(object sender, EventArgs e)
        {    /*
            //sau khi nhập mã đơn
            string search = "select * from INPUTINFO inputinfo, INPUT input where (inputinfo.IdInput = input.Id) and (IdObject = '" + cbbObjB.SelectedValue + "') and (input.Id = '" + tbIDB.Text + "')";
            //string search = "select * from INPUTINFO where IdInput = '" + tbIDB.Text + "'";
            nhap.readDatathroughAdapter(search, dtNhap);
            if (dtNhap.Rows.Count == 0)
            {
                
            }
            else
            {
                //lấy thông tin nhân viên từ dtb
                cbbObjB.Text = dtNhap.Rows[0]["IdObject"].ToString();
                numberB.Text = dtNhap.Rows[0]["Count"].ToString();
                tbInpPriceB.Text = dtNhap.Rows[0]["InputPrice"].ToString();
                tbOutPriceB.Text = dtNhap.Rows[0]["OutputPrice"].ToString();
            } */
        }

        private void logo_Click(object sender, EventArgs e)
        {
            labelHome_Click(this, new EventArgs());
        }
    }
}