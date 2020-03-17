namespace QuanLyKho_TT
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.txbPasswordR = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new DevExpress.XtraEditors.SimpleButton();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonClose);
            this.groupBoxLogin.Controls.Add(this.txbPasswordR);
            this.groupBoxLogin.Controls.Add(this.buttonSignUp);
            this.groupBoxLogin.Controls.Add(this.txbPassword);
            this.groupBoxLogin.Controls.Add(this.txbUsername);
            this.groupBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(27, 2);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(497, 229);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.buttonClose.Appearance.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.buttonClose.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonClose.Appearance.Options.UseBackColor = true;
            this.buttonClose.Appearance.Options.UseBorderColor = true;
            this.buttonClose.Appearance.Options.UseFont = true;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Location = new System.Drawing.Point(264, 156);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(131, 45);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Thoát";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // txbPasswordR
            // 
            this.txbPasswordR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPasswordR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPasswordR.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPasswordR.Location = new System.Drawing.Point(51, 108);
            this.txbPasswordR.Name = "txbPasswordR";
            this.txbPasswordR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbPasswordR.Size = new System.Drawing.Size(391, 24);
            this.txbPasswordR.TabIndex = 2;
            this.txbPasswordR.Text = "Nhập lại mật khẩu";
            this.txbPasswordR.Click += new System.EventHandler(this.txbPasswordR_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSignUp.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.buttonSignUp.Appearance.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.buttonSignUp.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonSignUp.Appearance.Options.UseBackColor = true;
            this.buttonSignUp.Appearance.Options.UseBorderColor = true;
            this.buttonSignUp.Appearance.Options.UseFont = true;
            this.buttonSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSignUp.Location = new System.Drawing.Point(84, 156);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(131, 45);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Đăng ký";
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(51, 78);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbPassword.Size = new System.Drawing.Size(391, 24);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.Text = "Mật khẩu";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txbUsername.Location = new System.Drawing.Point(51, 48);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbUsername.Size = new System.Drawing.Size(391, 24);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.Text = "Tên đăng nhập";
            this.txbUsername.Click += new System.EventHandler(this.txbUsername_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 254);
            this.Controls.Add(this.groupBoxLogin);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmSignUp.IconOptions.LargeImage")));
            this.Name = "frmSignUp";
            this.Text = "Đăng ký";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private DevExpress.XtraEditors.SimpleButton buttonSignUp;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private System.Windows.Forms.TextBox txbPasswordR;
    }
}