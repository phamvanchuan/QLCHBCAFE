namespace QuanCaPhe
{
    partial class frm_nhacungcap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsncc = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ttncc = new System.Windows.Forms.GroupBox();
            this.pnl_ttncc = new System.Windows.Forms.Panel();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsncc)).BeginInit();
            this.grb_ttncc.SuspendLayout();
            this.pnl_ttncc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsncc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(271, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 437);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // dgv_dsncc
            // 
            this.dgv_dsncc.AllowUserToAddRows = false;
            this.dgv_dsncc.AllowUserToDeleteRows = false;
            this.dgv_dsncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.diachi,
            this.sdt,
            this.email});
            this.dgv_dsncc.Location = new System.Drawing.Point(5, 21);
            this.dgv_dsncc.Name = "dgv_dsncc";
            this.dgv_dsncc.ReadOnly = true;
            this.dgv_dsncc.Size = new System.Drawing.Size(843, 399);
            this.dgv_dsncc.TabIndex = 0;
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã nhà cung cấp";
            this.mancc.Name = "mancc";
            this.mancc.ReadOnly = true;
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Tên nhà cung cấp";
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // grb_ttncc
            // 
            this.grb_ttncc.Controls.Add(this.pnl_ttncc);
            this.grb_ttncc.Controls.Add(this.btn_xoa);
            this.grb_ttncc.Controls.Add(this.btn_sua);
            this.grb_ttncc.Controls.Add(this.btn_them);
            this.grb_ttncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ttncc.Location = new System.Drawing.Point(-3, 7);
            this.grb_ttncc.Name = "grb_ttncc";
            this.grb_ttncc.Size = new System.Drawing.Size(268, 437);
            this.grb_ttncc.TabIndex = 4;
            this.grb_ttncc.TabStop = false;
            this.grb_ttncc.Text = "Thông tin nhà cung cấp";
            // 
            // pnl_ttncc
            // 
            this.pnl_ttncc.Controls.Add(this.lblMaNCC);
            this.pnl_ttncc.Controls.Add(this.lblTenNCC);
            this.pnl_ttncc.Controls.Add(this.lblDiaChi);
            this.pnl_ttncc.Controls.Add(this.lblSDT);
            this.pnl_ttncc.Controls.Add(this.lblEmail);
            this.pnl_ttncc.Controls.Add(this.txtMaNCC);
            this.pnl_ttncc.Controls.Add(this.txtTenNCC);
            this.pnl_ttncc.Controls.Add(this.txtDiaChi);
            this.pnl_ttncc.Controls.Add(this.txtSDT);
            this.pnl_ttncc.Controls.Add(this.txtEmail);
            this.pnl_ttncc.Location = new System.Drawing.Point(3, 21);
            this.pnl_ttncc.Name = "pnl_ttncc";
            this.pnl_ttncc.Size = new System.Drawing.Size(264, 351);
            this.pnl_ttncc.TabIndex = 4;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Location = new System.Drawing.Point(14, 19);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(220, 23);
            this.lblMaNCC.TabIndex = 24;
            this.lblMaNCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.Location = new System.Drawing.Point(14, 78);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(220, 23);
            this.lblTenNCC.TabIndex = 25;
            this.lblTenNCC.Text = "Tên Nhà Cung Cấp:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(14, 147);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(100, 23);
            this.lblDiaChi.TabIndex = 26;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(14, 208);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(100, 23);
            this.lblSDT.TabIndex = 27;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(14, 268);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(17, 45);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(217, 22);
            this.txtMaNCC.TabIndex = 29;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(17, 113);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(217, 22);
            this.txtTenNCC.TabIndex = 30;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(17, 183);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 22);
            this.txtDiaChi.TabIndex = 31;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(17, 234);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 22);
            this.txtSDT.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 294);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 33;
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
            // frm_nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_ttncc);
            this.Name = "frm_nhacungcap";
            this.Text = "frm_nhacungcap";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsncc)).EndInit();
            this.grb_ttncc.ResumeLayout(false);
            this.pnl_ttncc.ResumeLayout(false);
            this.pnl_ttncc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.GroupBox grb_ttncc;
        private System.Windows.Forms.Panel pnl_ttncc;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
    }
}