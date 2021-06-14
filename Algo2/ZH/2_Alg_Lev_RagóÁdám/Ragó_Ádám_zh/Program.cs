using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragó_Ádám_zh
{
    /*
     FÜGGVÉNY Sorozat(i: egész): egész
     VÁLTOZÓK
     eredmeny: egész;
     ALGORITMUS
        HA i = 0 AKKOR
            Sorozat <- 3;
        HA i = 1 AKKOR
            Sorozat <- 3;
        HA i = 2 AKKOR
            Sorozat <- 2;
        KÜLÖNBEN HA i MOD 2 = 0 AKKOR
            Sorozat <- Sorozat(i-3) + POW(Sorozat(i-2) + Sorozat(i-2));
        KÜLÖNBEN 
            Sorozat <- Sorozat(i-3) - POW(Sorozat(i-2) - Sorozat(i-2));
        HVÉGE;
     FVÉGE;
       
     
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Sorozat(i)); 
            }
            Console.ReadLine();
        }

        static int Sorozat(int i)
        {
            int eredmeny;
            if (i == 0) return 3;
            if (i == 1) return 4;
            if (i == 2) return 2;
            else if (i % 2 == 0)
            {
                eredmeny = (int)(Sorozat(i - 3) + Math.Pow((Sorozat(i - 2) + Sorozat(i - 1)), 2));
                return eredmeny;
            }
            else
            {
                eredmeny = (int)(Sorozat(i - 3) - Math.Pow((Sorozat(i - 2) - Sorozat(i - 1)), 2));
                return eredmeny;
            }
               
        }
    }
}
