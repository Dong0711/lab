using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }
        private void CongHaiSo(int a,int b,int c)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {int kq = 0;
            if(rdbTongAB.Checked)
            {
                TinhToan.Cong2So(int.Parse(txtA.Text), int.Parse(txtB.Text),ref kq);
                Console.WriteLine(kq);
            }   
            else
            {
                kq = TinhToan.TongDaySo(int.Parse(txtC.Text));
            }

            labKetQua.Text = kq.ToString();
        }
    }
}
