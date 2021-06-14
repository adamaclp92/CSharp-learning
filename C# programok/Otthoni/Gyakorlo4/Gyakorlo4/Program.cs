using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot");
            int a = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add meg a második számot");
            int b = Int32.Parse(Console.ReadLine());
            Console.Clear();
            int kisebb;
            int relativ = 0;
            if (a > b)
                kisebb = b;
            else
                kisebb = a;

            for (int i=1; i <= kisebb; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    relativ++;
                    Console.WriteLine("{0} és {1} közös osztói: {2}", a,b,i);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{0} nem közös osztója {1}-nek és {2}-nek", i,a,b);
                    Console.ReadKey();
                }
            }
            if (relativ == 1)
                Console.WriteLine("A két szám relatív prímek");
            else
                Console.WriteLine("A két szám nem relatív prím");

            Console.ReadKey();
        }
    }
}
