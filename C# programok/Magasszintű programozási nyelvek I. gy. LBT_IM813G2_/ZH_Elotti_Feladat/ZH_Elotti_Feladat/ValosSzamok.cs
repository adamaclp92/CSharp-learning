using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_Elotti_Feladat
{
    class ValosSzamok
    {
        public ValosSzamok()
        {
            Console.WriteLine("Első feladat");
            Console.WriteLine();

            int darab = 0;
            int Pozitiv = 0;
            int Negativ = 0;

            //felhasználóra váró rész
            do
            {
                Console.WriteLine("Kérek egy valós számot!");
                double szam = Convert.ToDouble(Console.ReadLine());
                if (szam > 0)
                {
                    Pozitiv++;
                }
                if (szam < 0)
                {
                    Negativ++;
                }
                if (szam != 0)
                {
                    darab++;
                }
            } while (darab < 10);

            //kiiratás
            if (Pozitiv >  Negativ)
            {
                Console.WriteLine("A pozítiv számokból van több");
            }
            else if (Pozitiv < Negativ)
            {
                Console.WriteLine("A negatí számokból van több");
            }
            else
            {
                Console.WriteLine("Ugyan annyi van mind a negatív és pozitív számokból");
            }

            Console.WriteLine();
            Console.WriteLine("Folytatáshoz üss le egy gombot a billentyűzeten");
            Console.ReadKey();
        }
    }
}
