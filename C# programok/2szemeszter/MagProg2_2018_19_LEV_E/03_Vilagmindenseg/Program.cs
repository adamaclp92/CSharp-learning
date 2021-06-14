using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Ő felel a fájlok írásáért és olvasásáért (többek között)

namespace _03_Vilagmindenseg
{
    class Program
    {
        static Galaxis Tejut = new Galaxis();

        static void FileFeldolgoz(string FileName)
        {
            StreamReader sr = new StreamReader(FileName, Encoding.Default);
            sr.ReadLine(); //Fejléc miatt
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                if (adatok[0] == "cs")
                {
                    Tejut.AddCsillag(
                        adatok[1] == "" ? null : adatok[1],
                        Convert.ToUInt16(adatok[2]),
                        //(EnumNeve)Enum.Parse(typeof(EnumNeve), adat)
                        (CsillagOsztaly)Enum.Parse(typeof(CsillagOsztaly), adatok[3]),
                        (float)Convert.ToDouble(adatok[4]));
                }
                else
                {
                    Tejut.AddBolygo(
                       adatok[1] == "" ? null : adatok[1],
                       Convert.ToUInt16(adatok[2]),
                       (BolygoOsztaly)Enum.Parse(typeof(BolygoOsztaly), adatok[3]),
                       (float)Convert.ToDouble(adatok[4]));
                }
            }

            sr.Close(); //Fontos!! Bezárja a sream-et
        }

        static void Main(string[] args)
        {

            FileFeldolgoz("Egitestek.csv");

            foreach (Egitest egitest in Tejut.Egitestek)
                Console.WriteLine(egitest);

            //Tejut.AddBolygo();
            //Tejut.AddBolygo("Föld", 4543);
            //Tejut.AddBolygo("Mars", 4603, BolygoOsztaly.GAZ, 1.52f);
            //Tejut.AddCsillag();
            //Tejut.AddCsillag("Nap", 4603);
            //Tejut.AddCsillag("Proxima Centauri", 4850, CsillagOsztaly.NEUTRON, 3.42f);

            //Tejut[4] = new Csillag("12345", "Hahaha", 324, 
            //    CsillagOsztaly.NEUTRON, 3.5f);           
            //Console.WriteLine(Tejut[4]);
            //Console.WriteLine(Tejut["E-0000003-B"]);

            ////Összes égitest
            //foreach (Egitest egitest in Tejut.Egitestek)
            //    Console.WriteLine(egitest);

            ////Neutroncsillagok
            //Console.WriteLine("Neutroncsillagok");
            //foreach (Egitest egitest in Tejut.Neutroncsillagok)
            //{
            //    Console.WriteLine(egitest);
            //}

            //Console.WriteLine("\nKőzetbolygók");
            //foreach (Bolygo bolygo in Tejut.AdottOsztalybaTartozoBolygok(BolygoOsztaly.KOZET))
            //{
            //    Console.WriteLine(bolygo);
            //    Console.WriteLine(bolygo.Foldszeru);
            //}           
            Console.ReadLine();
        }
    }
}
