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
    public partial class frs_chinh : Form
    {
        public frs_chinh()
        {
            InitializeComponent();
            GiaoDien();
        }

        private void frs_chinh_Load(object sender, EventArgs e)
        {

        }
        private void GiaoDien()
        {
            panelHethong.Visible = false;
            panelDanhmuc.Visible = false;
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

        private void btnHethong_Click(object sender, EventArgs e)
        {
            hienMenucon(panelHethong);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anMenucon();
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            hienMenucon(panelDanhmuc);
        }

        private void btnSanphamnhap_Click(object sender, EventArgs e)
        {
            labmuc.Text = "QL Sản phẩm nhập";
            openChuongTrinh(new fr_quanlysanpham());

           
        }

        private void btnNhacc_Click(object sender, EventArgs e)
        {
            labmuc.Text = "QL Nhà cung cấp";
            openChuongTrinh(new fr_nhacungcap());


            
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            labmuc.Text = "QL Nhân viên";
            openChuongTrinh(new fr_nhanvien());


            
        }

        private void btnDatban_Click(object sender, EventArgs e)
        {
            labmuc.Text = "QL Đặt bàn";
            openChuongTrinh(new fr_khachdatban());


            
        }

        private void btnXuathoadon_Click(object sender, EventArgs e)
        {
            labmuc.Text = "Xuất hóa đơn";
            openChuongTrinh(new fr_xuathoadon());


            
        }

        private void btnNghiepvu_Click(object sender, EventArgs e)
        {
            hienMenucon(panelNghiepvu);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            labmuc.Text = "BC_TK_Nhập";
            openChuongTrinh(new fr_bc_tknhap());
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            labmuc.Text = "BC_TK_Xuất";
            openChuongTrinh(new fr_bc_tkxuat());
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            labmuc.Text = "Doanh Thu";
            openChuongTrinh(new fr_doanhthu());
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            anMenucon();
            this.Close();
        }
    }
}
