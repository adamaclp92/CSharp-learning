using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szamologepsz;

namespace Kliens
{
    class Program
    {
        static void Main(string[] args)
        {
            szamologepsz.ISzamologep p2 = (szamologepsz.ISzamologep)Activator.GetObject(typeof(szamologepsz.ISzamologep), "tcp://192.168.0.94:2456/Math");
            int y = p2.osszead(12, 13);
            Console.WriteLine(y);
            Console.WriteLine(p2.osztas(34, 12));
            Console.ReadKey();
        }
    }
}
