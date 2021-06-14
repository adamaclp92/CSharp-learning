using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adj meg egy számot.");
            ushort szam = ushort.Parse(Console.ReadLine());
            Console.Clear();

            int[] tomb = new int[szam];
            int osszeg = 0;


            for (int i = 0; i < tomb.Length; i++)
            {
                do
                {
                    Console.WriteLine("Adj meg a(z) {0}. számot, ami -2000 és 2000 közé esik, és páros!", i + 1);
                    tomb[i] = int.Parse(Console.ReadLine());
                    Console.Clear();

                } while (!(tomb[i] < 2000 && tomb[i] > -2000 && tomb[i] % 2 == 0));

                osszeg = osszeg + tomb[i];
                
            }
           
            Console.WriteLine("A számok összege: {0}, és az átlaga: {1}.", osszeg, osszeg/tomb.Length);
            Console.ReadLine();

        }
    }
}
/*Kérj be a felhasználótól egy n számot.

Ezek után kérj be tőle n db. -2000 és 2000 közé eső, páros számot.

Ha a felhasználó nem ilyen számot ír be, akkor azt ne vedd figyelembe!

A bekért (és figyelembe vett) számoknak számold és írd ki az összegét és az átlagát! */