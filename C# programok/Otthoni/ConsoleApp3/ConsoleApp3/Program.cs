using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int osszeg = 0;
            for (int i = 1;i<=20; i++)
            {
               a= a + 2;
                osszeg = osszeg + a;
                Console.Write("+{0}", a);
            }
            Console.WriteLine("={0}", osszeg);


            
                Console.ReadKey();
        

        }
    }
}
