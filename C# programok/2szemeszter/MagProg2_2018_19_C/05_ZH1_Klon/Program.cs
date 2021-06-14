using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ZH1_Klon
{
    class Program
    {
        static void Main(string[] args)
        {
            Ezred Zsivanyok = new Ezred(false);

            //Feltöltjük adatokkal

            Console.WriteLine("Az ezredben {0} tiszt van.",
                Zsivanyok.TisztekSzama);

            Pilota LegjobbSofor = Zsivanyok.Pilotak.FirstOrDefault();
            if (LegjobbSofor != null)
                foreach (Pilota p in Zsivanyok.Pilotak)
                {
                    if (p.BalesetekSzama < LegjobbSofor.BalesetekSzama)
                        LegjobbSofor = p;
                }
            Console.WriteLine(LegjobbSofor);

            Console.ReadLine();
        }
    }
}
