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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

     

        private void bài1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
var forn = new frmCau3Bai1();
            forn.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
var forn = new frmCau3Bai2();
            forn.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
var form =new frmCau3Bai3();
            form.ShowDialog();
        }

        private void câu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCau2Bai1();
            form.ShowDialog();
        }

        private void bàiThiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bài1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form =new frmCau2Bai1();
            form.ShowDialog();  
        }

        private void bài2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmCau2Bai2();
            form.ShowDialog();
        }

        private void bài3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new frmCau2Bai3();
            form.ShowDialog();
        }
    }
}
