using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Szalak_2
{
    class Program
    {
        private static ManualResetEvent mre = new ManualResetEvent(false);
        private static ManualResetEvent _shutdownEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("\n 1 szál indul");
            Thread t = new Thread(ThreadProc); t.Name = "Thread_1"; t.Start();
            Console.ReadLine();
            mre.Set();
            Console.WriteLine("Elindult?"); Console.ReadLine();
            mre.Reset();
            Console.WriteLine("Megállt, indítsam?"); Console.ReadLine();
            mre.Set();
            Console.WriteLine("Vége?"); Console.ReadLine();
            _shutdownEvent.Set(); t.Join();
            Console.ReadLine();
            

       

        }

        private static void ThreadProc()
        {
            
            string name = Thread.CurrentThread.Name;

            while (true)
            {
                Console.WriteLine(name + " start");
                mre.WaitOne(Timeout.Infinite);
                if (_shutdownEvent.WaitOne(0))
                    break;
            }
        }
    }
}
