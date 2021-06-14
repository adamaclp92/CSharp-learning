using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_KettesSzamrendszer_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy háromjegyű kettes " +
                "számrendszer beli számot!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1. számjegy: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int negyes = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("2. számjegy: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int kettes = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("3. számjegy: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int egyes = Convert.ToInt32(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(14, 7);
            Console.WriteLine("A(z) {0}{1}{2} kettes számrendszerbeli szám", 
                negyes, kettes, egyes);
            Console.SetCursorPosition(16, 8);
            Console.WriteLine("tizes számrendszerbeli értéke {0}.",
                negyes * 4 + kettes * 2 + egyes * 1);

            Console.ReadLine();
        }
    }
}
