using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class ThietBi
    {
        public static string MaTB { get; set; }
        public static string TenTB { get; set; }
        public static string  NuocSX { get; set; }
        public static int DonGia { get; set; }
        public static int SoLuong { get;set; }
        public ThietBi(string maTB, string tenTB, string nuocSX, int donGia, int soLuong)
        {
            MaTB = maTB;
            TenTB = tenTB;
            NuocSX = nuocSX;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public static int ThanhTien()
        {
            
            return DonGia * SoLuong;
        }
        public static string ThongTin()
        {
            return string.Format("{0},{1},{2},{3},{4}", MaTB, TenTB, NuocSX, DonGia, SoLuong);
        }
     }
}
