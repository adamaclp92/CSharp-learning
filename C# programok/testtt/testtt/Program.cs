using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace testtt
{
	class Program
	{
        static int a=0; static int b=0; static void Main(string[] args)
		{
            a = 12;
            Thread t = new Thread(kiszamol);
            t.Priority = ThreadPriority.Normal;
            t.Start();
            Console.WriteLine(b);
            Console.ReadLine();
		}

        static void kiszamol()
        {
            b = a * 2;
        }

        


	}

}
