using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int hely;
            int[] tomb = new int[10];
            int[] tomb2 = new int[5];
            int[] tomb3 = new int[7] { 1, 2, 4, 6, 7, 8, 9 };
            tomb2[0] = 1;
            tomb2[1] = 2;
            tomb2[2] = 5;
            tomb2[3] = 7;

            int[] a = new int[7] { 1, 3, 4, 5, 6, 9, 10 };
            int[] b = new int[5] { 2, 3, 5, 7, 8 };
            int[] c = new int[12];

            List<int> lista = new List<int>();

            //Lnko();
            TombfeltoltEsKiirat(tomb);
            /* Sum(tomb);
             Megszamlalas(tomb);
             Eldontes(tomb);
             Linker(tomb);
             Kivalasztas(tomb, out hely);
             StrazsasKer(tomb2, out hely);
             RendezettLinearis(tomb3, 9);
             BinKer(tomb3, 5);

             lista = Kivalogatas(tomb, lista);
             ListaKiir(lista);

             Console.WriteLine("Minumumhely és érték: A tömb ezen a pozíción levő eleme a legkisebb: {0}, értéke: {1} -- (utolsó előfordulás)", MinimumHely(tomb) + 1, MinimumE(tomb));
             Console.WriteLine("Maximumhely és érték: A tömb ezen a pozíción levő eleme a legnagyobb: {0}, értéke: {1}", MaximumHely(tomb) + 1, MaximumE(tomb));

             //KozvetlenRend(tomb);*/

            /* Console.WriteLine("Közvetlen kiválasztásos rendezés rekurzívan:");
             RekurKözv(tomb, 0);
             Tombkiirat(tomb);*/

