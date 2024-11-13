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
    public partial class fr_chinh : Form
    {
        public fr_chinh()
        {
            InitializeComponent();
            GiaoDien();
        }

        private void fr_chinh_Load(object sender, EventArgs e)
        {

        }
        private void GiaoDien()
        {
            panelDanhmuc.Visible = false;
            panelHethong.Visible = false;
            panelNghiepvu.Visible = false;
        }
        private void anMenucon()
        {
            if (panelDanhmuc.Visible == true)
            {
                panelDanhmuc.Visible = false;
            }
            if (panelHethong.Visible == true)
            {
                panelHethong.Visible = false;
            }
            if (panelNghiepvu.Visible == true)
            {
                panelNghiepvu.Visible = false;
            }
        }
        private void hienMenucon(Panel panel)
        {
            if (panel.Visible == false)
            {
                anMenucon();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void btnHethong_Click(object sender, EventArgs e)
        {
            hienMenucon(panelHethong);
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            hienMenucon(panelDanhmuc);
        }

        private void btnNghiepvu_Click(object sender, EventArgs e)
        {
            hienMenucon(panelNghiepvu);
        }

        private void btnQLNv_Click(object sender, EventArgs e)
        {
            openChuongTrinh(new fr_nhanvien());
            //
            //
            anMenucon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLSp_Click(object sender, EventArgs e)
        {
            openChuongTrinh(new fr_quanlysanpham());
            //
            //
            anMenucon();
        }

        private void btnKhachdatban_Click(object sender, EventArgs e)
        {
            openChuongTrinh(new fr_khachdatban());
            //
            //
            anMenucon();
        }

        private void btnXuathoadon_Click(object sender, EventArgs e)
        {
            openChuongTrinh(new fr_xuathoadon());
            //
            //
            anMenucon();
        }
        private Form activeForm = null;
        private void openChuongTrinh(Form ChuongTrinh)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ChuongTrinh.TopLevel = false;
            activeForm = ChuongTrinh;
            ChuongTrinh.FormBorderStyle = FormBorderStyle.None;
            ChuongTrinh.Dock = DockStyle.Fill;
            panelChuongTrinh.Controls.Add(ChuongTrinh);
            panelChuongTrinh.Tag = ChuongTrinh;
            ChuongTrinh.BringToFront();
            ChuongTrinh.Show();


        }
    }
}
