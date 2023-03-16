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
    public partial class frmCau3Bai2 : Form
    {
        public frmCau3Bai2()
        {
            InitializeComponent();
        }

        

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if(float.Parse(txtDiemLT.Text) > 10 || float.Parse(txtDiemLT.Text) < 0 || float.Parse(txtDiemTH.Text) > 10 || float.Parse(txtDiemTH.Text) <0)
            {
                MessageBox.Show("Điểm không thể lớn hơn 10 hoặc bé hơn 0");
                txtDiemLT.Text = "";
                txtDiemTH.Text = "";
                txtDiemLT.Focus();
            }    
            float diem = (float.Parse(txtDiemLT.Text)+float.Parse(txtDiemTH.Text))/2;
            if (diem >= 9)
                MessageBox.Show("Xếp loại xuất sắc");
            else if (diem >= 8)
                MessageBox.Show("Xếp loại xuất giỏi");
            else if (diem >= 7)
                MessageBox.Show("Xếp loại xuất khá");
            else if (diem >= 5)
                MessageBox.Show("Xếp loại xuất trung bình");
            else MessageBox.Show("Xếp loại yếu ");


        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            txtDiemLT.Focus();
        }
    }
}
