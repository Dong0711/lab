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
    public partial class frmBai3 : Form
    {
        List<string> TuMoi = new List<string>();
        List<string> nghia=new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

    

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu=txtTuMoi.Text;
            listBox1.Items.Add(tu);
            TuMoi.Add(tu);
            nghia.Add(txtNghiaTu.Text);
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaTu.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtHienNghiaTu.Text = nghia[listBox1.SelectedIndex];
        
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {
            txtTuMoi.Focus();
        }
    }
}
