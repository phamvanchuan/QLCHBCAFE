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
    public partial class fr_nhacungcap : Form
    {
        nhacungcap ncc = new nhacungcap();
        public fr_nhacungcap()
        {
            InitializeComponent();
            dgv_dsncc.DataSource = ncc.getallncc();
            LayDuLieuLenTextBox();
            
        }

        private void LayDuLieuLenTextBox()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dgv_dsncc.DataSource, "mancc");

            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", dgv_dsncc.DataSource, "tenncc");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgv_dsncc.DataSource, "diachi");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgv_dsncc.DataSource, "sdt");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgv_dsncc.DataSource, "email");

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txtMaNCC.Text = "";
                txtSDT.Text = "";
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";

                txtEmail.Text = "";


                btn_them.Text = "Lưu";
            }
            else
            {
                ncc.addncc(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                dgv_dsncc.DataSource = ncc.getallncc();
                btn_them.Text = "Thêm";

                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;

                LayDuLieuLenTextBox();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                ncc.editncc(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                dgv_dsncc.DataSource = ncc.getallncc();

                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                LayDuLieuLenTextBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                ncc.deletencc(txtMaNCC.Text);
                dgv_dsncc.DataSource = ncc.getallncc();
                LayDuLieuLenTextBox();
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
