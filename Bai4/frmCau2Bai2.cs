using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmCau2Bai2 : Form
    {
        public frmCau2Bai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if(rdbCong.Checked)
            {
                txtKQ.Text=(int.Parse(txtA.Text)+int.Parse(txtB.Text)).ToString();
            }
            else if(rdbTru.Checked)
            {
                txtKQ.Text = (int.Parse(txtA.Text) - int.Parse(txtB.Text)).ToString();

            }
            else if(rdbNhan.Checked)
            {
                txtKQ.Text = (int.Parse(txtA.Text) * int.Parse(txtB.Text)).ToString();

            }
            else
                txtKQ.Text = (int.Parse(txtA.Text) / int.Parse(txtB.Text)).ToString();

        }
    }
}
