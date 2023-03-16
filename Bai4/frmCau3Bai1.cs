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
    public partial class frmCau3Bai1 : Form
    {
        public frmCau3Bai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = "SP01";
            sp.TenSP = "CPU";
            sp.LoaiSP = "Tiêu dùng";
            sp.NgaySX = new DateTime(2022, 12, 31);
            DateTime ngayHetHan = new DateTime( sp.namHetHan(), sp.NgaySX.Month,sp.NgaySX.Day); 
            txtThongTin.Text = sp.ThongTinSP() +", Năm hết hạn: "+ngayHetHan.ToString("dd/mm/yyyy");
        }
    }
}
