using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            haromszog h = new haromszog(3, 4, 5);
            Console.WriteLine(h.kerulet());
            Console.ReadLine();
        }
    }

    class haromszog
    {
        private int a;
        private int b;
        private int c;

        public float kerulet()
        {
            return a + b + c;
        }

        public haromszog(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

    }


}
