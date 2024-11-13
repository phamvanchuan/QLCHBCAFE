using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanCaPhe
{
    public partial class frm_chinh : Form
    {
        private int childFormNumber = 0;

        public frm_chinh()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CDSNGVK\MAY1;Initial Catalog=QuanCaPhe;Integrated Security=True");

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       

        private void tHOÁTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }


     

        private void qUẢNLÝSẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_quanlysanpham qlsp = new frm_quanlysanpham();
            qlsp.ShowDialog();
        }

        private void qUẢNLÝNHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhacungcap ncc = new frm_nhacungcap();
            ncc.ShowDialog();
        }

        private void bCTKNHAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bc_tknhap f = new frm_bc_tknhap();
            f.ShowDialog();
        }

        private void bCTKXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bc_tkxuat f = new frm_bc_tkxuat();
            f.ShowDialog();
        }

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_nhanvien qlnhanvien = new frm_nhanvien();
            qlnhanvien.ShowDialog();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khachdatban kdb = new frm_khachdatban();
            kdb.ShowDialog();
        }

        private void xUẤTHÓAĐƠNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_xuathoadon xhd = new frm_xuathoadon();
            xhd.ShowDialog();
        }

        private void tKDOANHTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_doanhthu f = new frm_doanhthu();
            f.ShowDialog();
        }
    }
}
