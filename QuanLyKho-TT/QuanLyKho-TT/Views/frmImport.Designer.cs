namespace QuanLyKho_TT.Views
{
    partial class frmImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.labelHello = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInpPriceA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutPriceA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberA = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.cbbObjA = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numberB = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbObjB = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOutPriceB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbInpPriceB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(870, 20);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(130, 17);
            this.labelHello.TabIndex = 19;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHome.Location = new System.Drawing.Point(185, 32);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(131, 16);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "< Về màn hình chính";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "LẬP ĐƠN NHẬP HÀNG";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(18, 64);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(79, 26);
            this.labelID.TabIndex = 38;
            this.labelID.Text = "Vật tư:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Số lượng: ";
            // 
            // tbInpPriceA
            // 
            this.tbInpPriceA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbInpPriceA.Location = new System.Drawing.Point(209, 150);
            this.tbInpPriceA.Multiline = true;
            this.tbInpPriceA.Name = "tbInpPriceA";
            this.tbInpPriceA.Size = new System.Drawing.Size(283, 30);
            this.tbInpPriceA.TabIndex = 3;
            this.tbInpPriceA.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá nhập: ";
            // 
            // tbOutPriceA
            // 
            this.tbOutPriceA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbOutPriceA.Location = new System.Drawing.Point(209, 193);
            this.tbOutPriceA.Multiline = true;
            this.tbOutPriceA.Name = "tbOutPriceA";
            this.tbOutPriceA.Size = new System.Drawing.Size(283, 30);
            this.tbOutPriceA.TabIndex = 4;
            this.tbOutPriceA.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Giá bán: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 26);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ngày khởi tạo:";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(175, 289);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(164, 39);
            this.buttonA.TabIndex = 7;
            this.buttonA.Text = "Thêm mới";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberA);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.cbbObjA);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dateA);
            this.groupBox1.Controls.Add(this.buttonA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbOutPriceA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbInpPriceA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(511, 343);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // numberA
            // 
            this.numberA.Font = new System.Drawing.Font("Cambria", 14F);
            this.numberA.Location = new System.Drawing.Point(209, 105);
            this.numberA.Multiline = true;
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(283, 30);
            this.numberA.TabIndex = 2;
            this.numberA.Text = "0";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(442, 29);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(45, 21);
            this.num1.TabIndex = 0;
            // 
            // cbbObjA
            // 
            this.cbbObjA.Font = new System.Drawing.Font("Cambria", 13F);
            this.cbbObjA.FormattingEnabled = true;
            this.cbbObjA.Location = new System.Drawing.Point(209, 64);
            this.cbbObjA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbObjA.Name = "cbbObjA";
            this.cbbObjA.Size = new System.Drawing.Size(283, 28);
            this.cbbObjA.TabIndex = 1;
            this.cbbObjA.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F);
            this.label14.Location = new System.Drawing.Point(381, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Đơn số";
            // 
            // dateA
            // 
            this.dateA.Font = new System.Drawing.Font("Cambria", 14F);
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateA.Location = new System.Drawing.Point(209, 234);
            this.dateA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateA.Name = "dateA";
            this.dateA.Size = new System.Drawing.Size(283, 29);
            this.dateA.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.numberB);
            this.groupBox2.Controls.Add(this.num2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbObjB);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbOutPriceB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbInpPriceB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(549, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(511, 343);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSearch.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(327, 129);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 39);
            this.buttonSearch.TabIndex = 59;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // numberB
            // 
            this.numberB.Font = new System.Drawing.Font("Cambria", 14F);
            this.numberB.Location = new System.Drawing.Point(141, 158);
            this.numberB.Multiline = true;
            this.numberB.Name = "numberB";
            this.numberB.Size = new System.Drawing.Size(83, 30);
            this.numberB.TabIndex = 10;
            this.numberB.Text = "0";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(435, 28);
            this.num2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(45, 21);
            this.num2.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10F);
            this.label15.Location = new System.Drawing.Point(374, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Đơn số";
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbStatus.Location = new System.Drawing.Point(141, 201);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(340, 76);
            this.tbStatus.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tình trạng: ";
            // 
            // cbbObjB
            // 
            this.cbbObjB.Font = new System.Drawing.Font("Cambria", 13F);
            this.cbbObjB.FormattingEnabled = true;
            this.cbbObjB.Location = new System.Drawing.Point(102, 58);
            this.cbbObjB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbObjB.Name = "cbbObjB";
            this.cbbObjB.Size = new System.Drawing.Size(83, 28);
            this.cbbObjB.TabIndex = 9;
            this.cbbObjB.Text = "1";
            this.cbbObjB.TextChanged += new System.EventHandler(this.cbbObjB_TextChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(61, 289);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 39);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Cập nhật";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(311, 289);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 39);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "CHỈNH SỬA VÀ XÓA ";
            // 
            // tbOutPriceB
            // 
            this.tbOutPriceB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbOutPriceB.Location = new System.Drawing.Point(322, 93);
            this.tbOutPriceB.Multiline = true;
            this.tbOutPriceB.Name = "tbOutPriceB";
            this.tbOutPriceB.Size = new System.Drawing.Size(159, 30);
            this.tbOutPriceB.TabIndex = 12;
            this.tbOutPriceB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(201, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Giá bán: ";
            // 
            // tbInpPriceB
            // 
            this.tbInpPriceB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbInpPriceB.Location = new System.Drawing.Point(322, 57);
            this.tbInpPriceB.Multiline = true;
            this.tbInpPriceB.Name = "tbInpPriceB";
            this.tbInpPriceB.Size = new System.Drawing.Size(159, 30);
            this.tbInpPriceB.TabIndex = 11;
            this.tbInpPriceB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(201, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 42;
            this.label9.Text = "Giá nhập: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(5, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 26);
            this.label10.TabIndex = 40;
            this.label10.Text = "Số lượng: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(5, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 26);
            this.label11.TabIndex = 38;
            this.label11.Text = "Vật tư:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(630, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 26);
            this.label13.TabIndex = 51;
            this.label13.Text = "Danh sách đơn nhập:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDon,
            this.TenHang,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.TinhTrang,
            this.NgayLap});
            this.dgv.Location = new System.Drawing.Point(397, 458);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(663, 125);
            this.dgv.TabIndex = 17;
            // 
            // MaDon
            // 
            this.MaDon.DataPropertyName = "Id";
            this.MaDon.HeaderText = "Mã đơn nhập";
            this.MaDon.MinimumWidth = 6;
            this.MaDon.Name = "MaDon";
            this.MaDon.ReadOnly = true;
            this.MaDon.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "DisplayName";
            this.TenHang.HeaderText = "Tên vật tư nhập";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "Count";
            this.SoLuong.HeaderText = "Số lượng nhập";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "InputPrice";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            this.GiaNhap.Width = 90;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "OutputPrice";
            this.GiaBan.HeaderText = "Giá xuất";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 90;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "Status";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "InputDate";
            this.NgayLap.HeaderText = "Ngày lập đơn";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(907, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Đăng xuất";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(102, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 26);
            this.label16.TabIndex = 53;
            this.label16.Text = "Danh sách vật tư:";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.dgv1.Location = new System.Drawing.Point(64, 458);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(269, 125);
            this.dgv1.TabIndex = 16;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Id";
            this.Ma.HeaderText = "Mã vật tư";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "DisplayName";
            this.Ten.HeaderText = "Tên vật tư";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(1102, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 68);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 17);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(171, 47);
            this.logo.TabIndex = 58;
            this.logo.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1002, 6);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(72, 68);
            this.avatar.TabIndex = 60;
            this.avatar.TabStop = false;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 598);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelHello);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmImport.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmImport";
            this.Text = "Nhập hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImport_FormClosing);
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInpPriceA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutPriceA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOutPriceB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbInpPriceB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbObjA;
        private System.Windows.Forms.ComboBox cbbObjB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox numberA;
        private System.Windows.Forms.TextBox numberB;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox avatar;
    }
}