using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magassagmeres
{
    class Program
    {
        static void Main(string[] args)  // http://aries.ektf.hu/~hz/wiki7/mprog1gy/gyak_05  7-es feladat
        {
            Random rnd = new Random();
            byte meresekSzama;
            do
            {
                Console.WriteLine("Add meg, hogy hány mérést szeretnél végezni (0-255):");
            } while (!byte.TryParse(Console.ReadLine(), out meresekSzama));   //do-while, hogyha a felhasználó nem számot akar megadni.

            ushort[] meresek = new ushort[meresekSzama];
            Console.Write("Mért értékek: ");
            for (int i = 0; i < meresek.Length; i++)
            {
                meresek[i] = (ushort)rnd.Next(0, 50);

                if (meresek[i] == 0)
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write("^");
                }
                bool szigetreLeptunk = false;
                for (int j = 1; j < meresekSzama; j++)
                {
                    if (meresek[j-1] == 0 && meresek[j] > 0)
                    {
                        szigetreLeptunk = true;
                    }
                    else if (szigetreLeptunk && meresek[j] == 0)
                    {
                        Console.WriteLine("Van sziget");
                        break;
                    }

                }


            }
            Console.ReadKey();
        }
    }
}
