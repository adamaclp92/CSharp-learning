using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uralkodok
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
                    rnd.Next(-5000, DateTime.Today.Year + 1),
                    (byte)rnd.Next(1, 70),
                    (byte)rnd.Next(0, 11));

                uralkodok.Hozzaad(ujUralkodo);
            }

            return uralkodok;
        }

        static void Kiir(UralkodoGyujto uralkodok)
        {
            for (int i = 0; i < uralkodok.UralkodokSzama; i++)
            {
                Console.WriteLine(uralkodok[i]);
            }
        }

        static void Main(string[] args)
        {
            UralkodoGyujto uralkodok = LetrehozEsFeltolt();

            Kiir(uralkodok);

            for (int i = 0; i < uralkodok.UralkodokSzama; i++)
            {
                for (int j = i + 1; j < uralkodok.UralkodokSzama; j++)
                {
                    if (uralkodok[i].Atfed(uralkodok[j]))
                    {
                        Console.WriteLine("Átfedés!");
                        Console.WriteLine(uralkodok[i]);
                        Console.WriteLine(uralkodok[j]);
                    }
                }
                
            }

            Console.ReadKey();
        }
    }
}
