using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlenprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte[] tomb = new Byte[20];
            int parososszeg = 0;
            int paratlanosszeg = 0;
            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = (byte)rnd.Next(10, 41);
                Console.Write("{0}, ", tomb[i]);
                if (i % 2 == 0)
                {
                    parososszeg = parososszeg + tomb[i];
                }

                else 
                {
                    paratlanosszeg = paratlanosszeg + tomb[i];
                }
            }
            double szazalek1 = (double)parososszeg / (parososszeg + paratlanosszeg) * 100;
            double szazalek2 = (double)paratlanosszeg / (parososszeg + paratlanosszeg) * 100;

            Console.WriteLine("\nA páros sorszámúak összege {0}, ami {1:F2} %-a az összesnek.", parososszeg, szazalek1);  //:F2 2 százalékpont pontossággal adja meg
            Console.WriteLine("A páratlan sorszámúak összege {0}, ami {1:F2} %-a az összesnek.", paratlanosszeg, szazalek2);
            Console.WriteLine("Százalékos eltérés: {0:F2} %", Math.Abs(szazalek1 - szazalek2));
            Console.ReadLine();
        }
    }
}
