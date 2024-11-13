namespace QLCHBCAFE
{
    partial class frm_quanlysanpham
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
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_np = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.txtslnhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dssp = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.grb_ttsp = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssp)).BeginInit();
            this.grb_ttsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mancc";
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dt_np
            // 
            this.dt_np.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_np.Location = new System.Drawing.Point(461, 101);
            this.dt_np.Name = "dt_np";
            this.dt_np.Size = new System.Drawing.Size(156, 21);
            this.dt_np.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày nhập";
            // 
            // cbbncc
            // 
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(12, 100);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(156, 23);
            this.cbbncc.TabIndex = 9;
            // 
            // txtslnhap
            // 
            this.txtslnhap.Location = new System.Drawing.Point(239, 101);
            this.txtslnhap.Name = "txtslnhap";
            this.txtslnhap.Size = new System.Drawing.Size(156, 21);
            this.txtslnhap.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "slnhap";
            this.Column2.HeaderText = "Số lượng nhập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Blue;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(621, 415);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(89, 32);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "vnđ";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(461, 46);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(156, 21);
            this.txt_dongia.TabIndex = 2;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(12, 46);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(156, 21);
            this.txt_masp.TabIndex = 0;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(439, 166);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(78, 32);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(239, 46);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(156, 21);
            this.txt_tensp.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(633, 166);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(78, 32);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dssp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(56, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 216);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgv_dssp
            // 
            this.dgv_dssp.AllowUserToAddRows = false;
            this.dgv_dssp.AllowUserToDeleteRows = false;
            this.dgv_dssp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.dongia,
            this.Column1,
            this.Column2});
            this.dgv_dssp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dssp.Location = new System.Drawing.Point(3, 23);
            this.dgv_dssp.Name = "dgv_dssp";
            this.dgv_dssp.ReadOnly = true;
            this.dgv_dssp.Size = new System.Drawing.Size(648, 190);
            this.dgv_dssp.TabIndex = 0;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(538, 166);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(78, 32);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // grb_ttsp
            // 
            this.grb_ttsp.Controls.Add(this.dt_np);
            this.grb_ttsp.Controls.Add(this.label5);
            this.grb_ttsp.Controls.Add(this.cbbncc);
            this.grb_ttsp.Controls.Add(this.txtslnhap);
            this.grb_ttsp.Controls.Add(this.label6);
            this.grb_ttsp.Controls.Add(this.label7);
            this.grb_ttsp.Controls.Add(this.label4);
            this.grb_ttsp.Controls.Add(this.txt_dongia);
            this.grb_ttsp.Controls.Add(this.txt_tensp);
            this.grb_ttsp.Controls.Add(this.txt_masp);
            this.grb_ttsp.Controls.Add(this.label3);
            this.grb_ttsp.Controls.Add(this.label2);
            this.grb_ttsp.Controls.Add(this.label1);
            this.grb_ttsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ttsp.Location = new System.Drawing.Point(56, 12);
            this.grb_ttsp.Name = "grb_ttsp";
            this.grb_ttsp.Size = new System.Drawing.Size(654, 148);
            this.grb_ttsp.TabIndex = 10;
            this.grb_ttsp.TabStop = false;
            this.grb_ttsp.Text = "Thông tin sản phẩm";
            // 
            // frm_quanlysanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.grb_ttsp);
            this.Name = "frm_quanlysanpham";
            this.Text = "frm_quanlysanpham";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssp)).EndInit();
            this.grb_ttsp.ResumeLayout(false);
            this.grb_ttsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dt_np;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.TextBox txtslnhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dssp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.GroupBox grb_ttsp;
    }
}