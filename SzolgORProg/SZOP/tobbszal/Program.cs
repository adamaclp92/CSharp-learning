using System;
using System.Threading;


namespace tobbszal
{
    class Program
    {
        private static ManualResetEvent mre = new ManualResetEvent(false);
        private static ManualResetEvent _shutdownEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {

            Console.WriteLine("\n 1 szál indul");
            Thread t = new Thread(ThreadProc);
            t.Name = "Thread_1";
            t.Start();
            Console.ReadLine(); //a process itt megáll, a szál is áll
            mre.Set();
            Console.WriteLine("Elindult?");
            Console.ReadLine(); //most látszik a szál fut
            mre.Reset(); //megállítjuk
            Console.WriteLine("Megállt, indítsam?");
            Console.ReadLine();
            mre.Set();
            Console.WriteLine("Vége");
            Console.ReadLine();
            _shutdownEvent.Set(); t.Join();  //megvárjuk a leállás
            

        }

        private static void ThreadProc()
        {
            string name = Thread.CurrentThread.Name;
            while (true)
            {
                Console.WriteLine(name + " starts");
                mre.WaitOne(Timeout.Infinite); //jelzésig felfüggeszti a futást
                if (_shutdownEvent.WaitOne(0))
                    break;
            }
        }


    }
}
