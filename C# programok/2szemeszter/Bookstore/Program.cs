using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aru> aruk = new List<Aru>();

            StreamReader reader = new StreamReader("aruk.txt");
            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] szavak = sor.Split(';');
                try
                {
                    if (szavak.Length == 4)
                        aruk.Add(new Konyv(
                            szavak[0],
                            szavak[1],
                            szavak[2],
                            int.Parse(szavak[3])
                            ));
                    else
                        aruk.Add(new CD(
                            szavak[0],
                            szavak[1],
                            szavak[2]
                            ));
                }
               
                catch (IdTooLongException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("NEM MEGFELELŐ AZONOSÍTÓ");
                    Console.WriteLine(e.Message);
                }

                catch (TooShortException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("TÚL RÖVID ELEM");
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
            }
            
            reader.Close();

            Random rnd = new Random();
            int akciosKonyvek = 0;
            int oldalszamokOsszesen = 0;
            int arulhatoCD = 0;

            for (int i = 0; i < aruk.Count; i++)
            {
                Console.Write(aruk[i]);
                if (aruk[i] is Konyv)
                {
                    Konyv k = aruk[i] as Konyv;
                    k.Beleolvas(k);
                    k.HanyanOlvastakBele *= rnd.Next(1, 2000);
                    Console.WriteLine("\tEbbe a könyvbe {0} alkalommal olvastak bele.", k.HanyanOlvastakBele);
                    if (k.Learazhato_e(k))
                    {
                        akciosKonyvek++;
                        oldalszamokOsszesen += k.Oldalszam;
                    }
                }

                else 
                {
                    CD k = aruk[i] as CD;
                    k.Belehallgat(k);
                    k.HanyanHallgattakBele *= rnd.Next(1, 1000);
                    Console.WriteLine("\tEbbe a dalba {0} alkalommal hallgattak bele.", k.HanyanHallgattakBele);
                    if (!(k.Leselejtezheto_e(k)))
                        arulhatoCD++;
                }
            }

            Console.WriteLine("\n\nAz akciós könyvek száma: {0}, ezeknek az össz oldalszáma: {1}", akciosKonyvek, oldalszamokOsszesen);
            Console.WriteLine("Árulható CD-k száma: {0}", arulhatoCD);

            Console.ReadKey();
        }
    }
}

