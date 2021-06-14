using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasprog2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömbök

            int[] tomb = new int[20];
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = (i + 1) * 5;
                Console.Write("{0}, ", tomb[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Adj meg egy számot!");
            int beker = int.Parse(Console.ReadLine());
            Console.WriteLine("A bekért számmal és 5-tel osztható számok 100-ig:");
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % beker == 0)
                {
                    Console.Write("{0}, ", tomb[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
