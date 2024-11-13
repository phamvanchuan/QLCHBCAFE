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
    public partial class frm_chinh : Form
    {
        public frm_chinh()
        {
            InitializeComponent();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
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
