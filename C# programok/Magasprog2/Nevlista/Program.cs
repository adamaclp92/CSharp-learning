using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevlista
{
    class Program
    {
        static void Main(string[] args)  //Névlista
        {
            byte nevekSzama;
            do
            {
                Console.WriteLine("Add meg, hogy hány nevet szeretnél tárolni (0-255):");
            } while (!byte.TryParse(Console.ReadLine(), out nevekSzama));   //do-while, hogyha a felhasználó nem számot akar megadni.

            string[] nevek = new string[nevekSzama];

            for (int i = 0; i < nevek.Length; i++)
            {
                do
                {
                    Console.WriteLine("Add meg a(z) {0}. nevet!", i + 1);
                    nevek[i] = Console.ReadLine();
                } while (nevek[i].Length == 0 || nevek[i][0] == ' ');         //do-while, hogyha nem ír be nevet, és ha szóközzel akarja kezdeni.
            }

            Console.WriteLine("Mi legyen a nevek minimum hossza?");
            byte minHossz = byte.Parse(Console.ReadLine());

            for (int i = 0; i < nevek.Length; i++)
            {
              if (nevek[i].Length >= minHossz)
                  Console.WriteLine(nevek[i]);
            }
            Console.ReadKey();
        }
    }
}
