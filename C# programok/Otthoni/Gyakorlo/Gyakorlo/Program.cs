using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az 1. számot.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az 1. számot.");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az 1. számot.");
            int z = int.Parse(Console.ReadLine());

            if (x > y && y > z)
                Console.WriteLine("A számok növekvő sorrendben: {0}, {1}, {2}", z, y, x);
            if (x < y && y < z)
                Console.WriteLine("A számok növekvő sorrendben: {0}, {1}, {2}", x, y, z);
            if (x < y && y > z && x > z)
                Console.WriteLine("A számok növekvő sorrendben: {0}, {1}, {2}", z, x, y);
            if (x < y && y > z && x < z)
                Console.WriteLine("A számok növekvő sorrendben: {0}, {1}, {2}", x, z, y);
            if (x > y && x > z && y < z)
                Console.WriteLine("A számok növekvő sorrendben: {0}, {1}, {2}", y, z, x);
            if (x > y && x < z && y < z)
                Console.WriteLine("A számok növekvő sorrendben: {0}, {1}, {2}", y, x, z);

            Console.ReadKey();
        }
    }
}
