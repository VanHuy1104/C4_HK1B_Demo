namespace QuanLiSinhVien
{
    partial class FrmQuanLySinhVien
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
            this.dgbDanhSachSV = new System.Windows.Forms.DataGridView();
            this.clomaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clohoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clogioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clodiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clokhoavien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKhoaVien = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.slNam = new System.Windows.Forms.TextBox();
            this.slNu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDanhSachSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbDanhSachSV
            // 
            this.dgbDanhSachSV.AllowUserToAddRows = false;
            this.dgbDanhSachSV.AllowUserToDeleteRows = false;
            this.dgbDanhSachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDanhSachSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clomaso,
            this.clohoten,
            this.clogioitinh,
            this.clodiem,
            this.clokhoavien});
            this.dgbDanhSachSV.Location = new System.Drawing.Point(338, 70);
            this.dgbDanhSachSV.Name = "dgbDanhSachSV";
            this.dgbDanhSachSV.ReadOnly = true;
            this.dgbDanhSachSV.Size = new System.Drawing.Size(570, 278);
            this.dgbDanhSachSV.TabIndex = 1;
            // 
            // clomaso
            // 
            this.clomaso.HeaderText = "Mã số";
            this.clomaso.Name = "clomaso";
            this.clomaso.ReadOnly = true;
            // 
            // clohoten
            // 
            this.clohoten.HeaderText = "Họ Tên";
            this.clohoten.Name = "clohoten";
            this.clohoten.ReadOnly = true;
            // 
            // clogioitinh
            // 
            this.clogioitinh.HeaderText = "Giới tính";
            this.clogioitinh.Name = "clogioitinh";
            this.clogioitinh.ReadOnly = true;
            // 
            // clodiem
            // 
            this.clodiem.HeaderText = "Điểm";
            this.clodiem.Name = "clodiem";
            this.clodiem.ReadOnly = true;
            // 
            // clokhoavien
            // 
            this.clokhoavien.HeaderText = "Khoa|Viện";
            this.clokhoavien.Name = "clokhoavien";
            this.clokhoavien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÍ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbKhoaVien);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaSo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // cmbKhoaVien
            // 
            this.cmbKhoaVien.FormattingEnabled = true;
            this.cmbKhoaVien.Location = new System.Drawing.Point(87, 249);
            this.cmbKhoaVien.Name = "cmbKhoaVien";
            this.cmbKhoaVien.Size = new System.Drawing.Size(174, 21);
            this.cmbKhoaVien.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(198, 133);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 6;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(76, 133);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 6;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(87, 191);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(174, 20);
            this.txtDiem.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(87, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(174, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Khoa/Viện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điểm";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(87, 32);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(174, 20);
            this.txtMaSo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(699, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nữ";
            // 
            // slNam
            // 
            this.slNam.Location = new System.Drawing.Point(527, 366);
            this.slNam.Name = "slNam";
            this.slNam.Size = new System.Drawing.Size(133, 20);
            this.slNam.TabIndex = 5;
            // 
            // slNu
            // 
            this.slNu.Location = new System.Drawing.Point(726, 367);
            this.slNu.Name = "slNu";
            this.slNu.Size = new System.Drawing.Size(133, 20);
            this.slNu.TabIndex = 5;
            // 
            // FrmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbDanhSachSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.slNu);
            this.Controls.Add(this.slNam);
            this.Controls.Add(this.label9);
            this.Name = "FrmQuanLySinhVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Load_Khoa);
            ((System.ComponentModel.ISupportInitialize)(this.dgbDanhSachSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgbDanhSachSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clomaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clohoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clogioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clodiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clokhoavien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox slNam;
        private System.Windows.Forms.TextBox slNu;
        private System.Windows.Forms.ComboBox cmbKhoaVien;
    }
}

