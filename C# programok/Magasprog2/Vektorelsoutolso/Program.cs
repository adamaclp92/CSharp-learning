using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorelsoutolso
{
    class Program
    {
        static void Main(string[] args)  //http://aries.ektf.hu/~hz/wiki7/mprog1gy/gyak_12 4-es feladat
        {
            Random rnd = new Random();
            int[] vektor = new int[30];
            byte darab = 0;
          
            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < vektor.Length; i++)
            {
                vektor[i] = rnd.Next(20, 61);
                Console.Write("{0}, ", vektor[i]);
                if (vektor[i] < vektor[0] || vektor[i] > vektor.Length-1)
                {
                    darab++;
                }
                else { }

            }
            Console.WriteLine("Ennyi szám van, ami kisebb, mint a vektor legelső eleme, vagy nagyobb, mint a tömb utolsó eleme: {0}", darab);

            Console.ReadKey();
        }
    }
}
