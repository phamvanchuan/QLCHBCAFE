using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanCaPhe
{
    public partial class frm_chonban : Form
    {
        public string TenBanDuocChon { get; set; }
        public frm_chonban()
        {
            InitializeComponent();
        }
       
        private void frm_chonban_Load(object sender, EventArgs e)
        {
           
        }

        private void panelBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            var selectedPictureBox = sender as PictureBox;
            if (selectedPictureBox != null)
            {
                // Lưu tên bàn vào thuộc tính
                TenBanDuocChon = selectedPictureBox.Name;

                //selectedPictureBox.Enabled = false;
                // Đóng form và trả về DialogResult.OK để thông báo là có bàn được chọn
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void pictureBox25_DoubleClick(object sender, EventArgs e)
        {
            var selectedPictureBox = sender as PictureBox;
            if (selectedPictureBox != null)
            {
                
                selectedPictureBox.Enabled = true;
            }
            
        }
    }
}
