using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanCaPhe
{
    public partial class frm_nhanvien : Form
    {
        nhanvien nv = new nhanvien();
        public frm_nhanvien()
        {
            InitializeComponent();
            dgv_dsnd.DataSource= nv.getallnv();
            LayDuLieuLenTextBox();
         
            pnl_ttnd.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                pnl_ttnd.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_manv.Text = "";
                txt_tnv.Text = "";

                dt_ns.Value = DateTime.Now.Date;
                txt_diachi.Text = "";
                txt_dienthoai.Text = "";
                

                btn_them.Text = "Lưu";
            }
            else
            {
                nv.addnv(txt_manv.Text, txt_tnv.Text, dt_ns.Value, txt_diachi.Text, txt_dienthoai.Text);
                dgv_dsnd.DataSource = nv.getallnv();
                pnl_ttnd.Enabled = false;
                btn_them.Text = "Thêm";
                
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                
                LayDuLieuLenTextBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                nv.deletenv(txt_manv.Text);
                dgv_dsnd.DataSource = nv.getallnv();
                LayDuLieuLenTextBox();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void LayDuLieuLenTextBox()
        {
            txt_manv.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", dgv_dsnd.DataSource, "manv");

            txt_tnv.DataBindings.Clear();
            txt_tnv.DataBindings.Add("Text", dgv_dsnd.DataSource, "tennv");


           

            dt_ns.DataBindings.Clear();
            dt_ns.DataBindings.Add("Value", dgv_dsnd.DataSource, "ngaysinh");

            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dgv_dsnd.DataSource, "diachi");

            txt_dienthoai.DataBindings.Clear();
            txt_dienthoai.DataBindings.Add("Text", dgv_dsnd.DataSource, "dienthoai");

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                pnl_ttnd.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                nv.editnv(txt_manv.Text, txt_tnv.Text, dt_ns.Value, txt_diachi.Text, txt_dienthoai.Text);
                dgv_dsnd.DataSource = nv.getallnv();

                btn_sua.Text = "Sửa";
                pnl_ttnd.Enabled = false;
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                LayDuLieuLenTextBox();
            }
        }

        private void dgv_dsnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
