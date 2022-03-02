namespace QuanLyKho_TT.Views
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ainfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxAdd = new System.Windows.Forms.GroupBox();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.tbInfoA = new System.Windows.Forms.TextBox();
            this.tbEmailA = new System.Windows.Forms.TextBox();
            this.tbPhoneA = new System.Windows.Forms.TextBox();
            this.tbAddressA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNameA = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.gBoxDelete = new System.Windows.Forms.GroupBox();
            this.dateB = new System.Windows.Forms.DateTimePicker();
            this.tbInfoB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmailB = new System.Windows.Forms.TextBox();
            this.tbPhoneB = new System.Windows.Forms.TextBox();
            this.tbAddressB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNameB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelEdit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gboxAdd.SuspendLayout();
            this.gBoxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(339, 381);
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
            this.label13.Location = new System.Drawing.Point(497, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 26);
            this.label13.TabIndex = 54;
            this.label13.Text = "Danh sách khách hàng:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(20, 102);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(88, 26);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "Địa chỉ:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.dc,
            this.sdt,
            this.email,
            this.ainfo,
            this.date});
            this.dgv.Location = new System.Drawing.Point(300, 549);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(621, 125);
            this.dgv.TabIndex = 52;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCustomer_CellFormatting);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "Id";
            this.ma.HeaderText = "Mã khách hàng";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            this.ma.Width = 65;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "DisplayName";
            this.ten.HeaderText = "Tên khách hàng";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 110;
            // 
            // dc
            // 
            this.dc.DataPropertyName = "Address";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.MinimumWidth = 6;
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            this.dc.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "ContactNum";
            this.sdt.HeaderText = "SĐT liên hệ";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // ainfo
            // 
            this.ainfo.DataPropertyName = "AddInfo";
            this.ainfo.HeaderText = "Thông tin khác";
            this.ainfo.MinimumWidth = 6;
            this.ainfo.Name = "ainfo";
            this.ainfo.ReadOnly = true;
            this.ainfo.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "ContractDate";
            this.date.HeaderText = "Ngày bắt đầu mua hàng";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 90;
            // 
            // gboxAdd
            // 
            this.gboxAdd.BackColor = System.Drawing.Color.White;
            this.gboxAdd.Controls.Add(this.dateA);
            this.gboxAdd.Controls.Add(this.tbInfoA);
            this.gboxAdd.Controls.Add(this.tbEmailA);
            this.gboxAdd.Controls.Add(this.tbPhoneA);
            this.gboxAdd.Controls.Add(this.tbAddressA);
            this.gboxAdd.Controls.Add(this.label5);
            this.gboxAdd.Controls.Add(this.label7);
            this.gboxAdd.Controls.Add(this.label8);
            this.gboxAdd.Controls.Add(this.tbNameA);
            this.gboxAdd.Controls.Add(this.labelID);
            this.gboxAdd.Controls.Add(this.labelAdd);
            this.gboxAdd.Controls.Add(this.label1);
            this.gboxAdd.Controls.Add(this.buttonA);
            this.gboxAdd.Controls.Add(this.label6);
            this.gboxAdd.Location = new System.Drawing.Point(19, 83);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Size = new System.Drawing.Size(543, 435);
            this.gboxAdd.TabIndex = 53;
            this.gboxAdd.TabStop = false;
            // 
            // dateA
            // 
            this.dateA.Font = new System.Drawing.Font("Cambria", 14F);
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateA.Location = new System.Drawing.Point(235, 339);
            this.dateA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateA.Name = "dateA";
            this.dateA.Size = new System.Drawing.Size(283, 29);
            this.dateA.TabIndex = 27;
            // 
            // tbInfoA
            // 
            this.tbInfoA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbInfoA.Location = new System.Drawing.Point(235, 265);
            this.tbInfoA.Multiline = true;
            this.tbInfoA.Name = "tbInfoA";
            this.tbInfoA.Size = new System.Drawing.Size(283, 60);
            this.tbInfoA.TabIndex = 5;
            // 
            // tbEmailA
            // 
            this.tbEmailA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbEmailA.Location = new System.Drawing.Point(235, 219);
            this.tbEmailA.Multiline = true;
            this.tbEmailA.Name = "tbEmailA";
            this.tbEmailA.Size = new System.Drawing.Size(283, 30);
            this.tbEmailA.TabIndex = 4;
            // 
            // tbPhoneA
            // 
            this.tbPhoneA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbPhoneA.Location = new System.Drawing.Point(235, 177);
            this.tbPhoneA.Multiline = true;
            this.tbPhoneA.Name = "tbPhoneA";
            this.tbPhoneA.Size = new System.Drawing.Size(283, 30);
            this.tbPhoneA.TabIndex = 3;
            // 
            // tbAddressA
            // 
            this.tbAddressA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbAddressA.Location = new System.Drawing.Point(235, 102);
            this.tbAddressA.Multiline = true;
            this.tbAddressA.Name = "tbAddressA";
            this.tbAddressA.Size = new System.Drawing.Size(283, 60);
            this.tbAddressA.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Thông tin khác:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày khởi tạo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email: ";
            // 
            // tbNameA
            // 
            this.tbNameA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbNameA.Location = new System.Drawing.Point(235, 62);
            this.tbNameA.Multiline = true;
            this.tbNameA.Name = "tbNameA";
            this.tbNameA.Size = new System.Drawing.Size(283, 30);
            this.tbNameA.TabIndex = 1;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.labelAdd.Location = new System.Drawing.Point(104, 16);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(321, 32);
            this.labelAdd.TabIndex = 21;
            this.labelAdd.Text = "THÊM MỚI KHÁCH HÀNG";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số điện thoại:";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(183, 381);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(164, 39);
            this.buttonA.TabIndex = 7;
            this.buttonA.Text = "Thêm mới";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên hiển thị: ";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHome.Location = new System.Drawing.Point(192, 36);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(131, 16);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "< Về màn hình chính";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(964, 21);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(130, 17);
            this.labelHello.TabIndex = 56;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // gBoxDelete
            // 
            this.gBoxDelete.BackColor = System.Drawing.Color.White;
            this.gBoxDelete.Controls.Add(this.dateB);
            this.gBoxDelete.Controls.Add(this.tbInfoB);
            this.gBoxDelete.Controls.Add(this.label12);
            this.gBoxDelete.Controls.Add(this.tbEmailB);
            this.gBoxDelete.Controls.Add(this.tbPhoneB);
            this.gBoxDelete.Controls.Add(this.tbAddressB);
            this.gBoxDelete.Controls.Add(this.label2);
            this.gBoxDelete.Controls.Add(this.label3);
            this.gBoxDelete.Controls.Add(this.label9);
            this.gBoxDelete.Controls.Add(this.label10);
            this.gBoxDelete.Controls.Add(this.tbNameB);
            this.gBoxDelete.Controls.Add(this.label4);
            this.gBoxDelete.Controls.Add(this.buttonEdit);
            this.gBoxDelete.Controls.Add(this.labelEdit);
            this.gBoxDelete.Controls.Add(this.buttonDelete);
            this.gBoxDelete.Location = new System.Drawing.Point(580, 83);
            this.gBoxDelete.Name = "gBoxDelete";
            this.gBoxDelete.Size = new System.Drawing.Size(565, 435);
            this.gBoxDelete.TabIndex = 55;
            this.gBoxDelete.TabStop = false;
            // 
            // dateB
            // 
            this.dateB.Font = new System.Drawing.Font("Cambria", 14F);
            this.dateB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateB.Location = new System.Drawing.Point(242, 339);
            this.dateB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateB.Name = "dateB";
            this.dateB.Size = new System.Drawing.Size(283, 29);
            this.dateB.TabIndex = 29;
            // 
            // tbInfoB
            // 
            this.tbInfoB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbInfoB.Location = new System.Drawing.Point(242, 265);
            this.tbInfoB.Multiline = true;
            this.tbInfoB.Name = "tbInfoB";
            this.tbInfoB.Size = new System.Drawing.Size(283, 60);
            this.tbInfoB.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(27, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 26);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ngày khởi tạo:";
            // 
            // tbEmailB
            // 
            this.tbEmailB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbEmailB.Location = new System.Drawing.Point(242, 219);
            this.tbEmailB.Multiline = true;
            this.tbEmailB.Name = "tbEmailB";
            this.tbEmailB.Size = new System.Drawing.Size(283, 30);
            this.tbEmailB.TabIndex = 12;
            // 
            // tbPhoneB
            // 
            this.tbPhoneB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbPhoneB.Location = new System.Drawing.Point(242, 177);
            this.tbPhoneB.Multiline = true;
            this.tbPhoneB.Name = "tbPhoneB";
            this.tbPhoneB.Size = new System.Drawing.Size(283, 30);
            this.tbPhoneB.TabIndex = 11;
            // 
            // tbAddressB
            // 
            this.tbAddressB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbAddressB.Location = new System.Drawing.Point(242, 102);
            this.tbAddressB.Multiline = true;
            this.tbAddressB.Name = "tbAddressB";
            this.tbAddressB.Size = new System.Drawing.Size(283, 60);
            this.tbAddressB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Thông tin khác:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(27, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Địa chỉ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(27, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 26);
            this.label10.TabIndex = 31;
            this.label10.Text = "Số điện thoại:";
            // 
            // tbNameB
            // 
            this.tbNameB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbNameB.Location = new System.Drawing.Point(242, 62);
            this.tbNameB.Multiline = true;
            this.tbNameB.Name = "tbNameB";
            this.tbNameB.Size = new System.Drawing.Size(283, 30);
            this.tbNameB.TabIndex = 8;
            this.tbNameB.Click += new System.EventHandler(this.tbNameB_Click);
            this.tbNameB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNameB_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên hiển thị: ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(109, 381);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 39);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.labelEdit.Location = new System.Drawing.Point(50, 16);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(420, 32);
            this.labelEdit.TabIndex = 21;
            this.labelEdit.Text = "CHỈNH SỬA VÀ XÓA KHÁCH HÀNG";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(996, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Đăng xuất";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(19, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 47);
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1096, 10);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(72, 68);
            this.avatar.TabIndex = 67;
            this.avatar.TabStop = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 688);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gboxAdd);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.gBoxDelete);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCustomer.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCustomer";
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            this.gBoxDelete.ResumeLayout(false);
            this.gBoxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gboxAdd;
        private System.Windows.Forms.TextBox tbInfoA;
        private System.Windows.Forms.TextBox tbEmailA;
        private System.Windows.Forms.TextBox tbPhoneA;
        private System.Windows.Forms.TextBox tbAddressA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNameA;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.GroupBox gBoxDelete;
        private System.Windows.Forms.TextBox tbInfoB;
        private System.Windows.Forms.TextBox tbEmailB;
        private System.Windows.Forms.TextBox tbPhoneB;
        private System.Windows.Forms.TextBox tbAddressB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNameB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.DateTimePicker dateB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ainfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox avatar;
    }
}