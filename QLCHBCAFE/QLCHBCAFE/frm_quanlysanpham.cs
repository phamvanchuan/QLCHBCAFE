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
    public partial class frm_quanlysanpham : Form
    {
        sanpham sp = new sanpham();
        public frm_quanlysanpham()
        {
            InitializeComponent();
            cbbncc.DataSource = sp.getdl();
            cbbncc.ValueMember = "mancc";
            dgv_dssp.DataSource = sp.getallsp();
            HienThiDLTextBox();
            grb_ttsp.Enabled= false;
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
           
            if (btn_them.Text == "Thêm")
            {
                grb_ttsp.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_masp.Text = "";
                txt_dongia.Text = "";
                txt_tensp.Text = "";
                txtslnhap.Text = "";
                dt_np.Value =DateTime.Now;
                txt_masp.Focus();

                btn_them.Text = "Lưu";
            }
            else
            {
                sp.addsp(txt_masp.Text, txt_tensp.Text, int.Parse(txt_dongia.Text), cbbncc.Text, int.Parse(txtslnhap.Text), dt_np.Value);
                dgv_dssp.DataSource=sp.getallsp();
                btn_them.Text = "Thêm";
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                grb_ttsp.Enabled = false;
                HienThiDLTextBox();
            }
            

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                grb_ttsp.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;

                btn_sua.Text = "Lưu";
            }
            else
            {
                sp.editsp(txt_masp.Text, txt_tensp.Text, int.Parse(txt_dongia.Text), cbbncc.Text, int.Parse(txtslnhap.Text), dt_np.Value);
                dgv_dssp.DataSource = sp.getallsp();
                btn_sua.Text = "Sửa";
                grb_ttsp.Enabled = false;
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;

                
                HienThiDLTextBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                sp.deletesp(txt_masp.Text);
                dgv_dssp.DataSource = sp.getallsp();
                HienThiDLTextBox();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

       

       

        private void HienThiDLTextBox()
        {
            txt_masp.DataBindings.Clear();
            txt_masp.DataBindings.Add("Text", dgv_dssp.DataSource, "masp");

            txt_tensp.DataBindings.Clear();
            txt_tensp.DataBindings.Add("Text", dgv_dssp.DataSource, "tensp");

            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", dgv_dssp.DataSource, "dongia");

            txtslnhap.DataBindings.Clear();
            txtslnhap.DataBindings.Add("Text", dgv_dssp.DataSource, "slnhap");



            dt_np.DataBindings.Clear();
            dt_np.DataBindings.Add("Value", dgv_dssp.DataSource, "ngaynhap");

            cbbncc.DataBindings.Clear();
            cbbncc.DataBindings.Add("SelectedValue", dgv_dssp.DataSource, "mancc");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
