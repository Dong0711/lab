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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form =new frmBai3();
            form.ShowDialog();
        }

        private void bai4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form =new frmBai4();
            form.ShowDialog();
        }

        private void vũBáĐôngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
