using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.feladat
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int Gcd(int x, int y)
        {
            
            int tx;
            int ty;

            if (x >= y && y != 0)
            {
                tx = x;
                ty = y;

                if (ty != 0)
                {
                    return Gcd(tx % ty, ty);
                }
                return tx;
            }
            else return -1;
        }
    }
}
