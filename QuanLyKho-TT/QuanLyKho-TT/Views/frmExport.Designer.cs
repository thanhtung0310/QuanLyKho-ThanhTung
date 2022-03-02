namespace QuanLyKho_TT.Views
{
    partial class frmExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExport));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.maDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numberB = new System.Windows.Forms.TextBox();
            this.cbbIDB = new System.Windows.Forms.ComboBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbCusB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.buttonA = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberA = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.cbbIDA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCusA = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(310, 216);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 39);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(642, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 26);
            this.label13.TabIndex = 59;
            this.label13.Text = "Danh sách đơn xuất:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDon,
            this.tenHang,
            this.soluong,
            this.tenkh,
            this.dongia,
            this.Status,
            this.ngay});
            this.dgv.Location = new System.Drawing.Point(445, 389);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(631, 125);
            this.dgv.TabIndex = 14;
            // 
            // maDon
            // 
            this.maDon.DataPropertyName = "Id";
            this.maDon.HeaderText = "Mã đơn hàng";
            this.maDon.MinimumWidth = 6;
            this.maDon.Name = "maDon";
            this.maDon.ReadOnly = true;
            this.maDon.Width = 125;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "DisplayName";
            this.tenHang.HeaderText = "Tên vật tư";
            this.tenHang.MinimumWidth = 6;
            this.tenHang.Name = "tenHang";
            this.tenHang.ReadOnly = true;
            this.tenHang.Width = 90;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Count";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 80;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "DisplayName1";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            this.tenkh.Width = 125;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "OutputPrice";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.Width = 90;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình trạng";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 110;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "OutputDate";
            this.ngay.HeaderText = "Ngày lập đơn";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 36);
            this.label5.TabIndex = 36;
            this.label5.Text = "CHỈNH SỬA VÀ XÓA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(18, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Khách hàng: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(18, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 26);
            this.label10.TabIndex = 40;
            this.label10.Text = "Số lượng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.numberB);
            this.groupBox2.Controls.Add(this.cbbIDB);
            this.groupBox2.Controls.Add(this.tbStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbCusB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(549, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(511, 270);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSearch.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(342, 59);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 39);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // numberB
            // 
            this.numberB.Font = new System.Drawing.Font("Cambria", 14F);
            this.numberB.Location = new System.Drawing.Point(209, 98);
            this.numberB.Multiline = true;
            this.numberB.Name = "numberB";
            this.numberB.Size = new System.Drawing.Size(83, 30);
            this.numberB.TabIndex = 68;
            this.numberB.Text = "0";
            // 
            // cbbIDB
            // 
            this.cbbIDB.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.cbbIDB.FormattingEnabled = true;
            this.cbbIDB.Location = new System.Drawing.Point(437, 32);
            this.cbbIDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbIDB.Name = "cbbIDB";
            this.cbbIDB.Size = new System.Drawing.Size(55, 20);
            this.cbbIDB.TabIndex = 67;
            this.cbbIDB.Text = "0";
            this.cbbIDB.SelectedIndexChanged += new System.EventHandler(this.cbbIDB_SelectedIndexChanged);
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbStatus.Location = new System.Drawing.Point(209, 162);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(283, 45);
            this.tbStatus.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(18, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 26);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tình trạng: ";
            // 
            // cbbCusB
            // 
            this.cbbCusB.Font = new System.Drawing.Font("Cambria", 13F);
            this.cbbCusB.FormattingEnabled = true;
            this.cbbCusB.Location = new System.Drawing.Point(209, 130);
            this.cbbCusB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCusB.Name = "cbbCusB";
            this.cbbCusB.Size = new System.Drawing.Size(83, 28);
            this.cbbCusB.TabIndex = 6;
            this.cbbCusB.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10F);
            this.label11.Location = new System.Drawing.Point(356, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Chọn đơn ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(63, 216);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 39);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dateA
            // 
            this.dateA.Font = new System.Drawing.Font("Cambria", 14F);
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateA.Location = new System.Drawing.Point(207, 162);
            this.dateA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateA.Name = "dateA";
            this.dateA.Size = new System.Drawing.Size(283, 29);
            this.dateA.TabIndex = 6;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(173, 218);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(164, 39);
            this.buttonA.TabIndex = 7;
            this.buttonA.Text = "Thêm mới";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(16, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 26);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ngày khởi tạo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "LẬP ĐƠN XUẤT HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Khách hàng: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Số lượng: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberA);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.cbbIDA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbCusA);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dateA);
            this.groupBox1.Controls.Add(this.buttonA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(511, 270);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // numberA
            // 
            this.numberA.Font = new System.Drawing.Font("Cambria", 14F);
            this.numberA.Location = new System.Drawing.Point(207, 76);
            this.numberA.Multiline = true;
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(283, 30);
            this.numberA.TabIndex = 65;
            this.numberA.Text = "0";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(435, 41);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(54, 21);
            this.num1.TabIndex = 64;
            // 
            // cbbIDA
            // 
            this.cbbIDA.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.cbbIDA.FormattingEnabled = true;
            this.cbbIDA.Location = new System.Drawing.Point(435, 19);
            this.cbbIDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbIDA.Name = "cbbIDA";
            this.cbbIDA.Size = new System.Drawing.Size(55, 20);
            this.cbbIDA.TabIndex = 63;
            this.cbbIDA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F);
            this.label4.Location = new System.Drawing.Point(354, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Mã đơn:";
            // 
            // cbbCusA
            // 
            this.cbbCusA.Font = new System.Drawing.Font("Cambria", 13F);
            this.cbbCusA.FormattingEnabled = true;
            this.cbbCusA.Location = new System.Drawing.Point(207, 120);
            this.cbbCusA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCusA.Name = "cbbCusA";
            this.cbbCusA.Size = new System.Drawing.Size(283, 28);
            this.cbbCusA.TabIndex = 5;
            this.cbbCusA.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F);
            this.label14.Location = new System.Drawing.Point(354, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Chọn vật tư";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHome.Location = new System.Drawing.Point(200, 35);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(131, 16);
            this.labelHome.TabIndex = 52;
            this.labelHome.Text = "< Về màn hình chính";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(885, 22);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(130, 17);
            this.labelHello.TabIndex = 53;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(920, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "Đăng xuất";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(56, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(299, 26);
            this.label16.TabIndex = 61;
            this.label16.Text = "Thông tin đơn xuất và vật tư";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.sl,
            this.gia});
            this.dgv1.Location = new System.Drawing.Point(24, 389);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(386, 122);
            this.dgv1.TabIndex = 62;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "Id";
            this.ma.HeaderText = "Mã vật tư";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Width = 80;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "DisplayName";
            this.ten.HeaderText = "Tên vật tư";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Count";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 80;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "OutputPrice";
            this.gia.HeaderText = "Đơn giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(1100, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 64);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1017, 9);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(72, 68);
            this.avatar.TabIndex = 65;
            this.avatar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(24, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 47);
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 537);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelHello);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmExport.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmExport";
            this.Text = "Xuất hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExport_FormClosing);
            this.Load += new System.EventHandler(this.frmExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbCusB;
        private System.Windows.Forms.ComboBox cbbCusA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cbbIDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.ComboBox cbbIDB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.TextBox numberA;
        private System.Windows.Forms.TextBox numberB;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}