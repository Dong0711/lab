using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmCau2Bai1 : Form
    {
        public frmCau2Bai1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi(txtMaTB.Text, txtTenTB.Text, txtNuocSX.Text, int.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text));

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            txtTTTB.Text=ThietBi.ThongTin();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            txtTien.Text=ThietBi.ThanhTien().ToString();
        }
    }
}
