using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    class Program
    {
        static void Kiir(List<Konyv> Konyvek)
        {
            foreach (Konyv konyv in Konyvek)
            {
                Console.WriteLine(konyv.Id);
                Console.WriteLine(konyv.Szerzo);
                Console.WriteLine(konyv.Cim);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            
            Konyvesbolt Libri1 = new Konyvesbolt();
            Konyvesbolt Libri2 = new Konyvesbolt();

            Libri1.HozzaadKonyv("Robert Charles Wilson", "Pörgés");
            Libri1.HozzaadKonyv("Szabó Magda", "Ajtó");
            Libri2.HozzaadKonyv("Stanislaw Lem", "Solaris");
            Libri1.HozzaadKonyv("Dan Simmons", "Hyperion");
            Libri1.Konyvek.Add(new Konyv(9999, "Veres Attila", "Odakint sötétebb"));
            Libri2.HozzaadKonyv("Arkagyij és Borisz Sztrugackij", "STALKER");
            Libri2.HozzaadKonyv("Atrhur C. Clarke", "2001 Űrodüsszeia");

            Console.WriteLine("Libri a plázában");
            Kiir(Libri1.Konyvek);            

            Console.WriteLine("\nLibri a valahol");
            Kiir(Libri2.Konyvek);

            Console.ReadLine();
        }
    }
}
