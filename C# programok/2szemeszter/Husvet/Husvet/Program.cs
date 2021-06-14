using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Husvet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub pub = new Pub();

            StreamReader file = new StreamReader("pub.txt");

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(';');

                Person p; //mivel a sprinkler is person, ezért mind2 esetnél hozzá lehet adni az embert

                switch (data.Length)
                { 
                    case 2:
                         p = new Person(data[0], DateTime.Parse(data[1]));

                        break;

                    case 4:
                        p = new Sprinkler(data[0], DateTime.Parse(data[1]), (ParfumeTypes)Enum.Parse(typeof(ParfumeTypes), data[2]), double.Parse(data[3]));  //az enumot kasztolni kell, és a typeof metódussal az 1. érték az enum típus, a 2. pedig amit akarunk parszolni
                        break;

                    default:
                        throw new Exception("A CSV fájl nem megfelelő");
                }
                pub.Add(p);
            }

          foreach(Sprinkler s in pub.PersonsWithParfume(ParfumeTypes.Violet))
          {
            
                Console.WriteLine(s);
          }

            Console.ReadKey();
        }
    }
}


/*Egy embert jellemeznek a következő adatai:

    neve: legalább 3 karakter hosszú

    születési dátuma: legyen a mai dátumnál korábbi

    életkor property: a születési dátumból és a mai dátumból számolódik

Egy locsolkodót (mint embert) jellemezzenek még a következő adatok:

    milyen típusú kölnije van: pacsuli, ibolyaillatú, Britney Spears stb.

    testtömege hány %-ának megfelelő alkoholt ivott már: 0 és 100 között, tört szám is lehet
    iszik metódus:
        2 paramétere van: az elfogyasztott ital mennyisége gramban (pl. 500) és az adott ital alkoholtartalma százalékban (pl. 4,8)
        számolja ki, hogy hány gram alkohol van ténylegesen az italban
        ossza be 500-zal, majd ezzel növelje meg az előző mezőt

    vállalhatatlan részegség property-je: logikai érték, mely igaz, ha az alkoholszázalék eléri a 40-et

A kocsmában húsvétkor összegyűlnek az emberek, azaz nyilvántartjuk a kocsmában összegyűlt emberek listáját.

    Írj property-t, mely visszaadja a kocsmában összegyűlt locsolkodók számát!

    Írj metódust, mely visszaadja a kocsmából azokat az embereket, akiknek a paraméterként megadott típusú kölni van a zsebében!

Írj főprogramot, mely:

    Létrehoz egy kocsma példányt.

    Feltölti a kocsmát egy szöveges fájlból emberekkel (köztük locsolkodókkal is). A szöveges fájlt is Te rakd össze!

    Kiírja a képernyőre azoknak az embereknek az adatait, akiknek ibolyaillatú kölni van a zsebében (ehhez használd a kocsma megfelelő metódusát) és már vállalhatatlanul részegek (ehhez használd a locsolkodó megfelelő property-jét).

*/