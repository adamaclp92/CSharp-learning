using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husvet
{
    class Sprinkler : Person //a Sprinkler a leszármazott osztály
    {
           ParfumeTypes parfume;
            public ParfumeTypes Parfume
        {
            get { return parfume; }
            private set { parfume = value; }
        }

            double alcoholLevel;
            public double AlcoholLevel
            {
                get { return alcoholLevel; }
                set 
                {
                    if (value < 0)
                        throw new Exception("Nem lehet kisebb, mint 0.");
                    if (value > 100)
                        throw new Exception("Nem lehet nagyobb, mint 100");
                    alcoholLevel = value;
                }
            }

            public bool Smashed
            {
                get
                {
                    return AlcoholLevel >= 40;
                }
            }

            public void Drink(int amount, double percentage)
            {
               double alcoholAmount =  amount * percentage / 100;
               AlcoholLevel += alcoholAmount / 500;
            }

            public Sprinkler(string name, DateTime dateOfBirth, ParfumeTypes parfume, double alcoholLevel) : base (name, dateOfBirth) //konstruktorhívási lánc, a szülőosztály melyik paraméterű konstruktorát hívja le, akkor kell, ha 0 paraméteres hibát ír ki
            {
           //   this.Name = name;                     ezek már a base-ben benne vannak
           //   this.DateOfBirth = dateOfBirth;
                this.Parfume = parfume;
                this.AlcoholLevel = alcoholLevel;
            }

            public override string ToString()
            {
                return string.Format("{0}kölni: {1}, alkoholszint: {2}",base.ToString(), parfume, alcoholLevel);
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