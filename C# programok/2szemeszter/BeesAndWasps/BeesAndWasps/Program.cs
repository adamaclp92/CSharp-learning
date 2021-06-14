using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BeesAndWasps
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Virag> viragok = new List<Virag>();
            List<Rovar> rovarok = new List<Rovar>();

            try
            {
                StreamReader reader = new StreamReader("data.txt");
                while (!reader.EndOfStream)
                {
                    string[] szavak = reader.ReadLine().Split(';');
                    switch (szavak[0])
                    {
                        case "virág":
                            viragok.Add(new Virag(
                                szavak[1],
                                int.Parse(szavak[2])
                                ));
                            break;
                        case "darázs":
                            rovarok.Add(new Darazs(
                                szavak[1]
                                ));
                            break;
                        case "méh":
                            rovarok.Add(new Meh(
                               szavak[1]
                                ));
                            break;
                    }
                }
                reader.Close();
            }
            catch (NameTooShortException e)
            {
                // KIVÉTELEK KEZELÉSE
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("HIBA A NÉVBEÁLLÍTÁSNÁL");
                Console.WriteLine(e.Message);
            }

            catch (NegativNumberException e)
            {
                // KIVÉTELEK KEZELÉSE
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("HIBA A NEGATÍV SZÁMOKKAL");
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
                Console.WriteLine(e.StackTrace); //nyomkövető
            }

            catch (Exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("EGYÉB HIBA");
            }
            // BEPORZÁSOK

            // KIIRATÁSOK

            Console.ReadKey();
        }

        /*A BeesAndWasps.zip projektet töltsd le! A Te feladatod azt kiegészíteni!

Tavasz van, tele a rét virágokkal. A méhek gyűjtik a nektárt és közben beporozzák a virágokat. Néha a darazsak is a virágokra tévednek, de nektárt ők nem gyűjtenek.

Virágos rét

Virag osztály:
    Név: legalább 3 karakter. Egyébként dobj saját kivételt!
    Hányszor porozták már be: csak olvasható
    Beporoztak() metódus, mely 1-gyel növeli a beporzások számát
    Mennyi nektár van még a virágban: nemnegatív egész szám (milliliterben). Egyébként dobj saját kivételt!
    NektartAd() metódus, mely egy véletlen értéket levon a nektármennyiségből

IBeporzo interfész:

    Beporoz(x) metódus, ahol x egy virág
    Olyan property/metódus, mely visszaadja, mennyi nektárt gyűjtött már az illető

Rovar absztrakt osztály: (Nem akarunk belőle példányosítani.)

    Név: legalább 3 karakter. Egyébként dobj saját kivételt!

Darazs osztály, mely implementálja az IBeporzo interfészt:

    A darázs nem gyűjt nektárt (vagyis 0 a begyűjtött nektár mennyisége)
    A Beporoz(x) metódus működjön így:
        Meghívja az x Beporoztak metódusát.

Meh osztály, mely implementálja az IBeporzo interfészt:

    Mennyi nektárt gyűjtött már eddig: egész szám (milliliterben)
    A Beporoz(x) metódus működjön így:
        Meghívja az x Beporoztak metódusát.
        Meghívja az x NektartAd metódusát is.
        Eközben kiszámolja, hogy mennyivel csökken az x virágban levő nektár mennyisége: ez lesz a méh által éppen begyűjtött nektár.
        Ezt a különbséget hozzáadja a méh által eddig begyűjtött nektárhoz.

Főprogram:

    A letölthető főprogram beolvassa néhány virágnak, darázsnak és méh-nek az adatait fájlból.
    Kezeld a lehetséges keletkező kivételeket!
    Néhány virágot poroztass be a méhekkel és darazsakkal!
    Írasd ki, hogy:
        Melyik virágot porozták be a legtöbben?
        Összesen mennyi nektárt gyűjtöttek a rovarok?
*/
    }
}
