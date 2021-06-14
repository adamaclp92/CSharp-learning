using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereses
{
    class Program
    {
        static void Tombfeltoltes(int[] tomb)
        {
            Random rnd = new Random();
            int tmp;
            for (int i = 0; i < tomb.Length-1; i++)
            {
                tmp = rnd.Next(1, 20);
                while (IsDup(tomb, tmp))
                {
                    tmp = rnd.Next(1, 20);
                }
                tomb[i] = tmp;
                Console.Write(tomb[i] + ", ");
            }
        }

        static void Tombfeltoltes2(int[] tomb)
        {
            Random rnd = new Random();
            int tmp;
            for (int i = 0; i < tomb.Length; i++)
            {
                tmp = rnd.Next(1, 20);
                while (IsDup(tomb, tmp))
                {
                    tmp = rnd.Next(1, 20);
                }
                tomb[i] = tmp;
                Console.Write(tomb[i] + ", ");
            }
        }

        static bool IsDup(int[] tomb, int tmp)
        {
            foreach (int a in tomb)
            {
                if (a == tmp)
                    return true;

            }
            return false;
        }
        

        static void TombSorbaRendezes(int[] tomb)
        {
            
            for (int i = 0; i < tomb.Length-1; i++)
            {
                for (int j = i+1; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[i])
                    {
                       int csere = tomb[j];
                        tomb[j] = tomb[i];
                        tomb[i] = csere;
                    }
                }
                
                Console.Write(tomb[i] + ", ");
            }
        }


        static void LinearisKereses(int[] tomb, int KeresettElem)
        {
            int i = 0;

            while (i < tomb.Length-1 && KeresettElem != tomb[i])
            {
                i++;

            }
            if (KeresettElem != tomb[i])
            {
                Console.WriteLine("\nBocsi, de nem találtuk.");
            }
            else
            {
                Console.WriteLine("\nMegtaláltuk, ezen a pozíción: {0}", i + 1);
            }
        }

        static void LinearisKeresesRendezettTombbel(int[] tomb, int KeresettElem)
        {
            int i = 0;

            while (i < tomb.Length - 1 && KeresettElem != tomb[i] && tomb[i] < KeresettElem)
            {
                Console.WriteLine("{0}",i);
                i++;

            }
            if (KeresettElem != tomb[i])
            {
                Console.WriteLine("\nBocsi, de nem találtuk.");
            }
            else
            {
                Console.WriteLine("\nMegtaláltuk, ezen a pozíción: {0}", i + 1);
            }
        }


        static void StrazsasKereses(int[] tomb, int KeresettElem)
        {
            int i = 0;
            tomb[19] = KeresettElem;

            while (KeresettElem != tomb[i])
            {
                i++;

            }
            for (int j = 0; j < tomb.Length; j++)
            {
                Console.Write(tomb[j] + ", ");
            }
         

            Console.WriteLine("\nMegtaláltuk, ezen a pozíción: {0}", i + 1);
        }

        static void BinarisKereses(int[] tomb, int KeresettElem)
        {
            int E = 1;
            int V = tomb.Length-1;
            int K = (E+V) / 2;
       
            while (K != KeresettElem && E<K)
            {
                if (KeresettElem > tomb[K])
                {
                   
                    E = K + 1;
                }
                else
                {
                    V = K - 1;
                }
                K = (E + V )/ 2;
            }
            if (tomb[K] == KeresettElem)
                Console.WriteLine("Megtaláltuk");
            else
                Console.WriteLine("Nem találtuk");
           
        }


        static void Main(string[] args)
        {
            int[] tomb = new int[20];
            int[] tomb2 = new int[20];
            Tombfeltoltes(tomb);
            LinearisKereses(tomb, 25);
            Console.WriteLine();
            StrazsasKereses(tomb, 10);
            Console.WriteLine();
           
            TombSorbaRendezes(tomb);
            LinearisKeresesRendezettTombbel(tomb, 4);
            Tombfeltoltes2(tomb2);
            TombSorbaRendezes(tomb2);
            BinarisKereses(tomb2, 5);
            Console.ReadLine();
        }

    }
}
