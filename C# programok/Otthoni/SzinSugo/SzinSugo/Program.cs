using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzinSugo
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "kék";
            String b = "sárga";
            String c = "zöld";
            String d = "fehér";
            String e = "piros";
          String f = "Micócicó kunyhója";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0} -- {1}", f, a);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0} -- {1}", f, b);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0} -- {1}", f, c);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0} -- {1}", f, d);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0} -- {1}", f, e);
            Console.ReadLine();
            
           


        }
    }
}
/*Írjon olyan programot, amely a képe,,rnyőre különböző színekkel kiírja a "Micócicó kunyhója" szöveget. 
 * Minden sor végére írja ki a felhasznált szín nevét is.*/