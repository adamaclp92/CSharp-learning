using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg=1;
            Console.WriteLine("Add meg a számot!");
                int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a kitevőt!");
            int b = Int32.Parse(Console.ReadLine());
            for (int i = 1; i<=b; i++)
            {
                osszeg = osszeg * a;
                    
                    }
            Console.WriteLine("A szám hatványa: {0}", osszeg);

            Console.ReadKey();
        
        }
    }
}
