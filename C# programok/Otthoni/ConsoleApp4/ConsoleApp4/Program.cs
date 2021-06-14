using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az 'a' értékét!");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a 'b' értékét!");
            int b = Int32.Parse(Console.ReadLine());
            Console.Clear();
           
            if (a>b)
            {
                int c = a;
                a = b;
                b = c;
            }

            double osszeg = 0;
            for (int i = a; i <= b;  )
            {

                double szorzat = Math.Pow(i, 2);
                osszeg = osszeg+ szorzat;
                
                Console.WriteLine("{0} négyzete = {1}", i, szorzat);
                i = i + 1;
                
                
            }
            Console.WriteLine("A számok összege = {0}", osszeg);
            Console.ReadKey();
        }
    }
}
