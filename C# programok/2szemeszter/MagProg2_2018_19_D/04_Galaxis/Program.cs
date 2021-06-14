using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_Galaxis
{
    class Program
    {
        static Random rnd = new Random();
        static Galaxis MilkyWay = new Galaxis();

        static void FajlBeolvas(string FajlNeve)
        {
            StreamReader sr = new StreamReader(FajlNeve,
                Encoding.Default);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                if (adatok[0] == "cs") MilkyWay.AddCsillag(
                        adatok[1] == string.Empty ? null : adatok[1],
                        Convert.ToUInt16(adatok[2]),
                        (CsillagOsztaly)Enum.Parse(typeof(CsillagOsztaly), adatok[3]),
                        (float)Convert.ToDouble(adatok[4]));
                else if (adatok[0] == "b") MilkyWay.AddBolygo(
                         adatok[1] == string.Empty ? null : adatok[1],
                         Convert.ToUInt16(adatok[2]),
                         (BolygoOsztaly)Enum.Parse(typeof(BolygoOsztaly), adatok[3]),
                         (float)Convert.ToDouble(adatok[4]));
            }
            sr.Close();
        }

        static void Main(string[] args)
        {
            FajlBeolvas("Egitestek.csv");

            MilkyWay[10].Nev = "WERTZTVF";
            Console.WriteLine(MilkyWay[10]);

            //foreach (var egitest in MilkyWay.Egitestek)
            //{
            //    Console.WriteLine(egitest);
            //}

            //for (int i = 1; i <= 50; i++)
            //{
            //    MilkyWay.AddCsillag(
            //        "Csillag " + i.ToString().PadLeft(3, ' '),
            //        (ushort)rnd.Next(Beallitasok.Default.MaxEgitestEletkor),
            //        (CsillagOsztaly)rnd.Next(6),
            //        (float)(rnd.NextDouble() *
            //            (Beallitasok.Default.MaxCsillagAtmero - Beallitasok.Default.MinCsillagAtmero) +
            //            Beallitasok.Default.MinCsillagAtmero));
            //}

            //MilkyWay[5] = new Csillag("EDE1234", "Halálcsillag 3",
            //    23, CsillagOsztaly.HALAL, 2.56f);
            
            //Console.WriteLine(MilkyWay["E-00012-CS"]);

            //foreach (Csillag csillag in MilkiWay.HasonloCsillagok(MilkiWay.Csillagok[5]))
            //    Console.WriteLine(csillag);

            Console.ReadLine();
        }
    }
}
