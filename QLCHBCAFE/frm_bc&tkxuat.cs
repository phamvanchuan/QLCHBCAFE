using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanCaPhe
{
    public partial class frm_bc_tkxuat : Form
    {
        bcxuat bcxuat = new bcxuat();
        public frm_bc_tkxuat()
        {
            InitializeComponent();
            dgvBaoCaoThuoc.DataSource = bcxuat.getdl();
        }
        
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            dgvBaoCaoThuoc.DataSource = bcxuat.searchdl(textBox1.Text,textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBaoCaoThuoc.DataSource = bcxuat.getdl();
        }
    }
}