/*
            Console.WriteLine("Minimum kiválasztásos rendezés rekurzívan:");
            RekMinimumkivRend(tomb, 0);
            Tombkiirat(tomb);*/



             /*MinimumkivRend(tomb);
             BuborekRend(tomb);
             BuborekJ1(tomb);*/
             Buborekrendj2(tomb);
            // BesziroRend(tomb);
            // ShellMinRend(tomb);
            // KoktelRend(tomb);
           // Osszefuttatas(a, b, c);
            Console.ReadLine();
        }

        static int Lnko()
        {
            Console.WriteLine("Add meg az A-t:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a B-t");
            int b = int.Parse(Console.ReadLine());
            int r = 0;
            if (a < b)
            {
                int x = a;
                a = b;
                b = x;
            }
            do
            {
                r = a % b;
                a = b;
                b = r;

            } while (r != 0);

            Console.WriteLine("Ezeknek a számoknak a legnagyobb közös osztója: {0}", a);
            return a;
        }
        static int Sum(int[] tomb)
        {
            int s = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                s += tomb[i];
            }
            Console.WriteLine("Összegzés: A tömb elemeinek összege: {0}", s);
            return s;
        }
        static void TombfeltoltEsKiirat(int[] tomb)
        {
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 10);
                Console.Write("{0}, ", tomb[i]);
            }
            Console.WriteLine();
        }
        static void ListaKiir(List<int> lista)
        {
            Console.Write("Kiválogatás: A páros számok: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0}, ", lista[i]);
            }
            Console.WriteLine();
        }
        static int Megszamlalas(int[] tomb)
        {
            int db = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                    db++;
            }
            Console.WriteLine("Megszámlálás: A tömbben található páros számok darabszáma: {0}", db);
            return db;
        }
        static List<int> Kivalogatas(int[] tomb, List<int> lista)
        {

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    lista.Add(tomb[i]);
                }
            }
            return lista;
        }
        static int MinimumHely(int[] tomb)
        {
            int minH = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] <= tomb[minH])
                    minH = i;
            }
            return minH;
        }
        static int MinimumE(int[] tomb)
        {
            int minE = tomb[0];

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] <= minE)
                    minE = tomb[i];
            }
            return minE;
        }
        static int MaximumHely(int[] tomb)
        {
            int maxH = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[maxH])
                    maxH = i;
            }
            return maxH;
        }
        static int MaximumE(int[] tomb)
        {
            int MaxE = tomb[0];

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > MaxE)
                    MaxE = tomb[i];
            }
            return MaxE;
        }
        static bool Eldontes(int[] tomb)
        {
            int i = 0;
            while (i <= tomb.Length - 1 && !(tomb[i] % 2 == 0))
                i++;
            if (i <= tomb.Length - 1)
            {
                Console.WriteLine("Eldöntés: Található a tömbben páros szám.");
                return true;
            }
            else
            {
                Console.WriteLine("Eldöntés: Nem található a tömbben páros szám.");
                return false;
            }
        }
        static bool Linker(int[] tomb)
        {
            int i = 0;
            while (i <= tomb.Length - 1 && !(tomb[i] % 2 == 0))
                i++;
            if (i <= tomb.Length - 1)
            {
                Console.WriteLine("Lineáris keresés: A tömbnek a legelső páros eleme ezen a helyen van: {0}", i + 1);
                return true;
            }
            else
                return false;
        }
        static void Kivalasztas(int[] tomb, out int hely)
        {
            int i = 0;
            while (!(tomb[i] % 2 == 0))
                i++;

            hely = i + 1;
            Console.WriteLine("Kiválasztás: A legelső páros szám ezen a pozíción van: {0}", hely);
        }
        static bool StrazsasKer(int[] tomb, out int hely)
        {
            int i = 0;
            tomb[tomb.Length - 1] = 2;

            while (!(tomb[i] % 2 == 0))
                i++;

            if (i == tomb.Length - 1)
            {
                hely = i + 1;
                Console.WriteLine("Strázsás keresés. Nincs páros szám.");
                return false;
            }
            else
            {
                hely = i + 1;
                Console.WriteLine("Strázsás keresés. Van benne páros szám, ezen a pozíción: {0}", hely);
                return true;
            }
        }
        static bool RendezettLinearis(int[] tomb, int keresettElem)
        {
            int i = 0;

            while (keresettElem > tomb[i] && tomb.Length - 1 >= i)
                i++;

            if (tomb[i] == keresettElem)
            {
                Console.WriteLine("Rendezett lineáris keresés: Benne volt az elem, ezen a pozíción: {0}", i + 1);
                return true;
            }
            else
            {
                Console.WriteLine("Rendezett lineáris keresés: Nem volt benne a keresett elem.");
                return false;
            }

        }
        static bool BinKer(int[] tomb, int keresettElem)
        {
            int E = 0;
            int U = tomb.Length - 1;
            int K = (E + U) / 2;

            while (E <= U && keresettElem != tomb[K])
            {
                if (keresettElem > tomb[K])
                    E = K + 1;
                else
                    U = K - 1;
                K = (E + U) / 2;
            }
            if (tomb[K] == keresettElem)
            {
                Console.WriteLine("Bináris keresés: megtaláltuk a keresett elemet ezen a pozíción: {0}", K + 1);
                return true;
            }

            else
            {
                Console.WriteLine("Bináris keresés: nem találtuk meg a keresett elemet");
                return false;
            }

        }
        static void Tombkiirat(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);

            }
            Console.WriteLine();
        }
        static void KozvetlenRend(int[] tomb)
        {
            for (int j = 0; j < tomb.Length - 1; j++)
            {
                for (int i = j + 1; i < tomb.Length; i++)
                {
                    if (tomb[j] > tomb[i])
                    {
                        int c = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = c;
                    }
                }
            }
            Console.WriteLine("Közvetlen kiválasztásos rendezés:");
            Tombkiirat(tomb);
        }
        static void RekurKözv(int[] tomb, int j)
        {
            for (int i = j + 1; i < tomb.Length; i++)
            {
                if (tomb[j] > tomb[i])
                {
                    int csere = tomb[j];
                    tomb[j] = tomb[i];
                    tomb[i] = csere;
                }

            }
            if (j < tomb.Length - 1)
            {
                RekurKözv(tomb, j + 1);
            }

        }
        static void MinimumkivRend(int[] tomb)
        {
            int minI;
            for (int j = 0; j < tomb.Length - 1; j++)
            {
                minI = j;
                for (int i = j + 1; i < tomb.Length; i++)
                {
                    if (tomb[i] < tomb[minI])
                        minI = i;
                }

                    if (minI != j)
                    {
                        int csere = tomb[minI];
                        tomb[minI] = tomb[j];
                        tomb[j] = csere;
                    }

            }
            Console.WriteLine("Minimum kiválasztásos rendezés:");
            Tombkiirat(tomb);

        }

        static void RekMinimumkivRend(int[] tomb, int j)
        {
                int minI = j;
                for (int i = j + 1; i < tomb.Length; i++)
                {
                    if (tomb[i] < tomb[minI])
                        minI = i;
                }

                if (minI != j)
                {
                   int csere = tomb[minI];
                    tomb[minI] = tomb[j];
                    tomb[j] = csere;
                }

                if (j < tomb.Length - 1)
                    RekMinimumkivRend(tomb, j + 1);

        }
        static void BuborekRend(int[] tomb)
        {
            int j = 0;
            int cs = 0;
            while (j < tomb.Length - 2)
            {

                for (int i = 0; i < tomb.Length - j - 1; i++)
                {
                    if (tomb[i] > tomb[i + 1])
                    {
                        cs = tomb[i];
                        tomb[i] = tomb[i + 1];
                        tomb[i + 1] = cs;
                    }
                }
                j++;

            }

            Console.WriteLine("Buborék rendezés:");
            Tombkiirat(tomb);

        }
        static void BuborekJ1(int[] tomb)
        {
            bool voltcsere = true;
            int cs = 0;
            int j = 0;

            while (j < tomb.Length && voltcsere)
            {
                voltcsere = false;
                for (int i = 0; i < tomb.Length - j - 1; i++)
                {
                    if (tomb[i] > tomb[i + 1])
                    {
                        cs = tomb[i];
                        tomb[i] = tomb[i + 1];
                        tomb[i + 1] = cs;
                        voltcsere = true;
                    }
                }
                j++;
            }
            Console.WriteLine("Buborék rendezés javított 1:");
            Tombkiirat(tomb);
        }
        static void Buborekrendj2(int[] tomb)
        {
            int j = 0;

            int cs = 0;

            while (j < tomb.Length-1)
            {
                int utolsocsereh = 0;
                for (int i = 0; i < tomb.Length - j-1; i++)
                {
                    if (tomb[i] > tomb[i + 1])
                    {
                        cs = tomb[i];
                        tomb[i] = tomb[i + 1];
                        tomb[i + 1] = cs;
                        utolsocsereh = i;
                    }
                }

                j = tomb.Length - utolsocsereh;
            }
            Console.WriteLine("Buborék rendezés javított 2:");
            Tombkiirat(tomb);
        }
        static void BesziroRend(int[] tomb)
        {
            int x = 0;
            int i = 0;

            for (int j = 0; j < tomb.Length - 1; j++)
            {
                i = j;
                x = tomb[j + 1];

                while (i >= 0 && tomb[i] > x)
                {
                    tomb[i + 1] = tomb[i];
                    i--;
                }

                tomb[i + 1] = x;
            }

            Console.WriteLine("Beszúró rendezés:");
            Tombkiirat(tomb);
        }
        static void ShellMinRend(int[] tomb)
        {
            int j, d, csere, minH = 0;
            int i = 0;
            d = tomb.Length - 1;

            do
            {
                d = d / 3 + 1;
                for (int k = 0; k < d; k++)
                {
                    j = k;
                    while (j < tomb.Length - d)
                    {
                        minH = j;
                        i = j + d;

                        while (i < tomb.Length)
                        {
                            if (tomb[i] < tomb[minH])
                            {
                                minH = i;
                            }
                            i = i + d;
                        }

                        if (j != minH)
                        {
                            csere = tomb[j];
                            tomb[j] = tomb[minH];
                            tomb[minH] = csere;
                        }
                        j = j + d;
                    }
                }
            } while (d == 1);
            Console.WriteLine("Shell rendezés:");
            Tombkiirat(tomb);
        }
        static void Osszefuttatas(int[] a, int[] b, int[] c)
        {
            int ai = 0;
            int bi = 0;
            int ci = -1;

            while (ai < a.Length && bi < b.Length)
            {
                ci++;
                if (a[ai] < b[bi])
                {
                    c[ci] = a[ai];
                    ai++;
                }
                else if (b[bi] < a[ai])
                {
                    c[ci] = b[bi];
                    bi++;
                }
                else
                {
                    c[ci] = a[ai];
                    ci++; ai++;
                    c[ci] = b[bi];
                    bi++;
                }
            }

            while (ai < a.Length)
            {
                ci++;
                c[ci] = a[ai];
                ai++;
            }

            while (bi < b.Length)
            {
                ci++;
                c[ci] = b[bi];
                bi++;
            }

            Console.WriteLine("Az összefuttatott tömb:");
            Tombkiirat(c);

        }
        static void KoktelRend(int[] tomb)
        {
            int j = 0;
            int cs = 0;
            while (j < tomb.Length - 2)
            {

                for (int i = 0; i < tomb.Length - j - 1; i++)
                {
                    if (tomb[i] > tomb[i + 1])
                    {
                        cs = tomb[i];
                        tomb[i] = tomb[i + 1];
                        tomb[i + 1] = cs;
                    }
                }

                for (int i = tomb.Length - j - 2; i > 0; i--)
                {
                    if (tomb[i+1] > tomb[i])
                    {
                        cs = tomb[i];
                        tomb[i] = tomb[i + 1];
                        tomb[i + 1] = cs;
                    }
                }
                j++;

            }
            Console.WriteLine("Koktélrendezés");
            Tombkiirat(tomb);

        }
    }
}

