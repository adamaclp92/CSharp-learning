using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az első számot!");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot!");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a harmadik számot!");
            double c = double.Parse(Console.ReadLine());
            if (a < b && b < c)
                Console.WriteLine("A három szám növekvő sorrendet alkot");
            else if (a > b && b > c)
                Console.WriteLine("A három szám csökkenő sorrendet alkot");
            else if (a == b && b == c)
                Console.WriteLine("A három szám egyenlő");
            else 
                Console.WriteLine("A három szám véletlenszerű sorrendet alkot");
            Console.ReadKey();
        }
    }
}
