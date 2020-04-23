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
            this.logo = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
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
            this.cbbObjA = new System.Windows.Forms.ComboBox();
            this.tbIDA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numberA = new System.Windows.Forms.NumericUpDown();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberB = new System.Windows.Forms.NumericUpDown();
            this.cbbObjB = new System.Windows.Forms.ComboBox();
            this.tbIDB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(174, 47);
            this.logo.TabIndex = 21;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1182, 12);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(73, 68);
            this.avatar.TabIndex = 20;
            this.avatar.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(1013, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(163, 22);
            this.labelHello.TabIndex = 19;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHome.Location = new System.Drawing.Point(192, 12);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(154, 20);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "< Về màn hình chính";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 43);
            this.label2.TabIndex = 36;
            this.label2.Text = "LẬP ĐƠN NHẬP HÀNG";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(21, 79);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(98, 32);
            this.labelID.TabIndex = 38;
            this.labelID.Text = "Vật tư:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "Số lượng: ";
            // 
            // tbInpPriceA
            // 
            this.tbInpPriceA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbInpPriceA.Location = new System.Drawing.Point(244, 184);
            this.tbInpPriceA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInpPriceA.Multiline = true;
            this.tbInpPriceA.Name = "tbInpPriceA";
            this.tbInpPriceA.Size = new System.Drawing.Size(329, 36);
            this.tbInpPriceA.TabIndex = 4;
            this.tbInpPriceA.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá nhập: ";
            // 
            // tbOutPriceA
            // 
            this.tbOutPriceA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbOutPriceA.Location = new System.Drawing.Point(244, 238);
            this.tbOutPriceA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOutPriceA.Multiline = true;
            this.tbOutPriceA.Name = "tbOutPriceA";
            this.tbOutPriceA.Size = new System.Drawing.Size(329, 36);
            this.tbOutPriceA.TabIndex = 5;
            this.tbOutPriceA.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Giá bán: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ngày khởi tạo:";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(204, 356);
            this.buttonA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(191, 48);
            this.buttonA.TabIndex = 7;
            this.buttonA.Text = "Thêm mới";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbObjA);
            this.groupBox1.Controls.Add(this.tbIDA);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numberA);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 422);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // cbbObjA
            // 
            this.cbbObjA.Font = new System.Drawing.Font("Cambria", 13F);
            this.cbbObjA.FormattingEnabled = true;
            this.cbbObjA.Location = new System.Drawing.Point(244, 79);
            this.cbbObjA.Name = "cbbObjA";
            this.cbbObjA.Size = new System.Drawing.Size(329, 34);
            this.cbbObjA.TabIndex = 2;
            this.cbbObjA.Text = "1";
            // 
            // tbIDA
            // 
            this.tbIDA.Font = new System.Drawing.Font("Cambria", 10F);
            this.tbIDA.Location = new System.Drawing.Point(504, 31);
            this.tbIDA.Name = "tbIDA";
            this.tbIDA.Size = new System.Drawing.Size(65, 27);
            this.tbIDA.TabIndex = 1;
            this.tbIDA.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F);
            this.label14.Location = new System.Drawing.Point(431, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Đơn số";
            // 
            // numberA
            // 
            this.numberA.Font = new System.Drawing.Font("Cambria", 14F);
            this.numberA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberA.Location = new System.Drawing.Point(244, 128);
            this.numberA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(325, 35);
            this.numberA.TabIndex = 3;
            // 
            // dateA
            // 
            this.dateA.Font = new System.Drawing.Font("Cambria", 14F);
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateA.Location = new System.Drawing.Point(244, 288);
            this.dateA.Name = "dateA";
            this.dateA.Size = new System.Drawing.Size(329, 35);
            this.dateA.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numberB);
            this.groupBox2.Controls.Add(this.cbbObjB);
            this.groupBox2.Controls.Add(this.tbIDB);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbOutPriceB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbInpPriceB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(641, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 422);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbStatus.Location = new System.Drawing.Point(244, 284);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(329, 36);
            this.tbStatus.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 32);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tình trạng: ";
            // 
            // numberB
            // 
            this.numberB.Font = new System.Drawing.Font("Cambria", 14F);
            this.numberB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberB.Location = new System.Drawing.Point(244, 130);
            this.numberB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberB.Name = "numberB";
            this.numberB.Size = new System.Drawing.Size(329, 35);
            this.numberB.TabIndex = 10;
            // 
            // cbbObjB
            // 
            this.cbbObjB.Font = new System.Drawing.Font("Cambria", 13F);
            this.cbbObjB.FormattingEnabled = true;
            this.cbbObjB.Location = new System.Drawing.Point(244, 81);
            this.cbbObjB.Name = "cbbObjB";
            this.cbbObjB.Size = new System.Drawing.Size(329, 34);
            this.cbbObjB.TabIndex = 9;
            this.cbbObjB.Text = "1";
            this.cbbObjB.TextChanged += new System.EventHandler(this.cbbObjB_TextChanged);
            // 
            // tbIDB
            // 
            this.tbIDB.Font = new System.Drawing.Font("Cambria", 10F);
            this.tbIDB.Location = new System.Drawing.Point(508, 31);
            this.tbIDB.Name = "tbIDB";
            this.tbIDB.Size = new System.Drawing.Size(65, 27);
            this.tbIDB.TabIndex = 8;
            this.tbIDB.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10F);
            this.label15.Location = new System.Drawing.Point(435, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Đơn số";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(69, 356);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 48);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(361, 356);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 48);
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
            this.label5.Location = new System.Drawing.Point(48, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 40);
            this.label5.TabIndex = 36;
            this.label5.Text = "CHỈNH SỬA VÀ XÓA ";
            // 
            // tbOutPriceB
            // 
            this.tbOutPriceB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbOutPriceB.Location = new System.Drawing.Point(244, 238);
            this.tbOutPriceB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOutPriceB.Multiline = true;
            this.tbOutPriceB.Name = "tbOutPriceB";
            this.tbOutPriceB.Size = new System.Drawing.Size(329, 36);
            this.tbOutPriceB.TabIndex = 12;
            this.tbOutPriceB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 44;
            this.label8.Text = "Giá bán: ";
            // 
            // tbInpPriceB
            // 
            this.tbInpPriceB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbInpPriceB.Location = new System.Drawing.Point(244, 184);
            this.tbInpPriceB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInpPriceB.Multiline = true;
            this.tbInpPriceB.Name = "tbInpPriceB";
            this.tbInpPriceB.Size = new System.Drawing.Size(329, 36);
            this.tbInpPriceB.TabIndex = 11;
            this.tbInpPriceB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 32);
            this.label9.TabIndex = 42;
            this.label9.Text = "Giá nhập: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(21, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 32);
            this.label10.TabIndex = 40;
            this.label10.Text = "Số lượng: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(21, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 32);
            this.label11.TabIndex = 38;
            this.label11.Text = "Vật tư:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(735, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(273, 32);
            this.label13.TabIndex = 51;
            this.label13.Text = "Danh sách đơn nhập:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(463, 564);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(774, 154);
            this.dgv.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1056, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 22);
            this.label12.TabIndex = 52;
            this.label12.Text = "Đăng xuất";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(119, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 32);
            this.label16.TabIndex = 53;
            this.label16.Text = "Danh sách vật tư:";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(75, 564);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(314, 154);
            this.dgv1.TabIndex = 16;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 736);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.labelHello);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmImport.IconOptions.SvgImage")));
            this.Name = "frmImport";
            this.Text = "Nhập hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImport_FormClosing);
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox avatar;
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
        private System.Windows.Forms.NumericUpDown numberA;
        private System.Windows.Forms.TextBox tbIDA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbObjA;
        private System.Windows.Forms.ComboBox cbbObjB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tbIDB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numberB;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label4;
    }
}