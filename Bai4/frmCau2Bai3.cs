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
    public partial class frmCau2Bai3 : Form
    {
        public frmCau2Bai3()
        {
            InitializeComponent();
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string hoten="";
            TongHop.NoiChuoi(txtHo.Text, txtTen.Text, ref hoten);
            txtHoTen.Text = hoten;  
        }

        private void txtTinh_Click(object sender, EventArgs e)
        {
            txtkq.Text = TongHop.GiaiThua(int.Parse(txtN.Text)).ToString();
        }
    }
}
