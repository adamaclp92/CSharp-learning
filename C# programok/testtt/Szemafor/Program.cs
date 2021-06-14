using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Szemafor
{
    class Program
    {

        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);

        static void szal()
        {
            Console.WriteLine("{0} várakozik a belépésre", 
                Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} belépett a kritikus szakaszba",
               Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Console.WriteLine("{0} kilépett a kritikus szakaszból",
                Thread.CurrentThread.Name);
            sem.Release();
        }


        static void Main(string[] args)
        {
            for (int i = 0; i <10; i++)
            {
                threads[i] = new Thread(szal);
                threads[i].Name = "Szál_" + i;
                threads[i].Start();
                
            }
            Console.ReadLine();
        }
    }
}
