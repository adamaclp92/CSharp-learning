using System;
using System.Threading;

namespace SZOP
{
    class Program
    {
        static int a = 0; static int b = 0; static void Main(string[] args)
        {
            a = 12;
            Thread t = new Thread(kiszamol);
            t.Priority = ThreadPriority.Highest;
            t.Start();
            t.Join();
         
    // és fut tovább, ForestGump
      Console.WriteLine(b); //HMMM. Jó lesz ezígy?.


            Console.ReadLine();
        }

        static void kommunikacio()
        {
            Console.WriteLine("Hellot");
        }

        static void kiszamol()
        { b = a * 2; }
    }
}
