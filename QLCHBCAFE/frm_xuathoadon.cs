using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanCaPhe
{
    public partial class frm_xuathoadon : Form
    {
        hoadon hd = new hoadon();
        public frm_xuathoadon()
        {
            InitializeComponent();
            dgv_dshd.DataSource = hd.getallhd();
            LayDuLieuLenTextBox();

            cbb_nhanvien.DataSource = hd.getdlnv();
            cbb_nhanvien.ValueMember = "manv";

            cbb_maban.DataSource = hd.getdlb();
            cbb_maban.ValueMember = "maban";

            cbb_masp.DataSource = hd.getdlsp();
            cbb_masp.ValueMember = "masp";

            groupBox1.Enabled = false;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                groupBox1.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_mahd.Text = "";
                dt_nx.Value = DateTime.Now;
                txt_soluongmua.Text = "";
                txt_dongia.Text="";

                btn_them.Text = "Lưu";
            }
            else
            {
                hd.addhd(txt_mahd.Text, cbb_maban.Text, cbb_masp.Text, cbb_nhanvien.Text, dt_nx.Value, int.Parse(txt_soluongmua.Text), int.Parse(txt_dongia.Text));
                dgv_dshd.DataSource = hd.getallhd();
                btn_them.Text = "Thêm";
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                groupBox1.Enabled = false;
                LayDuLieuLenTextBox();
            }
            
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                hd.deletehd(txt_mahd.Text);
                dgv_dshd.DataSource = hd.getallhd();
                LayDuLieuLenTextBox();
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa nthông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        
            
        private void btn_in_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Lưu hóa đơn";
                saveFileDialog.FileName = "HoaDon_" + txt_mahd.Text + ".txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Ghi nội dung hóa đơn
                        writer.WriteLine("===========================================");
                        writer.WriteLine("                HÓA ĐƠN BÁN HÀNG         ");
                        writer.WriteLine("===========================================");
                        writer.WriteLine("Mã Hóa Đơn: " + txt_mahd.Text);
                        writer.WriteLine("Ngày Xuất: " + dt_nx.Value);
                        writer.WriteLine("Nhân Viên: " + cbb_nhanvien.Text);
                        writer.WriteLine("Mã Bàn: " + cbb_maban.Text);
                        writer.WriteLine("-------------------------------------------");

                        // Ghi thông tin sản phẩm
                        writer.WriteLine("Sản Phẩm: " + cbb_masp.Text);
                        writer.WriteLine("Số Lượng Mua: " + txt_soluongmua.Text);
                        writer.WriteLine("Đơn giá Mua: " + txt_dongia.Text);

                        if (int.TryParse(txt_dongia.Text, out int donGia) && int.TryParse(txt_soluongmua.Text, out int soLuong))
                        {
                            int thanhTien = donGia * soLuong;
                            writer.WriteLine("Thành Tiền: " + thanhTien);
                        }
                        else
                        {
                            writer.WriteLine("Thành Tiền: Không xác định (lỗi định dạng)");
                        }

                        writer.WriteLine("-------------------------------------------");
                        writer.WriteLine("Tổng Tiền: " + (int.Parse(txt_dongia.Text) * int.Parse(txt_soluongmua.Text)).ToString());
                        writer.WriteLine("===========================================");
                        writer.WriteLine("Cảm ơn quý khách đã sử dụng dịch vụ!");
                    }

                    MessageBox.Show("Hóa đơn đã được lưu tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void LayDuLieuLenTextBox()
        {
            txt_mahd.DataBindings.Clear();
            txt_mahd.DataBindings.Add("Text", dgv_dshd.DataSource, "mahd");

            cbb_maban.DataBindings.Clear();
            cbb_maban.DataBindings.Add("Text", dgv_dshd.DataSource, "maban");

            cbb_masp.DataBindings.Clear();
            cbb_masp.DataBindings.Add("Text", dgv_dshd.DataSource, "masp");

            cbb_nhanvien.DataBindings.Clear();
            cbb_nhanvien.DataBindings.Add("Text", dgv_dshd.DataSource, "manv");

            dt_nx.DataBindings.Clear();
            dt_nx.DataBindings.Add("Value", dgv_dshd.DataSource, "ngayxuat");

            txt_soluongmua.DataBindings.Clear();
           txt_soluongmua.DataBindings.Add("Text", dgv_dshd.DataSource, "soluongmua");

            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", dgv_dshd.DataSource, "dongiaban");
        }

       
        

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                groupBox1.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;

                btn_sua.Text = "Lưu";
            }
            else
            {
                hd.edithd(txt_mahd.Text, cbb_maban.Text, cbb_masp.Text, cbb_nhanvien.Text, dt_nx.Value, int.Parse(txt_soluongmua.Text), int.Parse(txt_dongia.Text));
                dgv_dshd.DataSource = hd.getallhd();

                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                groupBox1.Enabled = false;
                LayDuLieuLenTextBox();
            }
            
        }
    }
}
