using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class TinhToan
    { 
        public static int TimUCLN(int a,int b)
        {
            int kq = 1;
            
            for (int i=Math.Min(a,b); i>0; i--) 
            {
                if (a % i == 0 && b % i == 0)
                { return i; 
                //Console.WriteLine(kq);
                }

            }
            return kq;
            
        }
    }
}
