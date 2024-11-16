using System;
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
    public partial class fr_bc_tkxuat : Form
    {
        bcxuat bcxuat = new bcxuat();
        public fr_bc_tkxuat()
        {
            InitializeComponent();
            dgvBaoCaoThuoc.DataSource = bcxuat.getdl();
        }

        private void fr_bc_tkxuat_Load(object sender, EventArgs e)
        {

        }

        private void btnXemBaoCao_Click_1(object sender, EventArgs e)
        {
            dgvBaoCaoThuoc.DataSource = bcxuat.searchdl(textBox1.Text, textBox2.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvBaoCaoThuoc.DataSource = bcxuat.getdl();
        }
    }
}
