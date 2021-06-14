using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a számot");
            int a = Int32.Parse(Console.ReadLine());
            
            Console.Clear();
            int oszto = 0;
            for (int i = a; i>1; i--)
            {
                
                if (a % i == 0)
                {
                    oszto++;
                }
                else
                { }

  
            }
            if (oszto == 1)
                Console.WriteLine("A szám nem prím");
            else
                Console.WriteLine("A szám prím");


            Console.ReadKey();

        }
    }
}
