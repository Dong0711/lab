using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    internal class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public DateTime NgaySX { get; set; }
        public SanPham()
        {

        }
        public int namHetHan()
        {
            return NgaySX.Year+3;
        }
        public string ThongTinSP()
        {
            return string.Format("Mã SP: {0}, Tên SP: {1}, Loại SP: {2}, Ngay SX: {3}", MaSP, TenSP, LoaiSP,NgaySX.ToString("dd/mm/yyyy"));
        }

    }
}
