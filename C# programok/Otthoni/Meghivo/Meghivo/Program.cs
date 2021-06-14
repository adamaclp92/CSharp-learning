using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meghivo
{
    class Program
    {
       

        static void Main(string[] args)
        {
       
            Console.SetCursorPosition(0, 4);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.SetCursorPosition(13, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ezennel sok szeretettel meghívunk Viki és Ádám esküvőjére!");
            Console.SetCursorPosition(30, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Helyszín és időpont: ");
            Console.SetCursorPosition(35, 12);
            Console.WriteLine("2028.08.19");
            Console.SetCursorPosition(27, 13);
            Console.WriteLine("Kompolt, házasságkötő terem");
            Console.SetCursorPosition(0, 21);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 0);
         
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();

            //innentől a 2. oldal
            Console.SetCursorPosition(35, 5);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Programlista:");
            Console.SetCursorPosition(33, 8);
            Console.WriteLine("blablablablablabla");
            Console.SetCursorPosition(33, 10);
            Console.WriteLine("blablablablablabla");
            Console.SetCursorPosition(33, 12);
            Console.WriteLine("blablablablablabla");
            Console.SetCursorPosition(33, 14);
            Console.WriteLine("blablablablablabla");

            Console.ReadKey();


        }
    }
}

    /*
Konstruáljunk egy bekeretezett meghívót valamely alkalomra (pl. esküvő). 
Az esemény neve és a dátum legyen más színnel írva, mint a keret, és a meghívó szövege (az esemény ismertetése). 
A program szóköz leütése után törölje le a meghívó szövegét, és cserélje fel az esemény programjának ismertetésére. */
