using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static double Pi(int n)
        {
            double s = 0.0;
            int e = 1;

            for (int i = 1; i <= n; i++)
            {
                s+= e*((double)1/(2*i-1));
                e=-e;

            }
            return 4*s;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Pi ~ {0}", Pi(1000));
            Console.ReadKey();
        }
    }
}
