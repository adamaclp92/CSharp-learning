using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bevezetes
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------
            Console.Write("Troll Ede");
            Console.Write("\n");
            Console.Write("Troll Ede");

            Console.Write("Troll Ede" + "\n" + "Troll Ede");
            Console.Write("Troll Ede\nTroll Ede");

            Console.WriteLine("Troll Ede");
            Console.WriteLine("Troll Ede");

            //----------------------------------------------------
            Console.WriteLine(3); //3
            Console.WriteLine(3 + 2); //5
            Console.WriteLine(3 + "2"); //32
            Console.WriteLine(3 + "+" + 2); //3+2
            Console.WriteLine(3 + "+" + 2 + "=" + 5); //3+2=5
            Console.WriteLine(3 + "+" + 2 + "=" + 3 + 2); //3+2=32
            Console.WriteLine(3 + "+" + 2 + "=" + (3 + 2)); //3+2=5

            Console.ReadLine();
        }
    }
}
