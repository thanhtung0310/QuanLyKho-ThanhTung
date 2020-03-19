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
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbContactNum = new System.Windows.Forms.TextBox();
            this.tbContractDate = new System.Windows.Forms.TextBox();
            this.tbAddInfo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelDisplayName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(491, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(163, 22);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.Appearance.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.buttonEdit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonEdit.Appearance.Options.UseBackColor = true;
            this.buttonEdit.Appearance.Options.UseBorderColor = true;
            this.buttonEdit.Appearance.Options.UseFont = true;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEdit.Location = new System.Drawing.Point(306, 453);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(131, 45);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Cập nhật";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplayName.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbDisplayName.ForeColor = System.Drawing.Color.Black;
            this.tbDisplayName.Location = new System.Drawing.Point(341, 164);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDisplayName.Size = new System.Drawing.Size(317, 26);
            this.tbDisplayName.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.Location = new System.Drawing.Point(341, 196);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddress.Size = new System.Drawing.Size(317, 53);
            this.tbAddress.TabIndex = 5;
            // 
            // tbContactNum
            // 
            this.tbContactNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContactNum.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbContactNum.ForeColor = System.Drawing.Color.Black;
            this.tbContactNum.Location = new System.Drawing.Point(341, 259);
            this.tbContactNum.Name = "tbContactNum";
            this.tbContactNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbContactNum.Size = new System.Drawing.Size(317, 26);
            this.tbContactNum.TabIndex = 6;
            // 
            // tbContractDate
            // 
            this.tbContractDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContractDate.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbContractDate.ForeColor = System.Drawing.Color.Black;
            this.tbContractDate.Location = new System.Drawing.Point(341, 390);
            this.tbContractDate.Name = "tbContractDate";
            this.tbContractDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbContractDate.Size = new System.Drawing.Size(317, 26);
            this.tbContractDate.TabIndex = 9;
            // 
            // tbAddInfo
            // 
            this.tbAddInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddInfo.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbAddInfo.ForeColor = System.Drawing.Color.Black;
            this.tbAddInfo.Location = new System.Drawing.Point(341, 329);
            this.tbAddInfo.Multiline = true;
            this.tbAddInfo.Name = "tbAddInfo";
            this.tbAddInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddInfo.Size = new System.Drawing.Size(317, 55);
            this.tbAddInfo.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Cambria", 13F);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(341, 294);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmail.Size = new System.Drawing.Size(317, 26);
            this.tbEmail.TabIndex = 7;
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.labelDisplayName.Location = new System.Drawing.Point(82, 164);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(139, 26);
            this.labelDisplayName.TabIndex = 10;
            this.labelDisplayName.Text = "Tên hiển thị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(82, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(82, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(82, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(82, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thông tin thêm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(82, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày bắt đầu sử dụng:";
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(174, 47);
            this.logo.TabIndex = 18;
            this.logo.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(660, 12);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(73, 68);
            this.avatar.TabIndex = 17;
            this.avatar.TabStop = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 524);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDisplayName);
            this.Controls.Add(this.tbContractDate);
            this.Controls.Add(this.tbAddInfo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbContactNum);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelHello);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCustomer.IconOptions.LargeImage")));
            this.Name = "frmCustomer";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private DevExpress.XtraEditors.SimpleButton buttonEdit;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbContactNum;
        private System.Windows.Forms.TextBox tbContractDate;
        private System.Windows.Forms.TextBox tbAddInfo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.PictureBox logo;
    }
}