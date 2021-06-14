using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g_feladat
{
    class Program
    {
        static void Main(string[] args)
        {

            double gyokKetto = Math.Sqrt(2);
            double kettoPerPi = gyokKetto / 2;

            for (double i = 1; i < 10000; i++)
            {
               gyokKetto = Math.Sqrt(2 + gyokKetto);
               kettoPerPi *= gyokKetto / 2;
            }
            Console.WriteLine(2/kettoPerPi);
            Console.ReadKey();
        }
    }
}
