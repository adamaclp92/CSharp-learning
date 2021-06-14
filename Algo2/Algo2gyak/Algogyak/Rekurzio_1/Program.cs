using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzio_1
{
    class Program
    {
        /*
         FÜGGVÉNY Sorozat(i: EGÉSZ): EGÉSZ;
         ALGORITMUS
            HA i = 0 AKKOR
                SOROZAT <- -1;
            HA i = 1 AKKOR
                SOROZAT <- 2;
            HA i MOD 2 = 0 AKKOR
                SOROZAT <- Sorozat(i-2)**2 - SQRT(Sorozat(i-1));
            KÜLÖNBEN
                SOROZAT <- SQRT(Sorozat(i-2)) + Sorozat(i-1)**2;
            HVÉGE;
        FÜGGVÉNY VÉGE;
             
             
             
             
             */
        static void Main(string[] args)
        {


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Sorozat(i));
            }
            Console.ReadLine();
            
        }

        static int Sorozat(int i)
        {
            if (i == 0)
            {
                return -1;
            }
            if (i == 1)
            {
                return 2;
            }

            if (i % 2 == 0)
            {
                int eredmeny = (int)(Math.Pow(Sorozat(i-2), 2) - Math.Sqrt(Sorozat(i - 1)));
                return eredmeny;
            }
            else
            {
                int eredmeny = (int)(Math.Sqrt(Sorozat(i - 2)) + Math.Pow(Sorozat(i - 1), 2));
                return eredmeny;

            }
        }
    }
}
