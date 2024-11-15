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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Desing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Desing()
        {
            panelMedia.Visible = false;
            panelPlay.Visible = false;
            panelTools.Visible = false;
        }
        private void anMenucon()
        {
            if(panelMedia.Visible==true) 
            {
                panelMedia.Visible = false;
            }
            if (panelPlay.Visible == true)
            {
                panelPlay.Visible = false;
            }
            if (panelTools.Visible == true)
            {
                panelTools.Visible = false;
            }
        }
        private void hienMenucon(Panel panel)
        {
            if( panel.Visible==false)
            {
                anMenucon();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            hienMenucon(panelMedia);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChillform(new FORMTEXT1());
            //
            //
            anMenucon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChillform(new frDangNhap());
            //
            //
            anMenucon();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void btnequa_Click(object sender, EventArgs e)
        {
            openChillform(new FORMTEXT2());
            //
            //
            anMenucon();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            hienMenucon(panelPlay);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            //
            //
            anMenucon();
        }

        private void btntools_Click(object sender, EventArgs e)
        {
            hienMenucon(panelTools);
        }

        private Form activeForm = null;
        private void openChillform(Form chillForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            chillForm.TopLevel = false;
            activeForm = chillForm;
                chillForm.FormBorderStyle = FormBorderStyle.None;
                chillForm.Dock = DockStyle.Fill;
                panelChillform.Controls.Add(chillForm);
                panelChillform.Tag = chillForm;
                chillForm.BringToFront();
                chillForm.Show();
            
            
        }
    }
}
