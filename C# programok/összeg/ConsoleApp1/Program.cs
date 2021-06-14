using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int osszeg = 0;
            int i = 0;
            int min = 100;
            int max = 0;
            Boolean paros = false;
            while ((osszeg<100) && (i<10))
            {
                Console.WriteLine("kérem az {0}. számot", i+1);
                int szam = int.Parse(Console.ReadLine());
                if ((szam % 2) == 0) paros = true;
                if (szam > 0) osszeg = osszeg + szam;
                if (szam > max) max = szam;
                if (szam < min) min = szam;
                i = i + 1;
            }

            Console.WriteLine("A számok összege:{0}",osszeg);
            Console.WriteLine("A legkisebb beírt szám:{0}",min);
            Console.WriteLine("A legnagyobb beírt szám:{0}",max);
            if (paros) Console.WriteLine("Volt páros");
            else Console.WriteLine("Nem volt páros");
            Console.ReadKey();
            

        }
    }
}
