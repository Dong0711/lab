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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt=cbbHangHoa.SelectedIndex;
            switch (stt)
            {
                case 0:
                    txtGia.Text = "100000";
                    break;
                case 1:
                    txtGia.Text = "2000000";

                    break;
                case 2:
                    txtGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if(rdbChuyenKhoan.Checked)
            {
                lalThanhTien.Text=( int.Parse(txtGia.Text) * int.Parse(txtSoLuong.Text) / 100 * 95).ToString();
            }    
            else
                lalThanhTien.Text = (int.Parse(txtGia.Text) * int.Parse(txtSoLuong.Text) ).ToString()+" Đồng";
        }
    }
}
