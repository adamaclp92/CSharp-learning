using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3;
            int j = 1;
            for (double i = 3; i < 10000; i+=2)
            {

                Pi += j*(4 / ((i - 1) * i * (i + 1)));
                j = -j;
            }
            Console.WriteLine(Pi);
            Console.ReadKey();

        }
    }
}
