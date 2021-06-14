using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutya
{
    class Program
    {
        static void Main(string[] args)
        {
            List<kutya> kutyak = new List<kutya>();

            kutya eb = new kutya("Masni", 2);
            kutya eb2 = new kutya("Zokni", 5);

            kutyak.Add(eb);
            kutyak.Add(eb2);

            foreach (kutya kuty in kutyak)
            {
                Console.WriteLine(kuty);
            }

            Console.ReadLine();
        }
    }
}
