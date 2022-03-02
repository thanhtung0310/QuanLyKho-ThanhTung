namespace QuanLyKho_TT.Views
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            this.labelHome = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.tbNameA = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gboxAdd = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNameB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.gboxAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHome.Location = new System.Drawing.Point(185, 26);
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
            this.labelHello.Location = new System.Drawing.Point(924, 18);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(130, 17);
            this.labelHello.TabIndex = 48;
            this.labelHello.Text = "Chào DisplayName,";
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
            this.labelAdd.Location = new System.Drawing.Point(117, 16);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(289, 32);
            this.labelAdd.TabIndex = 21;
            this.labelAdd.Text = "THÊM MỚI ĐƠN VỊ ĐO";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(174, 102);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(164, 39);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm mới";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên hiển thị: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(462, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 26);
            this.label13.TabIndex = 45;
            this.label13.Text = "Danh sách đơn vị đo:";
            // 
            // gboxAdd
            // 
            this.gboxAdd.BackColor = System.Drawing.Color.White;
            this.gboxAdd.Controls.Add(this.tbNameA);
            this.gboxAdd.Controls.Add(this.labelAdd);
            this.gboxAdd.Controls.Add(this.buttonAdd);
            this.gboxAdd.Controls.Add(this.label6);
            this.gboxAdd.Location = new System.Drawing.Point(19, 80);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Size = new System.Drawing.Size(543, 158);
            this.gboxAdd.TabIndex = 44;
            this.gboxAdd.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tbNameB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Location = new System.Drawing.Point(572, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 158);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // tbNameB
            // 
            this.tbNameB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbNameB.Location = new System.Drawing.Point(235, 62);
            this.tbNameB.Multiline = true;
            this.tbNameB.Name = "tbNameB";
            this.tbNameB.Size = new System.Drawing.Size(283, 30);
            this.tbNameB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(172, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "XÓA ĐƠN VỊ ĐO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên hiển thị: ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(213, 102);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 39);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ten});
            this.dgv.Location = new System.Drawing.Point(446, 279);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(258, 143);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã đơn vị đo";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 65;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "DisplayName";
            this.ten.HeaderText = "Tên đơn vị đo";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(954, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Đăng xuất";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(171, 47);
            this.logo.TabIndex = 54;
            this.logo.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1057, 0);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(72, 68);
            this.avatar.TabIndex = 55;
            this.avatar.TabStop = false;
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 443);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gboxAdd);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmUnit.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUnit";
            this.Text = "Đơn vị đo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnit_FormClosing);
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.TextBox tbNameA;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gboxAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNameB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox avatar;
    }
}