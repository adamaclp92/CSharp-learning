using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Neptun
{
    class Program
    {
        static void Kiir(Diak diak)
        {
            Console.WriteLine("Név: {0}", diak.Nev);
            Console.WriteLine("Neptunkód: {0}", diak.Neptunkod);
            Console.WriteLine("Születési dátum: {0}",
                diak.SzuletesiDatum.ToString("yyyy.MM.dd"));
            Console.WriteLine("Nem: {0}", diak.Nem);
            Console.WriteLine("Kreditek: {0}", diak.Kreditek);
            Console.WriteLine();
        }

        static List<Diak> Diakok = new List<Diak>();

        static void Main(string[] args)
        {
            Diak diak = new Diak("IKSI78");
            diak.Nev = "Troll Ede";
            //diak.Neptunkod = "IKSI78";
            diak.SzuletesiDatum = new DateTime(1987, 5, 4);
            diak.Nem = NemiIdentitas.FERFI;
            diak.Kreditek = 180;
            Diakok.Add(diak);

            diak = new Diak("X666XX", "Geda Gábor", new DateTime(1956, 10, 23));
            //diak.Nev = "Geda Gábor";
            //diak.Neptunkod = "X666XX";
            //diak.SzuletesiDatum = new DateTime(1956, 10, 23);
            diak.Nem = NemiIdentitas.FERFI;
            diak.Kreditek = 18;
            Diakok.Add(diak);

            diak = new Diak("qwerty");
            diak.Nev = "BiróCsaba";
            //diak.Neptunkod = "qwerty";
            diak.SzuletesiDatum = new DateTime(1980, 6, 12);
            //diak.SzuletesiDatum = new DateTime(1980, 6, 12);
            diak.Nem = NemiIdentitas.NONBINARY;
            diak.Kreditek = 160;
            Diakok.Add(diak);

            //Kiir(diak);
            //Kiir(diak2);

            //diak.Kiir();
            //diak2.Kiir();

            //Console.WriteLine(diak.DiakString());
            //Console.WriteLine(diak2.DiakString());

            //Console.WriteLine(diak);
            //Console.WriteLine(diak2);

            foreach (Diak tanulo in Diakok)
            {
                Console.WriteLine(tanulo);
            }
            //for (int i = 0; i < Diakok.Count; i++)
            //{
            //    Diak tanulo = Diakok[i];
            //}

            Console.ReadLine();
        }
    }
}
