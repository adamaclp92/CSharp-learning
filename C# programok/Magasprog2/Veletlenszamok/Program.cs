using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veletlenszamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tombhossz = rnd.Next(10, 101);  //random szám generálás
            int[] tomb = new int[tombhossz];
            Console.WriteLine("A tömb hossza: {0}", tombhossz);
            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-1000, 1001);
                Console.Write("{0}, ",tomb[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\nA tömb elemei közül a páros számok: ");
            int szam = 0;           //megszámoló változója
            foreach (int x in tomb) //foreach a tömbbejáró ciklus
            {
                if (x % 2 == 0)
                {
                    Console.Write("{0}, ", x);
                    szam++;   //megszámlálás
                }
                
            }
            Console.WriteLine("\n\nÖsszesen {0} darab páros szám van a tömbben.", szam);
            Console.ReadLine();
        }
    }
}
