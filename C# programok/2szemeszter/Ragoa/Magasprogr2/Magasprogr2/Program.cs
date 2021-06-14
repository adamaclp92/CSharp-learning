using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasprogr2
{


    class Program
    {
        static Random rnd = new Random();

        static UralkodoGyujto LetrehozEsFeltolt()
        {
            UralkodoGyujto uralkodok = new UralkodoGyujto();

            for (int i = 0; i < 30; i++)
            {
                Uralkodo ujUralkodo = new Uralkodo(
                rnd.Next(-10000, DateTime.Today.Year + 1),
                (byte)rnd.Next(0, 80),
                (byte)rnd.Next(0, 11));

                uralkodok.Hozzaad(ujUralkodo);
                //hozzáadni a konténerobjektumhoz
            }
            return uralkodok;
        }

        static void Kiir(Uralkodo[] uralkodok)
        { 
            foreach (Uralkodo u in uralkodok)
            {
                Console.WriteLine(u.ToString());  //példányosítás
            }
        }
        static void Main(string[] args)
        {
            UralkodoGyujto uralkodok = LetrehozEsFeltolt();

            // Kiir(uralkodok);

            for (int i = 0; i < uralkodok.UralkodokSzama; i++)
            {
                for (int j = i + 1; j < uralkodok.UralkodokSzama; j++)
                {
                    if (uralkodok[i].Atfed(uralkodok[j]))
                    {
                        Console.WriteLine("Átfedés!");
                       Console.WriteLine(uralkodok[i]);   //példányosítás
                       Console.WriteLine(uralkodok[j]);  //példányosítás
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


/*Egy uralkodót jellemez uralkodásának kezdete (év), hossza (években), és a nép elégedettsége (0..10 skálaérték, 0=zsarnok gyűlölt uralkodó, 10=kedvelt jóságos és igazságos).
 * Készítsünk véletlen értékekkel inicializált listát 30 uralkodóval. 
 * Határozzuk meg a leghosszabban uralkodó királyunk adatait, valamint hogy van-e átfedés az uralkodások között (valaki még uralkodása folyamatban volt, mikor egy másik is elkezdte az uralkodását).
 * Írassuk ki az átfedő uralkodások adatait egymás mellé a képernyőre. */