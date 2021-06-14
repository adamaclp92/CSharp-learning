using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gladiator> gladiatorok = new List<Gladiator>();

            try
            {
                StreamReader reader = new StreamReader("data.txt");
                while (!reader.EndOfStream)
                {
                    string[] szavak = reader.ReadLine().Split(';');
                    switch (szavak.Length)
                    {
                        case 3:
                            gladiatorok.Add(new KeresztenyGladiator(
                               int.Parse(szavak[0]),
                               int.Parse(szavak[1]),
                               (Eredet)Enum.Parse(typeof(Eredet), szavak[2])
                                ));
                            break;
                        case 4:
                            gladiatorok.Add(new HarciGladiator(
                                int.Parse(szavak[0]),
                               int.Parse(szavak[1]),
                               (Eredet)Enum.Parse(typeof(Eredet), szavak[2]),
                               int.Parse(szavak[3])
                                ));
                            break;
                    }
                }
                reader.Close();
            }

                catch (WrongFightingLoveNumber e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("NEM MEGFELELŐ ÉRTÉK");
                    Console.WriteLine(e.Message);
                }

                catch (WrongYearsNumber e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("NEM MEGFELELŐ SZÁM");
                    Console.WriteLine(e.Message);
                }

                catch (FileNotFoundException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                }

                catch (FormatException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.StackTrace); 
                }

                catch (Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
            }

            for (int i = 0; i < gladiatorok.Count; i++)
            {
                Console.Write(gladiatorok[i]);
                if(gladiatorok[i] is KeresztenyGladiator)
                    Console.WriteLine("\t\t\t" + gladiatorok[i].EletbenVan_e);
               else Console.WriteLine("\t" + gladiatorok[i].EletbenVan_e);
            }
            Random rnd = new Random();

            Console.WriteLine("\n\n------------------------------------------\n\n");
           
            for (int i = 0; i < rnd.Next(5, 20); i++)
            {
                int tamado = rnd.Next(1, gladiatorok.Count);
                int kitTamadMeg = rnd.Next(1, gladiatorok.Count);
                do
                {
                    kitTamadMeg = rnd.Next(1, gladiatorok.Count);

                } while (tamado == kitTamadMeg);

                

                if (gladiatorok[tamado] is HarciGladiator)
                {
                    HarciGladiator g = gladiatorok[tamado] as HarciGladiator;
                    HarciGladiator g2 = gladiatorok[kitTamadMeg] as HarciGladiator;
                    if (g.Megtamad(gladiatorok[kitTamadMeg]))
                    {
                        Console.Write("\n{0} támadta meg {1}. Lezajlott a támadás.", g.Sorszam, gladiatorok[kitTamadMeg].Sorszam);
                        if (gladiatorok[kitTamadMeg] is KeresztenyGladiator)
                        {
                            gladiatorok[kitTamadMeg].EletbenVan_e = false;
                            Console.WriteLine(" {0} a nyertes, {1} meghalt", gladiatorok[tamado].Sorszam, gladiatorok[kitTamadMeg].Sorszam);
                        }
                        else
                        {
                            if (g.Esely > g2.Esely)
                            {
                                g2.EletbenVan_e = false;
                                Console.WriteLine(" {0} a nyertes, {1} meghalt", g.Sorszam, g2.Sorszam);
                            }
                           else if (g.Esely < g2.Esely)
                            {
                                g.EletbenVan_e = false;
                                Console.WriteLine(" {0} a nyertes, {1} meghalt", g2.Sorszam, g.Sorszam);
                            }
                            else Console.WriteLine(" Döntetlen");
                        }
                           
                    }
                    else Console.WriteLine("\n{0} támadta meg {1}. Nem zajlott le a támadás.", g.Sorszam, gladiatorok[kitTamadMeg].Sorszam);
                }
                else if (gladiatorok[tamado] is KeresztenyGladiator)
                {
                    KeresztenyGladiator g = gladiatorok[tamado] as KeresztenyGladiator;
                    Console.WriteLine("\n{0} támadta meg {1}. Nem zajlott le a támadás.", g.Sorszam, gladiatorok[kitTamadMeg].Sorszam);
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < gladiatorok.Count; i++)
            {
                Console.Write(gladiatorok[i]);
                if (gladiatorok[i] is KeresztenyGladiator)
                    Console.WriteLine("\t\t\t" + gladiatorok[i].EletbenVan_e);
               else Console.WriteLine("\t" + gladiatorok[i].EletbenVan_e);
            }

            Console.ReadKey();
        }
    }
}
