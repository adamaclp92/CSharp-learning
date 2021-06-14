using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzio_feladat4
{
    class Program
    {
        /*
        FÜGGVÉNY Összeg(kezd, veg: egész):egész
        ALGORITMUS
           HA (kezd < veg) AKKOR
               Összeg <- kezd + Összeg(kezd+1, veg);
           KÜLÖNBEN
               Összeg <- veg;
           HVÉGE;
       FVÉGE;
            */
        static void Main(string[] args)
        {
            Console.WriteLine(Osszead(2,5));
            Console.ReadLine();
        }

        static int Osszead(int a, int b)
        {
            if (b < a)
                return a + Osszead(a+1, b);
            else return b;
        }
    }
}
