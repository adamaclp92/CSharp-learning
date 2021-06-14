using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husvet
{
    class Person
    {
         
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3)
                { name = value; }
                else throw new Exception("Túl rövid a név.");
            }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
           protected set   //a protected a gyerekosztályban is elérhető, a private csak a saját osztályban
            {
                if (value > DateTime.Today)
                { throw new Exception("A születési dátum legyen korábbi a mai dátumnál"); }
                else dateOfBirth = value; 
            }
        }

        //származtatott property, nem kell a konstruktorhoz írni, mert ez automatikiusan számítódik az életkorból
        public int Age
        {
            get
            {
                return (int)((DateTime.Today - dateOfBirth).TotalDays / 365.242199);
            }
        }

        public Person(string name, DateTime dateOfBirth) //konstruktor
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return string.Format("{0}, született: {1}, életkora: {2}, ", Name, DateOfBirth, Age);  //az adatok egy stringbe való konvertálása
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