using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Szalak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A főprogram itt indul");
            Thread t = new Thread(Szal); t.Start();
            Thread.Sleep(2000);
            Console.WriteLine("Letelt a 2 másodperc a szálban, a szálat felfüggesztjük");
            t.Suspend();
            Thread.Sleep(2000); // a főprogram megáll
            Console.WriteLine("Letelt a 2 másodperc a szálban, a szálat újraindítjuk");
            t.Resume();
            t.Join();
            Console.WriteLine("Program vége");
            Console.ReadLine();


        }

        public static void Szal()
        {
            Console.WriteLine("Ez a szálprogram");
            Thread.Sleep(1000);
            Console.WriteLine("Letelt az 1 másodperc a szálban");
            Thread.Sleep(5000);
            Console.WriteLine("Letelt az 5 másodperc a szálban");
            Console.WriteLine("Szál vége");
            Console.ReadLine();

        }
    }
}
