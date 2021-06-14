using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double x1, x2;
            Console.WriteLine("Add meg az a-t");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Ez nem lehet másodfokú egyenlet");
            }
            else
            {
                Console.WriteLine("Add meg a b-t");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Add meg a c-t");
                c = double.Parse(Console.ReadLine());
                d = b * b - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine("Nincs valós megoldás");
                }
                else
                {
                    x1 = -b + Math.Sqrt(d) / 2 * a * c;
                    Console.WriteLine("X1 = {0}", x1);
                    x2 = -b - Math.Sqrt(d) / 2 * a * c;
                    Console.WriteLine("X1 = {0}", x2);
                }
            }
            Console.ReadKey();


        }
    }
}
