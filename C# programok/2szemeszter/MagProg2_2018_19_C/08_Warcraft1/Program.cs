using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ork o1 = new Ork();
            //o1.Nev = "Garaldok Brightlock";
            //o1.Eletero = 40;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(string.Format("{0} életereje {1}", o1.Nev, o1.Eletero));
            //Console.WriteLine(o1.Regeneralodik());
            //Console.WriteLine(string.Format("{0} életereje {1}", o1.Nev, o1.Eletero));

            OrkParaszt o2 = new OrkParaszt();
            o2.Nev = "Mihlurl Vengesorrow";
            o2.Eletero = 40;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(string.Format("\n{0} életereje {1}", o2.Nev, o2.Eletero));
            Console.WriteLine(o2.Regeneralodik());
            Console.WriteLine(string.Format("{0} életereje {1}", o2.Nev, o2.Eletero));

            OrkHarcos o3 = new OrkHarcos();
            o3.Nev = "Dasgoch Stormfall";
            o3.Eletero = 40;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(string.Format("\n{0} életereje {1}", o3.Nev, o3.Eletero));            
            Console.WriteLine(o3.Regeneralodik());
            Console.WriteLine(string.Format("{0} életereje {1}", o3.Nev, o3.Eletero));

            Console.ReadLine();
        }
    }
}
