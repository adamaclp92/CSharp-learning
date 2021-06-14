using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzio_feladat2
{
    /*
     FÜGGVÉNY Összeadas(a,b: EGÉSZ): EGÉSZ
        ALGORITMUS
            HA (b>0) AKKOR
                Összeadás <- a + Összeadas(a, b-1);
            KÜLÖNBEN
                Összeadás <- 0;
            HVÉGE;
     FVÉGE;


         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A végeredmény: {0}", Osszeadas(3,7));
            Console.ReadLine();
        }

        static int Osszeadas(int a, int b)
        {
            if (b > 0)
            {
                Console.WriteLine("a = {0}, b = {1}", a, b);
                return a + Osszeadas(a, b - 1);
            }

            else return 0;
        }
    }
}
