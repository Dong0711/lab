using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class TongHop
    {
        public static void NoiChuoi(string a, string b, ref string c)
        {
            c= a+" "+b;

                 }
        public static int GiaiThua(int n)
        {
            int kq = 1;
        for ( int i=1; i <= n; i++ ) {
                kq= kq*i;
            }   
        return kq;
        }
    }
}
