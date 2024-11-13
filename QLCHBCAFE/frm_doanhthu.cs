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
    public partial class frm_doanhthu : Form
    {
        doanhthu dn = new doanhthu();
        public frm_doanhthu()
        {
            InitializeComponent();
            dataGridView1.DataSource = dn.getdl();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            dataGridView1.DataSource = dn.getdl(textBox1.Text,textBox2.Text);
        }
    }
}
