namespace QuanLyKho_TT
{
    partial class frmMain
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.buttonImport = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonUser = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonCustomer = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonSupplier = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonUnit = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonObject = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.buttonExport = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelStore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Nhập", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonImport.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonImport.Location = new System.Drawing.Point(10, 84);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(59, 58);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Người dùng", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonUser.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonUser.Location = new System.Drawing.Point(435, 84);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(70, 58);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "windowsUIButtonPanel2";
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Khách hàng", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonCustomer.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonCustomer.Location = new System.Drawing.Point(357, 84);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(73, 58);
            this.buttonCustomer.TabIndex = 1;
            this.buttonCustomer.Text = "windowsUIButtonPanel3";
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Nhà cung cấp", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonSupplier.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonSupplier.Location = new System.Drawing.Point(269, 84);
            this.buttonSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(82, 58);
            this.buttonSupplier.TabIndex = 1;
            this.buttonSupplier.Text = "windowsUIButtonPanel4";
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonUnit
            // 
            this.buttonUnit.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đơn vị đo", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonUnit.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonUnit.Location = new System.Drawing.Point(203, 84);
            this.buttonUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnit.Name = "buttonUnit";
            this.buttonUnit.Size = new System.Drawing.Size(61, 58);
            this.buttonUnit.TabIndex = 1;
            this.buttonUnit.Text = "windowsUIButtonPanel5";
            this.buttonUnit.Click += new System.EventHandler(this.buttonUnit_Click);
            // 
            // buttonObject
            // 
            this.buttonObject.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Vật tư", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonObject.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonObject.Location = new System.Drawing.Point(139, 84);
            this.buttonObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonObject.Name = "buttonObject";
            this.buttonObject.Size = new System.Drawing.Size(59, 58);
            this.buttonObject.TabIndex = 1;
            this.buttonObject.Text = "windowsUIButtonPanel6";
            this.buttonObject.Click += new System.EventHandler(this.buttonObject_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xuất", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.buttonExport.Font = new System.Drawing.Font("Cambria", 7.8F);
            this.buttonExport.Location = new System.Drawing.Point(75, 84);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(59, 58);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelIn);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(33, 169);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(130, 115);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelIn
            // 
            this.labelIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Cambria", 14F);
            this.labelIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelIn.Location = new System.Drawing.Point(33, 65);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(65, 22);
            this.labelIn.TabIndex = 1;
            this.labelIn.Text = "99998";
            this.labelIn.Click += new System.EventHandler(this.labelIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F);
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lượng nhập";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelOut);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Location = new System.Drawing.Point(209, 169);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(124, 115);
            this.groupControl2.TabIndex = 3;
            // 
            // labelOut
            // 
            this.labelOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Cambria", 14F);
            this.labelOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelOut.Location = new System.Drawing.Point(35, 65);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(65, 22);
            this.labelOut.TabIndex = 2;
            this.labelOut.Text = "88887";
            this.labelOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F);
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lượng xuất";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelStore);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Location = new System.Drawing.Point(372, 169);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(110, 115);
            this.groupControl3.TabIndex = 4;
            // 
            // labelStore
            // 
            this.labelStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Cambria", 14F);
            this.labelStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelStore.Location = new System.Drawing.Point(30, 65);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(65, 22);
            this.labelStore.TabIndex = 3;
            this.labelStore.Text = "77776";
            this.labelStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F);
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tồn kho";
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(10, 5);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(167, 48);
            this.logo.TabIndex = 21;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(437, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(301, 10);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(130, 17);
            this.labelHello.TabIndex = 19;
            this.labelHello.Text = "Chào DisplayName,";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(334, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Đăng xuất";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.nhap,
            this.xuat});
            this.dgv.Location = new System.Drawing.Point(125, 306);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(304, 122);
            this.dgv.TabIndex = 29;
            // 
            // name
            // 
            this.name.DataPropertyName = "DisplayName";
            this.name.HeaderText = "Tên vật tư";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 90;
            // 
            // nhap
            // 
            this.nhap.DataPropertyName = "LuongNhap";
            this.nhap.HeaderText = "Lượng nhập";
            this.nhap.MinimumWidth = 6;
            this.nhap.Name = "nhap";
            this.nhap.Width = 125;
            // 
            // xuat
            // 
            this.xuat.DataPropertyName = "LuongXuat";
            this.xuat.HeaderText = "Lượng xuất";
            this.xuat.MinimumWidth = 6;
            this.xuat.Name = "xuat";
            this.xuat.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 451);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonSupplier);
            this.Controls.Add(this.buttonUnit);
            this.Controls.Add(this.buttonObject);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonImport);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonImport;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonUser;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonCustomer;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonSupplier;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonUnit;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonObject;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonExport;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuat;
    }
}