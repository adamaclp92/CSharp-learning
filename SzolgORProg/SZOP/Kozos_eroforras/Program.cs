using System;
using System.Threading;

namespace Kozos_eroforras
{
    class Program
    {
        static int[] tomb = new int[1000000]; static int osszeg = 0;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = rnd.Next(100, 200);
            Thread t1 = new Thread(osszeg1);
            t1.Start();
            Thread t2 = new Thread(osszeg2);
            t2.Start();
            t1.Join();
            t2.Join();  //tehát két szál indul el 
            Console.WriteLine("Összeg a két szálon: {0}", osszeg);
            int norm = 0; //mennyi valójában?
            foreach (int x in tomb)
                norm += x;
            Console.WriteLine("Összeg valójában: {0}", norm);
            if (norm != osszeg)
                Console.WriteLine("Hiba van");
            Console.ReadLine();
        }

        static void osszeg1()
        {
                for (int i = 0; i < tomb.Length / 2; i++)  //de ez így nem lesz jó….
                    Interlocked.Add(ref osszeg, tomb[i]);
        }

        static void osszeg2()
        {
                for (int i = tomb.Length / 2; i < tomb.Length; i++) //de ez így nem lesz jó….
                    Interlocked.Add(ref osszeg, tomb[i]);
        }
    }
}
