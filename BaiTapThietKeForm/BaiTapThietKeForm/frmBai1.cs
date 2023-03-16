using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai1 : Form
    {
        int giaXeXanh = 22000;
        int giaXeDo = 21000;
        int giaXeTrang = 20000;
        //int giaXe = 0;
        public frmBai1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            if(rdXanh.Checked)
            {
                txtGia.Text = giaXeXanh.ToString();
                pictureBox1.Image = Image.FromFile(@"bluecar.jpg");
            }
          
            

        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Text = giaXeTrang.ToString();

            pictureBox1.Image = Image.FromFile(@"whitecar.jpg");
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Text = giaXeDo.ToString();
            pictureBox1.Image = Image.FromFile(@"redcar.jpg");
        }

        private void bntTinhTien_Click(object sender, EventArgs e)
        {
            int sotien = int.Parse(txtGia.Text)* int.Parse(txtSoLuong.Text);

            lblSoTien.Text = sotien.ToString();
        }
    }
}
