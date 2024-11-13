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
    public partial class frm_khachdatban : Form
    {
        datban db = new datban();       
        public frm_khachdatban()
        {
            InitializeComponent();
            cbb_tensp.DataSource = db.getdl();
            cbb_tensp.DisplayMember = "tensp";

            dgv_dskdb.DataSource = db.getalldl();
            HienThiDLTextBox();
            grb_nhapthongtin.Enabled = false;
        }

       
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                grb_nhapthongtin.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_maban.Text = "";
                txt_tenban.Text = "";
                txt_khuvuc.Text = "";
                txt_maban.Focus();

                btn_them.Text = "Lưu";
            }
            else
            {
                db.add(txt_maban.Text, txt_tenban.Text, txt_khuvuc.Text, cbb_tensp.Text, int.Parse(txt_soluong.Text));
                dgv_dskdb.DataSource = db.getalldl();
                btn_them.Text = "Thêm";
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                grb_nhapthongtin.Enabled = false;
                HienThiDLTextBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                db.delete(txt_maban.Text);
                dgv_dskdb.DataSource = db.getalldl();
                HienThiDLTextBox();
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa nthông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void HienThiDLTextBox()
        {
            txt_maban.DataBindings.Clear();
            txt_maban.DataBindings.Add("Text", dgv_dskdb.DataSource, "maban");

            txt_tenban.DataBindings.Clear();
            txt_tenban.DataBindings.Add("Text", dgv_dskdb.DataSource, "tenban");

            txt_khuvuc.DataBindings.Clear();
            txt_khuvuc.DataBindings.Add("Text", dgv_dskdb.DataSource, "khuvuc");

            cbb_tensp.DataBindings.Clear();
            cbb_tensp.DataBindings.Add("Text", dgv_dskdb.DataSource, "tensp");

            txt_soluong.DataBindings.Clear();
            txt_soluong.DataBindings.Add("Text", dgv_dskdb.DataSource, "soluong");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                grb_nhapthongtin.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;

                btn_sua.Text = "Lưu";
            }
            else
            {
                db.edit(txt_maban.Text, txt_tenban.Text, txt_khuvuc.Text, cbb_tensp.Text, int.Parse(txt_soluong.Text));
                dgv_dskdb.DataSource = db.getalldl();

                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                grb_nhapthongtin.Enabled = false;
                HienThiDLTextBox();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frm_chonban f = new frm_chonban();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txt_tenban.Text = f.TenBanDuocChon; // Hiển thị tên bàn được chọn
                                                             // Sau đó có thể lưu giá trị này vào cơ sở dữ liệu SQL
            }
        }

       
    }
}
