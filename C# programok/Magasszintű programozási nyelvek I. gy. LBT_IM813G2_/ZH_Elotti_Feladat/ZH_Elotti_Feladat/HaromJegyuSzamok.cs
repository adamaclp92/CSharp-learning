using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_Elotti_Feladat
{
    class HaromJegyuSzamok
    {
        public HaromJegyuSzamok()
        {
            Console.WriteLine("Második feladat");
            Console.WriteLine();

            Random rand = new Random();
            int[] szamok = new int[40];
            int FelhaszSzam = 0;
            int darab = 0;

            //tömb feltöltés
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(100, 1000);
            }

            //kiiratás
            for (int i = 0; i < szamok.Length; i++)
            {
                if (i == szamok.Length - 1)
                {
                    Console.Write("{0}", szamok[i]);
                }
                else
                {
                    Console.Write("{0} ,", szamok[i]);
                }
            }
            Console.WriteLine();
            
            //felhasználóra váró rész
            do
            {
                Console.WriteLine("Kérek egy 3 jegyű számot.");
                FelhaszSzam = Convert.ToInt32(Console.ReadLine());
            } while (FelhaszSzam < 100 || FelhaszSzam > 1000);

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] >= FelhaszSzam - 50 && szamok[i] <= FelhaszSzam + 50)
                {
                    darab++;
                }
            }
            Console.WriteLine("Ennyi szám esik közé {0}", darab);

            Console.WriteLine();
            Console.WriteLine("Folytatáshoz üss le egy gombot a billentyűzeten");
            Console.ReadKey();
        }
    }
}
