namespace QuanCaPhe
{
    partial class frm_nhanvien
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
            this.grb_ttnd = new System.Windows.Forms.GroupBox();
            this.pnl_ttnd = new System.Windows.Forms.Panel();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tnv = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsnd = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dt_ns = new System.Windows.Forms.DateTimePicker();
            this.grb_ttnd.SuspendLayout();
            this.pnl_ttnd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnd)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_ttnd
            // 
            this.grb_ttnd.Controls.Add(this.pnl_ttnd);
            this.grb_ttnd.Controls.Add(this.btn_xoa);
            this.grb_ttnd.Controls.Add(this.btn_sua);
            this.grb_ttnd.Controls.Add(this.btn_them);
            this.grb_ttnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ttnd.Location = new System.Drawing.Point(6, 8);
            this.grb_ttnd.Name = "grb_ttnd";
            this.grb_ttnd.Size = new System.Drawing.Size(268, 437);
            this.grb_ttnd.TabIndex = 0;
            this.grb_ttnd.TabStop = false;
            this.grb_ttnd.Text = "Thông tin người dùng";
            // 
            // pnl_ttnd
            // 
            this.pnl_ttnd.Controls.Add(this.dt_ns);
            this.pnl_ttnd.Controls.Add(this.txt_dienthoai);
            this.pnl_ttnd.Controls.Add(this.txt_diachi);
            this.pnl_ttnd.Controls.Add(this.txt_tnv);
            this.pnl_ttnd.Controls.Add(this.txt_manv);
            this.pnl_ttnd.Controls.Add(this.label5);
            this.pnl_ttnd.Controls.Add(this.label6);
            this.pnl_ttnd.Controls.Add(this.label4);
            this.pnl_ttnd.Controls.Add(this.label2);
            this.pnl_ttnd.Controls.Add(this.label8);
            this.pnl_ttnd.Location = new System.Drawing.Point(3, 21);
            this.pnl_ttnd.Name = "pnl_ttnd";
            this.pnl_ttnd.Size = new System.Drawing.Size(264, 351);
            this.pnl_ttnd.TabIndex = 4;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(31, 292);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(190, 22);
            this.txt_dienthoai.TabIndex = 6;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(31, 214);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(190, 56);
            this.txt_diachi.TabIndex = 5;
            // 
            // txt_tnv
            // 
            this.txt_tnv.Location = new System.Drawing.Point(31, 101);
            this.txt_tnv.Name = "txt_tnv";
            this.txt_tnv.Size = new System.Drawing.Size(190, 22);
            this.txt_tnv.TabIndex = 2;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(31, 38);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(190, 22);
            this.txt_manv.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã nhân viên";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(168, 389);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 31);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(87, 389);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 31);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(6, 389);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 31);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsnd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người dùng";
            // 
            // dgv_dsnd
            // 
            this.dgv_dsnd.AllowUserToAddRows = false;
            this.dgv_dsnd.AllowUserToDeleteRows = false;
            this.dgv_dsnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.ngaysinh,
            this.diachi,
            this.dienthoai});
            this.dgv_dsnd.Location = new System.Drawing.Point(5, 21);
            this.dgv_dsnd.Name = "dgv_dsnd";
            this.dgv_dsnd.ReadOnly = true;
            this.dgv_dsnd.Size = new System.Drawing.Size(843, 399);
            this.dgv_dsnd.TabIndex = 0;
            this.dgv_dsnd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnd_CellContentClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện thoại";
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Blue;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1018, 524);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(103, 31);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dt_ns
            // 
            this.dt_ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ns.Location = new System.Drawing.Point(31, 162);
            this.dt_ns.Name = "dt_ns";
            this.dt_ns.Size = new System.Drawing.Size(190, 22);
            this.dt_ns.TabIndex = 11;
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 446);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_ttnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.grb_ttnd.ResumeLayout(false);
            this.pnl_ttnd.ResumeLayout(false);
            this.pnl_ttnd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ttnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_dsnd;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel pnl_ttnd;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tnv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DateTimePicker dt_ns;
    }
}