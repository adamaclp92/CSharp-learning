using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_B_1
{

    /*
     * FÜGGVÉNY Rekurzio(i: egész): egész
     * ALGORITMUS
     *      HA (i=0) AKKOR
     *          Rekurzio <- 3;
     *      HA (i=1) AKKOR
     *          Rekurzio <- 7;
            HA (i MOD 2 = 0) AKKOR
                Rekurzio <-SQRT(POW(Rekurzio(i-2), 2) + POW(Rekurzio(i-1), 2));
           KÜLÖNBEN
                Rekurzio <-SQRT(POW(Rekurzio(i-1), 2) - POW(Rekurzio(i-2), 2));
            HVÉGE;
        FVÉGE;

         
         */
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Rekurzio(i));
            }
            Console.ReadLine();
        }

        static int Rekurzio(int i)
        {
            if (i == 0) return 3;
            if (i == 1) return 7;
            
            if (i % 2 == 0)
                {
                    int eredmeny;
                    eredmeny = (int)(Math.Sqrt(Math.Pow(Rekurzio(i - 2), 2) + Math.Pow(Rekurzio(i - 1), 2)));
                    return eredmeny;
                }
            else
                {
                    int eredmeny;
                    eredmeny = (int)(Math.Sqrt(Math.Pow(Rekurzio(i - 1), 2) - Math.Pow(Rekurzio(i - 2), 2)));
                    return eredmeny;

                }
            
        }
    }
}
