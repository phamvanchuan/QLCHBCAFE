﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBCAFE
{
    public partial class frm_bc_tknhap : Form
    {
        bcnhap bcnhap = new bcnhap();
        public frm_bc_tknhap()
        {
            InitializeComponent();
            dgvBaoCaoThuoc.DataSource = bcnhap.getdl();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            dgvBaoCaoThuoc.DataSource = bcnhap.searchdl(textBox1.Text, textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBaoCaoThuoc.DataSource = bcnhap.getdl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}