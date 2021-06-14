using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferivelgyak
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader file = new StreamReader("Osztalyterem.txt");
            Osztaly osztaly = new Osztaly();



            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(';');

                Person uj;

                switch (data.Length)
                {

                    case 5:
                        uj = new Fiuk(data[0], data[1], int.Parse(data[2]), (Hajszinek)Enum.Parse(typeof(Hajszinek), data[3]), int.Parse(data[4]));
                        break;

                    case 6:
                        uj = new Lanyok(data[0], data[1], int.Parse(data[2]), (Hajszinek)Enum.Parse(typeof(Hajszinek), data[3]), int.Parse(data[4]), (Szemszinek)Enum.Parse(typeof(Szemszinek), data[5]));
                        break;

                    default:
                        throw new Exception("A CSV fájl nem megfelelő");
                }
               osztaly.Hozzaad(uj);
 
            }

            osztaly.listaz();
            Console.WriteLine();
            Console.WriteLine("Csak a fiúk: ");
            foreach (Fiuk f in osztaly.FiukListaz())
            {
                Console.WriteLine(f.VezetekNev + " " + f.KeresztNev);
            }

            Console.WriteLine();

            Console.WriteLine("Köcsög lányok: ");
            foreach (Lanyok l in osztaly.KocsogLanyok())
            {
                Console.WriteLine(l.VezetekNev + " " + l.KeresztNev);
            }

            Console.WriteLine();

            Console.WriteLine("Lányok, ivás után: ");
            foreach (Lanyok l in osztaly.LanyokListaz())
            {
                l.Iszik(40);
                Console.WriteLine(l.VezetekNev + " " + l.KeresztNev + " kedvesség: {0}", l.Kedvesseg);
            }
           

            Console.ReadLine();
        }
    }
}
