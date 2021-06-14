using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student xyz = new Student("Teszt Elek", new DateTime(1981, 5, 30));

          

            Console.WriteLine("{0}: {1}. ", xyz.Name, xyz.Age);
            Console.ReadKey();
        }
    }
}
