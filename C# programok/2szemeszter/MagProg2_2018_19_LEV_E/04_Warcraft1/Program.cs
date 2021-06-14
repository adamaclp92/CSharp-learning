using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Warcraft1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Absztrakt osztályból nem lehet példányt készíteni
            //Ork o1 = new Ork();
            //o1.Nev = "Munk Falsedrums";
            //o1.Eletero = 30;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("{0} életereje: {1}", o1.Nev, o1.Eletero);
            //Console.WriteLine(o1.Regeneralodik());
            //Console.WriteLine("{0} életereje: {1}", o1.Nev, o1.Eletero);

            Paraszt o2 = new Paraszt();
            o2.Nev = "Mast Hollowtooth";
            o2.Eletero = 30;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n{0} életereje: {1}", o2.Nev, o2.Eletero);
            Console.WriteLine(o2.Regeneralodik());
            Console.WriteLine("{0} életereje: {1}", o2.Nev, o2.Eletero);

            Harcos o3 = new Harcos();
            o3.Nev = "Hon Frostband";
            o3.Eletero = 50;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n{0} életereje: {1}", o3.Nev, o3.Eletero);            
            Console.WriteLine(o3.Regeneralodik());
            Console.WriteLine("{0} életereje: {1}", o3.Nev, o3.Eletero);

            Console.ReadLine();
        }
    }
}
