using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double E()
        {
            double szum = 1.0;
            int e = -1;
            double iszum = 1.0;
            for (int i = 1; i < 10; i++)
            {
                iszum *= i;
                szum += (double)(e * (1 / iszum));
                e = -e;
            }
            return szum;
        }

        static double E2()
        {
            double szum = 2;
            for (int i = 2; i < 9; i++)
            {
                szum = szum * (1+1/(double)i);
            }

            return szum;
        }

        static void Main(string[] args)
        {

            double EgyperCe = E();
            Console.WriteLine(EgyperCe);
           

            double e = E2();
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
