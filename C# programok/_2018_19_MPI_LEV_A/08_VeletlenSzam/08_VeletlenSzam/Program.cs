using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_VeletlenSzam
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int elso = rnd.Next();
            Console.WriteLine("Pozitív egész: {0}", elso);

            int masodik = rnd.Next(25);
            Console.WriteLine("Pozitív egész [0; 25)-ból: {0}", masodik);

            int harmadik = rnd.Next(-25, 75);
            Console.WriteLine("Pozitív egész [-25; 75)-ból: {0}", harmadik);

            int negyedik = rnd.Next(10, 25) * 2;
            Console.WriteLine("Pozitív páros egész [20; 50)-ból: {0}", negyedik);

            int otodik = rnd.Next(50, 200) * 10000;
            Console.WriteLine("10.000-rel osztható egész az [500.000; 2.000.000)-ból: {0}", otodik);

            double hatodik = rnd.NextDouble();
            Console.WriteLine("Valós szám a [0; 1)-ból: {0}", hatodik);

            double min = 2.3;
            double max = 4.7;
            double hetedik = rnd.NextDouble() * (max - min) + min;
            Console.WriteLine("Valós szám a [2,3; 4,7)-ből: {0}", hetedik);

            Console.ReadLine();

        }
    }
}
