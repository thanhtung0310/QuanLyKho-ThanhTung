namespace QuanLyKho_TT.Views
{
    partial class frmObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObject));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelEdit = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.gBoxDelete = new System.Windows.Forms.GroupBox();
            this.cbbSupplierB = new System.Windows.Forms.ComboBox();
            this.cbbUnitB = new System.Windows.Forms.ComboBox();
            this.tbNameB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gboxAdd = new System.Windows.Forms.GroupBox();
            this.cbbSupplierA = new System.Windows.Forms.ComboBox();
            this.cbbUnitA = new System.Windows.Forms.ComboBox();
            this.tbNameA = new System.Windows.Forms.TextBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.gBoxDelete.SuspendLayout();
            this.gboxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Yellow;
            this.buttonSearch.Font = new System.Drawing.Font("Cambria", 10F);
            this.buttonSearch.Location = new System.Drawing.Point(621, 82);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(57, 29);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Tìm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(127, 223);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 48);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.labelEdit.Location = new System.Drawing.Point(103, 20);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(436, 40);
            this.labelEdit.TabIndex = 21;
            this.labelEdit.Text = "CHỈNH SỬA VÀ XÓA VẬT TƯ";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(415, 223);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 48);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // gBoxDelete
            // 
            this.gBoxDelete.BackColor = System.Drawing.Color.White;
            this.gBoxDelete.Controls.Add(this.cbbSupplierB);
            this.gBoxDelete.Controls.Add(this.cbbUnitB);
            this.gBoxDelete.Controls.Add(this.tbNameB);
            this.gBoxDelete.Controls.Add(this.label2);
            this.gBoxDelete.Controls.Add(this.label3);
            this.gBoxDelete.Controls.Add(this.label4);
            this.gBoxDelete.Controls.Add(this.buttonSearch);
            this.gBoxDelete.Controls.Add(this.buttonEdit);
            this.gBoxDelete.Controls.Add(this.labelEdit);
            this.gBoxDelete.Controls.Add(this.buttonDelete);
            this.gBoxDelete.Location = new System.Drawing.Point(677, 98);
            this.gBoxDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBoxDelete.Name = "gBoxDelete";
            this.gBoxDelete.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBoxDelete.Size = new System.Drawing.Size(694, 290);
            this.gBoxDelete.TabIndex = 39;
            this.gBoxDelete.TabStop = false;
            // 
            // cbbSupplierB
            // 
            this.cbbSupplierB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplierB.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbSupplierB.FormattingEnabled = true;
            this.cbbSupplierB.Location = new System.Drawing.Point(282, 164);
            this.cbbSupplierB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSupplierB.Name = "cbbSupplierB";
            this.cbbSupplierB.Size = new System.Drawing.Size(329, 35);
            this.cbbSupplierB.TabIndex = 8;
            // 
            // cbbUnitB
            // 
            this.cbbUnitB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnitB.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbUnitB.FormattingEnabled = true;
            this.cbbUnitB.Location = new System.Drawing.Point(282, 120);
            this.cbbUnitB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbUnitB.Name = "cbbUnitB";
            this.cbbUnitB.Size = new System.Drawing.Size(329, 35);
            this.cbbUnitB.TabIndex = 7;
            // 
            // tbNameB
            // 
            this.tbNameB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbNameB.Location = new System.Drawing.Point(282, 76);
            this.tbNameB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNameB.Multiline = true;
            this.tbNameB.Name = "tbNameB";
            this.tbNameB.Size = new System.Drawing.Size(329, 36);
            this.tbNameB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đơn vị đo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên hiển thị: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(886, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 32);
            this.label13.TabIndex = 37;
            this.label13.Text = "Danh sách vật tư:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(23, 125);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(141, 32);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "Đơn vị đo:";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.labelAdd.Location = new System.Drawing.Point(151, 20);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(312, 40);
            this.labelAdd.TabIndex = 21;
            this.labelAdd.Text = "THÊM MỚI VẬT TƯ";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(211, 223);
            this.buttonA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(191, 48);
            this.buttonA.TabIndex = 4;
            this.buttonA.Text = "Thêm mới";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên hiển thị: ";
            // 
            // gboxAdd
            // 
            this.gboxAdd.BackColor = System.Drawing.Color.White;
            this.gboxAdd.Controls.Add(this.cbbSupplierA);
            this.gboxAdd.Controls.Add(this.cbbUnitA);
            this.gboxAdd.Controls.Add(this.tbNameA);
            this.gboxAdd.Controls.Add(this.labelID);
            this.gboxAdd.Controls.Add(this.labelAdd);
            this.gboxAdd.Controls.Add(this.label1);
            this.gboxAdd.Controls.Add(this.buttonA);
            this.gboxAdd.Controls.Add(this.label6);
            this.gboxAdd.Location = new System.Drawing.Point(22, 98);
            this.gboxAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxAdd.Size = new System.Drawing.Size(634, 290);
            this.gboxAdd.TabIndex = 36;
            this.gboxAdd.TabStop = false;
            // 
            // cbbSupplierA
            // 
            this.cbbSupplierA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplierA.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbSupplierA.FormattingEnabled = true;
            this.cbbSupplierA.Location = new System.Drawing.Point(274, 164);
            this.cbbSupplierA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSupplierA.Name = "cbbSupplierA";
            this.cbbSupplierA.Size = new System.Drawing.Size(329, 35);
            this.cbbSupplierA.TabIndex = 3;
            // 
            // cbbUnitA
            // 
            this.cbbUnitA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUnitA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUnitA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnitA.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbUnitA.FormattingEnabled = true;
            this.cbbUnitA.Location = new System.Drawing.Point(274, 120);
            this.cbbUnitA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbUnitA.Name = "cbbUnitA";
            this.cbbUnitA.Size = new System.Drawing.Size(329, 35);
            this.cbbUnitA.TabIndex = 2;
            // 
            // tbNameA
            // 
            this.tbNameA.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbNameA.Location = new System.Drawing.Point(274, 76);
            this.tbNameA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNameA.Multiline = true;
            this.tbNameA.Name = "tbNameA";
            this.tbNameA.Size = new System.Drawing.Size(329, 36);
            this.tbNameA.TabIndex = 1;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(1138, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(163, 22);
            this.labelHello.TabIndex = 40;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(174, 47);
            this.logo.TabIndex = 42;
            this.logo.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1307, 12);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(73, 68);
            this.avatar.TabIndex = 41;
            this.avatar.TabStop = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1175, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Đăng xuất";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(335, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "Danh sách nhà cung cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(45, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "Danh sách đơn vị đo:";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(51, 455);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(264, 143);
            this.dgv1.TabIndex = 46;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(777, 455);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(464, 143);
            this.dgv.TabIndex = 47;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(341, 455);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.Size = new System.Drawing.Size(302, 143);
            this.dgv2.TabIndex = 48;
            // 
            // frmObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 625);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.gBoxDelete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gboxAdd);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmObject.IconOptions.LargeImage")));
            this.Name = "frmObject";
            this.Text = "Vật tư";
            this.Load += new System.EventHandler(this.frmObject_Load);
            this.gBoxDelete.ResumeLayout(false);
            this.gBoxDelete.PerformLayout();
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox gBoxDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gboxAdd;
        private System.Windows.Forms.TextBox tbNameA;
        private System.Windows.Forms.ComboBox cbbSupplierA;
        private System.Windows.Forms.ComboBox cbbUnitA;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.ComboBox cbbSupplierB;
        private System.Windows.Forms.ComboBox cbbUnitB;
        private System.Windows.Forms.TextBox tbNameB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgv2;
    }
}