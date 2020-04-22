namespace QuanLyKho_TT
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.checkButtonShow = new DevExpress.XtraEditors.CheckButton();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.buttonLogIn = new DevExpress.XtraEditors.SimpleButton();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLogin.Controls.Add(this.checkButtonShow);
            this.groupBoxLogin.Controls.Add(this.labelSignUp);
            this.groupBoxLogin.Controls.Add(this.buttonLogIn);
            this.groupBoxLogin.Controls.Add(this.txbPassword);
            this.groupBoxLogin.Controls.Add(this.txbUsername);
            this.groupBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(33, 1);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(517, 201);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            // 
            // checkButtonShow
            // 
            this.checkButtonShow.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.checkButtonShow.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkButtonShow.Appearance.Options.UseFont = true;
            this.checkButtonShow.Appearance.Options.UseForeColor = true;
            this.checkButtonShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkButtonShow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButtonShow.ImageOptions.Image")));
            this.checkButtonShow.Location = new System.Drawing.Point(448, 75);
            this.checkButtonShow.Name = "checkButtonShow";
            this.checkButtonShow.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.checkButtonShow.Size = new System.Drawing.Size(35, 32);
            this.checkButtonShow.TabIndex = 4;
            this.checkButtonShow.CheckedChanged += new System.EventHandler(this.checkButtonShow_CheckedChanged);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.labelSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSignUp.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Underline);
            this.labelSignUp.ForeColor = System.Drawing.Color.Red;
            this.labelSignUp.Location = new System.Drawing.Point(226, 142);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(241, 20);
            this.labelSignUp.TabIndex = 1;
            this.labelSignUp.Text = "Ấn vào đây để tạo tài khoản mới";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Appearance.BackColor = System.Drawing.Color.Purple;
            this.buttonLogIn.Appearance.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.buttonLogIn.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonLogIn.Appearance.Options.UseBackColor = true;
            this.buttonLogIn.Appearance.Options.UseBorderColor = true;
            this.buttonLogIn.Appearance.Options.UseFont = true;
            this.buttonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogIn.Location = new System.Drawing.Point(69, 126);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(131, 45);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Đăng nhập";
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(51, 83);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbPassword.Size = new System.Drawing.Size(391, 24);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.Text = "Mật khẩu";
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
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
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 227);
            this.Controls.Add(this.groupBoxLogin);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Đăng nhập";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelSignUp;
        private DevExpress.XtraEditors.SimpleButton buttonLogIn;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private DevExpress.XtraEditors.CheckButton checkButtonShow;
    }
}

