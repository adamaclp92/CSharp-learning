using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MegszamlalasPontok
{
    class Program
    {
        //Tankönyv 9. feladat
        //Hf.: 10. feladat (megbeszéltük)
        //FÜGGVÉNY HANYPONTVANAKORONKIVUL(P: PONTSOROZAT, O: PONT, R: VALÓS): EGÉSZ;
        //    VÁLTOZÓK
        //        I: EGÉSZ;
        //        DB: EGÉSZ;
        //    ALGOITMUS
        //        DB <- 0;
        //        CIKLUS I <- 1..N
        //            HA (SQRT((P[I].X - O.X) * (P[I].X - O.X) + (P[I].Y - O.Y) * (P[I].Y - O.Y)) > R) AKKOR
        //                DB <- DB + 1;
        //            HA_VÉGE;
        //        CIKLUS_VÉGE;
        //FÜGGVÉNY_VÉGE;
        static int HanyPontVanAKoronKivul(Pont[] Pontok, Pont O, double r)
        {
            int db = 0;
            for (int i = 0; i < Pontok.Length; i++)
            {
                if (Math.Sqrt((Pontok[i].x - O.x) * (Pontok[i].x - O.x) +
                    (Pontok[i].y - O.y) * (Pontok[i].y - O.y)) > r)
                    db++;
            }
            return db;
        }


        //Hf.: 10. feladat (megbeszéltük)
        //FÜGGVÉNY HANYPONTVANAKORONKIVUL(P: PONTSOROZAT, O: PONT, R: VALÓS): EGÉSZ;
        //    VÁLTOZÓK
        //        I: EGÉSZ;
        //        DB: EGÉSZ;
        //    ALGOITMUS
        //        DB <- 0;
        //        CIKLUS I <- 1..N
        //            HA (SQRT((P[I].X - O.X) * (P[I].X - O.X) + (P[I].Y - O.Y) * (P[I].Y - O.Y)) > R) AKKOR
        //                DB <- DB + 1;
        //            HA_VÉGE;
        //        CIKLUS_VÉGE;
        //FÜGGVÉNY_VÉGE;
        static int HanyDnelHosszabbOldal(Pont[] Csucsok, double d)
        {
            int db = 0;
            for (int i = 0; i < Csucsok.Length; i++)
            {
                if (Math.Sqrt((Csucsok[i-1].x - Csucsok[i].x) * (Csucsok[i - 1].x - Csucsok[i].x) +
                    (Csucsok[i - 1].y - Csucsok[i].y) * (Csucsok[i - 1].y - Csucsok[i].y)) > d)
                    db++;
            }
            return db;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Pont[] csucsok = new Pont[5];

            for (int i = 0; i < csucsok.Length; i++)
            {
                csucsok[i].x = rnd.Next(1, 10);
                csucsok[i].y = rnd.Next(1, 10);
                Console.WriteLine("{0}. csúcs X: {1}", i, csucsok[i].x);
                Console.WriteLine("{0}. csúcs X: {1}", i, csucsok[i].y);
            }

            int d = HanyDnelHosszabbOldal(csucsok, 5);
            Console.WriteLine("{0}-nél hosszabb olalak száma: {1}", 5, d);
            
        }
    }
}
