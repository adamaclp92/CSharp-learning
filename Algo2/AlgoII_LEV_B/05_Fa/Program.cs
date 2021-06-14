using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fa
{
    class Program
    {
        static void Main(string[] args)
        {
            Csomopont gyoker = new Csomopont();
            gyoker.Adat = 55;
            gyoker.Bal = new Csomopont();
            gyoker.Bal.Adat = 43;
            gyoker.Bal.Jobb = new Csomopont();
            gyoker.Bal.Jobb.Adat = 46;

            gyoker.Jobb = new Csomopont();
            gyoker.Jobb.Adat = 65;
            gyoker.Jobb.Bal = new Csomopont();
            gyoker.Jobb.Bal.Adat = 61;
            gyoker.Jobb.Jobb = new Csomopont();
            gyoker.Jobb.Jobb.Adat = 71;

            InOrder(gyoker);
            Console.WriteLine();
            PreOrder(gyoker);
            Console.WriteLine();
            PostOrder(gyoker);
            Console.WriteLine();

            int[] sorozat = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Csomopont kereso = Sor2Fa(sorozat, 0, sorozat.Length - 1);
            InOrder(kereso);

            Console.ReadKey();
        }

        static void InOrder(Csomopont csomopont)
        {
            if (csomopont.Bal != null)
            {
                InOrder(csomopont.Bal);
            }

            Console.WriteLine(csomopont.Adat);

            if (csomopont.Jobb != null)
            {
                InOrder(csomopont.Jobb);
            }
        }

        static void PreOrder(Csomopont csomopont)
        {
            Console.WriteLine(csomopont.Adat);

            if (csomopont.Bal != null)
            {
                PreOrder(csomopont.Bal);
            }

            if (csomopont.Jobb != null)
            {
                PreOrder(csomopont.Jobb);
            }
        }

        static void PostOrder(Csomopont csomopont)
        {
            if (csomopont.Bal != null)
            {
                PostOrder(csomopont.Bal);
            }

            if (csomopont.Jobb != null)
            {
                PostOrder(csomopont.Jobb);
            }

            Console.WriteLine(csomopont.Adat);
        }

        static Csomopont Sor2Fa(int[] sorozat, int E, int U)
        { 
            if (E <= U)
            {
                int K = (E + U) / 2;
                Csomopont csomopont = new Csomopont();
                csomopont.Adat = sorozat[K];
                csomopont.Bal = Sor2Fa(sorozat, E, K - 1);
                csomopont.Jobb = Sor2Fa(sorozat, K + 1, U);
                return csomopont;
            }

            return null;
        }

        static int Magassag(Csomopont csomopont)
        {
            int balMelyseg = 0;
            int jobbMelyseg = 0;

            if (csomopont.Bal != null)
            {
                balMelyseg = Melyseg(csomopont.Bal);
            }

            if (csomopont.Jobb != null)
            {
                jobbMelyseg = Melyseg(csomopont.Jobb);
            }

            return balMelyseg > jobbMelyseg ? balMelyseg : jobbMelyseg;
        }

        static int Melyseg(Csomopont csomopont)
        {
            int melyseg = 0;

        }
    }
}
