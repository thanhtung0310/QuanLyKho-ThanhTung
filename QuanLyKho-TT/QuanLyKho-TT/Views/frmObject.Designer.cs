﻿namespace QuanLyKho_TT.Views
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
            this.labelHome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logo = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.gBoxDelete.SuspendLayout();
            this.gboxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(109, 181);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 39);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.labelEdit.Location = new System.Drawing.Point(88, 16);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(346, 32);
            this.labelEdit.TabIndex = 21;
            this.labelEdit.Text = "CHỈNH SỬA VÀ XÓA VẬT TƯ";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(356, 181);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 39);
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
            this.gBoxDelete.Controls.Add(this.buttonEdit);
            this.gBoxDelete.Controls.Add(this.labelEdit);
            this.gBoxDelete.Controls.Add(this.buttonDelete);
            this.gBoxDelete.Location = new System.Drawing.Point(580, 80);
            this.gBoxDelete.Name = "gBoxDelete";
            this.gBoxDelete.Size = new System.Drawing.Size(595, 236);
            this.gBoxDelete.TabIndex = 39;
            this.gBoxDelete.TabStop = false;
            // 
            // cbbSupplierB
            // 
            this.cbbSupplierB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplierB.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbSupplierB.FormattingEnabled = true;
            this.cbbSupplierB.Location = new System.Drawing.Point(242, 133);
            this.cbbSupplierB.Name = "cbbSupplierB";
            this.cbbSupplierB.Size = new System.Drawing.Size(319, 30);
            this.cbbSupplierB.TabIndex = 8;
            // 
            // cbbUnitB
            // 
            this.cbbUnitB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnitB.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbUnitB.FormattingEnabled = true;
            this.cbbUnitB.Location = new System.Drawing.Point(242, 98);
            this.cbbUnitB.Name = "cbbUnitB";
            this.cbbUnitB.Size = new System.Drawing.Size(319, 30);
            this.cbbUnitB.TabIndex = 7;
            // 
            // tbNameB
            // 
            this.tbNameB.Font = new System.Drawing.Font("Cambria", 14F);
            this.tbNameB.Location = new System.Drawing.Point(242, 62);
            this.tbNameB.Multiline = true;
            this.tbNameB.Name = "tbNameB";
            this.tbNameB.Size = new System.Drawing.Size(319, 30);
            this.tbNameB.TabIndex = 5;
            this.tbNameB.Click += new System.EventHandler(this.tbNameB_Click);
            this.tbNameB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNameB_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đơn vị đo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhà cung cấp:";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(759, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 26);
            this.label13.TabIndex = 37;
            this.label13.Text = "Danh sách vật tư:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(20, 102);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(117, 26);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "Đơn vị đo:";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.labelAdd.Location = new System.Drawing.Point(129, 16);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(247, 32);
            this.labelAdd.TabIndex = 21;
            this.labelAdd.Text = "THÊM MỚI VẬT TƯ";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 18F);
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(181, 181);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(164, 39);
            this.buttonA.TabIndex = 4;
            this.buttonA.Text = "Thêm mới";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
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
            this.gboxAdd.Location = new System.Drawing.Point(19, 80);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Size = new System.Drawing.Size(543, 236);
            this.gboxAdd.TabIndex = 36;
            this.gboxAdd.TabStop = false;
            // 
            // cbbSupplierA
            // 
            this.cbbSupplierA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplierA.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbSupplierA.FormattingEnabled = true;
            this.cbbSupplierA.Location = new System.Drawing.Point(235, 133);
            this.cbbSupplierA.Name = "cbbSupplierA";
            this.cbbSupplierA.Size = new System.Drawing.Size(283, 30);
            this.cbbSupplierA.TabIndex = 3;
            // 
            // cbbUnitA
            // 
            this.cbbUnitA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUnitA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUnitA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnitA.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbUnitA.FormattingEnabled = true;
            this.cbbUnitA.Location = new System.Drawing.Point(235, 98);
            this.cbbUnitA.Name = "cbbUnitA";
            this.cbbUnitA.Size = new System.Drawing.Size(283, 30);
            this.cbbUnitA.TabIndex = 2;
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
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.labelHello.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHello.Location = new System.Drawing.Point(970, 22);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(130, 17);
            this.labelHello.TabIndex = 40;
            this.labelHello.Text = "Chào DisplayName,";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHome.Location = new System.Drawing.Point(185, 33);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(131, 16);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "< Về màn hình chính";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1002, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Đăng xuất";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(287, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 26);
            this.label5.TabIndex = 44;
            this.label5.Text = "Danh sách nhà cung cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(39, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Danh sách đơn vị đo:";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.ten1});
            this.dgv1.Location = new System.Drawing.Point(44, 370);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(226, 116);
            this.dgv1.TabIndex = 46;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "Id";
            this.id1.HeaderText = "Mã đơn vị đo";
            this.id1.MinimumWidth = 6;
            this.id1.Name = "id1";
            this.id1.Width = 65;
            // 
            // ten1
            // 
            this.ten1.DataPropertyName = "DisplayName";
            this.ten1.HeaderText = "Tên đơn vị đo";
            this.ten1.MinimumWidth = 6;
            this.ten1.Name = "ten1";
            this.ten1.Width = 125;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id3,
            this.ten3,
            this.id4,
            this.id5});
            this.dgv.Location = new System.Drawing.Point(666, 370);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(398, 116);
            this.dgv.TabIndex = 47;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // id3
            // 
            this.id3.DataPropertyName = "Id";
            this.id3.HeaderText = "Mã vật tư";
            this.id3.MinimumWidth = 6;
            this.id3.Name = "id3";
            this.id3.Width = 65;
            // 
            // ten3
            // 
            this.ten3.DataPropertyName = "DisplayName";
            this.ten3.HeaderText = "Tên vật tư";
            this.ten3.MinimumWidth = 6;
            this.ten3.Name = "ten3";
            this.ten3.Width = 125;
            // 
            // id4
            // 
            this.id4.DataPropertyName = "IdUnit";
            this.id4.HeaderText = "Mã đơn vị đo";
            this.id4.MinimumWidth = 6;
            this.id4.Name = "id4";
            this.id4.Width = 65;
            // 
            // id5
            // 
            this.id5.DataPropertyName = "IdSupplier";
            this.id5.HeaderText = "Mã nhà cung cấp";
            this.id5.MinimumWidth = 6;
            this.id5.Name = "id5";
            this.id5.Width = 125;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.ten2});
            this.dgv2.Location = new System.Drawing.Point(292, 370);
            this.dgv2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.Size = new System.Drawing.Size(259, 116);
            this.dgv2.TabIndex = 48;
            // 
            // id2
            // 
            this.id2.DataPropertyName = "Id";
            this.id2.HeaderText = "Mã nhà cung cấp";
            this.id2.MinimumWidth = 6;
            this.id2.Name = "id2";
            this.id2.Width = 65;
            // 
            // ten2
            // 
            this.ten2.DataPropertyName = "DisplayName";
            this.ten2.HeaderText = "Tên nhà cung cấp";
            this.ten2.MinimumWidth = 6;
            this.ten2.Name = "ten2";
            this.ten2.Width = 125;
            // 
            // logo
            // 
            this.logo.Image = global::QuanLyKho_TT.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 18);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(171, 47);
            this.logo.TabIndex = 56;
            this.logo.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::QuanLyKho_TT.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(1102, 7);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(72, 68);
            this.avatar.TabIndex = 57;
            this.avatar.TabStop = false;
            // 
            // frmObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 508);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.gBoxDelete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gboxAdd);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmObject.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmObject";
            this.Text = "Vật tư";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmObject_FormClosing);
            this.Load += new System.EventHandler(this.frmObject_Load);
            this.gBoxDelete.ResumeLayout(false);
            this.gBoxDelete.PerformLayout();
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox avatar;
    }
}