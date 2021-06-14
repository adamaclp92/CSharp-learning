using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonyilvantarto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tipusok = new List<string>();
            List<double> gyorsulasok = new List<double>();
            string tipus = "";
            do
            {
                Console.WriteLine("Kérek egy típus nevet");
                tipus = Console.ReadLine();
                if (tipus != "")
                {
                    try
                    {
                        tipusok.Add(tipus);
                        Console.WriteLine("Hány mp alatt gyorsul 0-100km/h?");
                        gyorsulasok.Add(Convert.ToDouble(Console.ReadLine()));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nem számot adtál meg gyorsulásnak");
                    }

                }
                else
                    break;
            } while (tipus != "");
            if (gyorsulasok.Count != 0)
            {
                Console.WriteLine(Leggyorsabb(gyorsulasok, tipusok));
                Console.WriteLine();
                Console.WriteLine(Leglassabb(gyorsulasok, tipusok));
                Console.WriteLine();
                Console.WriteLine("Az átlagos gyorsulás: {0}", Atlag(gyorsulasok));
            }
            Console.ReadKey();
        }

        private static string Leggyorsabb(List<double> gyorsulasok, List<string> tipusok)
        {
            string leggyorsabbTipus = tipusok[0];
            double leggyorsabb = gyorsulasok[0];
            int index = 0;

            for (int i = 0; i < gyorsulasok.Count; i++)
            {
                if (leggyorsabb > gyorsulasok[i])
                {
                    leggyorsabbTipus = tipusok[i];
                    leggyorsabb = gyorsulasok[i];
                    index = gyorsulasok.IndexOf(leggyorsabb);
                }
            }
            return "A legygyorsabb auto típusa: " + leggyorsabbTipus + " gyorsulása: "+ leggyorsabb + " és indexe: " + index;
        }
        private static string Leglassabb(List<double> gyorsulasok, List<string> tipusok)
        {
            string leglassabbTipus = tipusok[0];
            double leglassabb = gyorsulasok[0];
            int index = 0;

            for (int i = 0; i < gyorsulasok.Count; i++)
            {
                if (leglassabb < gyorsulasok[i])
                {
                    leglassabbTipus = tipusok[i];
                    leglassabb = gyorsulasok[i];
                    index = gyorsulasok.IndexOf(leglassabb);
                }
            }
            return "A leglassabb auto típusa: " + leglassabbTipus + " gyorsulása: " + leglassabb + " és indexe: " + index;
        }
        private static string Atlag(List<double> gyorsulasok)
        {
            double atlag = 0;
            for (int i = 0; i < gyorsulasok.Count; i++)
            {
                atlag += gyorsulasok[i];
            }
            return string.Format("{0:N2}", atlag / gyorsulasok.Count);
        }
    }
}
