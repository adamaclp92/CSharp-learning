using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_B_2
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
            Console.WriteLine(Osszeg(1,6));
            Console.ReadLine();
        }

        static int Osszeg(int kezd, int veg)
        {
            if (kezd < veg)
            { 
                Console.WriteLine("{0}, {1}", kezd, veg);
                return kezd + Osszeg(kezd + 1, veg);
            }

            else return veg;
            
            
                
        }
    }


}
