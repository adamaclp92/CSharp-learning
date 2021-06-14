using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorló
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gondolj egy négyszögre");
            Console.ReadKey();

            

           double e = Math.Min(a, b);
           double f = Math.Min(c, d);
           double g = Math.Max(e, f);
            Console.WriteLine("A páronkénti minimumok maximuma: {0}", g);
                

            Console.ReadKey();
        }
    }
}
