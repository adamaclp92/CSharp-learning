using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a következő számot");
            double y = double.Parse(Console.ReadLine());

            if (x < y)
            {
                while (x < y)
                {
                    Console.WriteLine("Növekvő");
                    x = y;
                    Console.WriteLine("Add meg a következő számot");
                    y = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ez már nem növekvő!!!!!!!!!!!!!");
                Console.ReadKey();
            



            else if (x > y)
            {
                while (x > y)
                {
                    Console.WriteLine("Csökkenő");
                    x = y;
                    Console.WriteLine("Add meg a következő számot");

                    y = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ez már nem csökkenő!!!!!!!!!!!!!");
                Console.ReadKey();

            
        }
    }
}