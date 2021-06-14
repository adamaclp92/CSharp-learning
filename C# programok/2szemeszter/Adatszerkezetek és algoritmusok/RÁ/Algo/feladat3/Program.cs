using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat3
{
    /*FÜGGVÉNY E(v2)(N:EGÉSZ): VALÓS;
     *  VÁLTOZÓK
     *      I:EGÉSZ;
     *      J:EGÉSZ;
     *      F:EGÉSZ;
     *      S:VALÓS;
     *      
     *   ALGORITMUS   
     *      S <- 1;
     *      F <- 1; a szorzás művelet miatt
     *          F<- 1;
     *          CIKLUS J <- 1...I
     *          F=F*I;
     *          S <-1/F;
     *          CIKLUS_VÉGE
     *      
     *      E<-S;
     *FÜGGVÉNY_VÉGE;      
  */
    class Program
    {
        static double e(int n)
        {
            double s = 1.0;
            ulong f = 1;
            for (int i = 1; i < n; i++)
            {
                f *= (ulong)i;
                s += (double)1 / f;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("e~ {0}", e(20));
            Console.WriteLine("e= {0}", Math.E);
            Console.ReadKey();
        }
    }
}

