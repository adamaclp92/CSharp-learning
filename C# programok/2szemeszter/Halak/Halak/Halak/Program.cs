using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halak
{

    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            List<Fish> fish = new List<Fish>();

            Fish f = new Fish();
            for (int i = 0; i < 100; i++)
            {

                f.Weight = rnd.NextDouble() * (40.0 - 0.5) + 0.5;

                int herbivorous = rnd.Next(1, 101);
                if (herbivorous > 10)
                {
                    f.Predator = false;
                }
                else f.Predator = true;

                f.Top = rnd.Next(0, 400);
                f.Depth = rnd.Next(10, 400);

                int type = rnd.Next(0, 5);

                if (type == 0)
                    f.FishType = TypeOfFish.busa;

                else if (type == 1)
                    f.FishType = TypeOfFish.harcsa;

                else if (type == 2)
                    f.FishType = TypeOfFish.keszeg;

                else if (type == 3)
                    f.FishType = TypeOfFish.kárász;

                else if (type == 4)
                    f.FishType = TypeOfFish.ponty;



                fish.Add(f);
                Console.WriteLine(f);
            }

            int ragadozo_db = 0;
            foreach (Fish p in fish)
            {
                if (p.Predator) ragadozo_db++;
            }
            Console.WriteLine("ragadozok={0} db, novenyevok={1} db", ragadozo_db, fish.Count - ragadozo_db);
            // ---
            Fish m = fish[0];
            foreach (Fish p in fish)
                if (p.Weight > m.Weight) m = p;
            Console.WriteLine("legsulyosabb hal egy {1}, {0} kg", m.Weight, m.FishType);
            // ---
            int db = 0;
            foreach (Fish p in fish)
                if (p.Top <= 110 && 110 <= p.Top + p.Weight) db++;
            Console.WriteLine("Osszesen {0} db hal képes 110 cm mélységben úszni", db);
            // ---
            List<Fish> N = new List<Fish>(); // megevett novenyevok
            for (int i = 0; i < 100; i++)
            {
                int k = rnd.Next(fish.Count);
                int l = rnd.Next(fish.Count);
                if (k == l) continue;
                Fish p = fish[k];
                Fish r = fish[l];
                if (p.Predator == true && r.Predator == false) talanMegeszi(p, r, fish, N);
                else if (p.Predator == false && r.Predator == true) talanMegeszi(r, p, fish, N);
            }
            Console.WriteLine("osszesen {0} db novenyevot ettek meg", N.Count);
            double sum = 0;
            foreach (Fish p in N)
                sum += p.Weight;
            Console.WriteLine("a megevett novenyevok osszsulya = {0} kg", sum);
            // --
            Console.Write("<Enter> a befejezéshez");
            Console.ReadLine();
        }
        //.......................................................................................................................
        static void talanMegeszi(Fish ragadozo, Fish novenyevo, List<Fish> elok, List<Fish> megettek)
        {
            bool megeszi = false;
            bool benne =
                 (ragadozo.Top <= novenyevo.Top && novenyevo.Top <= ragadozo.Top + ragadozo.Weight)
                  ||
                 (novenyevo.Top <= ragadozo.Top && ragadozo.Top <= novenyevo.Top + novenyevo.Weight);
            if (benne && rnd.Next(1, 100) < 30) megeszi = true;
            if (megeszi)
            {
                elok.Remove(novenyevo);
                megettek.Add(novenyevo);
                ragadozo.Weight = ragadozo.Weight + ragadozo.Weight * 0.08; // 8% plusz




            }
        }
    }
}



/*Egy halat (fish) jellemez, hogy a vízben milyen mélységben szeret úszni. Megadjuk ezen mélység-intervallum (tól-ig) felső határát (top) és mélységét (depth). 
 * Pl. ha top=30, depth=80, akkor a hal nem úszik 30 centinél közelebb a vízfelszínhez, és 1.1m (30cm+80cm=110cm) mélység alá sem úszik. Minden halnak van súlya, 
 * és tároljuk hogy ragadozó-e vagy növényevő.

weight: súlya, tört érték, 0.5 kilótól 40.0 kilóig valid, a hal súlya növekedhet és csökkenhet is, de egyszerre maximum az aktuális halsúly 10% -val
predator: ragadozó-e (vagy növényevő), bool, true/false, ha egyszer beállítottuk, nem módosítható
top: hány cm mélység fölé nem merészkedik, egész, 0cm-től 400cm-ig valid,
depth: hány cm a mozgási sávjának mélysége, egész, 10cm-től 400cm-ig valid
a halfaj (busa, keszeg, stb) string formában kerül tárolásra (most), a hal fajának neve nem lehet null, legalább 3 betű, maximum 30 betű hosszú lehet.

    Készítsünk egy listába

100 db halat,
90% eséllyel növényevőt,
különböző random súllyal és úszási mélységekkel, halfajjal,
írassuk ki a 100 halból hány darab lett végül is a ragadozó, mennyi a növényevő,
mennyi a legnagyobb súlyú hal súlya,
illetve számoljuk meg hány hal képes 1.1m mélységben úszni.
válasszunk random 2 halat, ha az egyik növényevő, a másik ragadozó, és az ragadozó be tud úszni a növényevő sávjába, akkor 30% eséllyel megeszi azt. 
Ekkor a ragadozó hal súlya nőjön meg, és töröljük a listából a növényevőt (100 ismétlés).
a végén írassuk ki a 100 halból hány darab és hány kilónyi növényevő halat ettek meg a ragadozók.
*/