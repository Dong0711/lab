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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand=new Random();
            for(int i=0;i<10;i++)
            {
                listBox1.Items.Add(rand.Next(1,100));
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            foreach(var item in listBox1.Items)
            {
                if(item.ToString()==txtNhap.Text)
                {
                    label3.Text = "Có tồn tại số trong danh sách";
                    return;
                }    
            }
            label3.Text= "Không tồn tại số trong danh sách";
        }
    }
}
