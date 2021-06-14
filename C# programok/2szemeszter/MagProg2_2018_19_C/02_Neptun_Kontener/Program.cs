using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Neptun_Kontener
{
    class Program
    {
        static void Kiir(List<Hallgato> Hallgatok)
        {
            foreach (Hallgato hallgato in Hallgatok)
            {
                Console.WriteLine("Id: {0}", hallgato.Id);
                Console.WriteLine("Neptunkód: {0}", hallgato.Neptunkod);
                Console.WriteLine("Név: {0}", hallgato.Nev);
                Console.WriteLine("Születési dátum: {0}", hallgato.SzuletesiDatum.ToShortDateString());
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EKE\n");
            Egyetem EKE = new Egyetem();
            EKE.AddHallgato("Troll Ede", new DateTime(1987, 5, 4));
            EKE.AddHallgato("Geda Gábor", new DateTime(1965, 11, 6));
            EKE.AddHallgato("Keresztes Péter", new DateTime(1973, 4, 12));
            //EKE.Hallgatok.Add(new Hallgato(3, "IKSI78"));
            Kiir(EKE.Hallgatok);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSárospatak\n");
            Egyetem SP = new Egyetem();
            SP.AddHallgato("Király Roland", new DateTime(1976, 7, 16));
            SP.AddHallgato("kovásznai Gergely", new DateTime(1977, 5, 10));
            //EKE.Hallgatok.Add(new Hallgato(3, "IKSI78"));
            Kiir(SP.Hallgatok);


            Console.ReadLine();
        }
    }
}
