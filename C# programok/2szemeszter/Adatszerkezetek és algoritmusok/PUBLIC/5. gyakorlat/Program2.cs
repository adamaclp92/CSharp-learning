using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public bool csokkenoE(int[] A)
        {
            int i = 0;
            while (i < A.Length - 1 && A[i] > A[i + 1])
            {
                i++;
            }
            return i == A.Length - 1;
        }

        static public bool keres(int[] A, int elem)
        {
            int i = 0;
            while (i < A.Length)
            {
                if(A[i] == elem)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        static public bool keres2(int[] A, int elem)
        {
            int i = 0;
            while (i < A.Length && A[i] > elem)
            {
                i++;
            }
            return i < A.Length && A[i] == elem;
        }

        static public bool linKeres(int[] A)
        {
            int i = 0;
            while (i < A.Length && A[i] % 2 == 0)
            {
                i++;
            }
            return i < A.Length;
        }

        static public bool strazsaKeres(int[] A)
        {
            int i = 0;
            while (A[i] % 2 == 0)
            {
                i++;
            }
            return i < A.Length - 1;
        }

        static public bool binKeres(int[] A, int elem)
        {
            int eleje = 0;
            int vege = A.Length - 1;
            int kozepe = (eleje + vege) / 2;

            while (eleje < vege && elem != A[kozepe])
            {
                if(elem >  A[kozepe])
                {
                    vege = kozepe - 1;
                }
                else
                {
                    eleje = kozepe + 1;
                }
                kozepe = (eleje + vege) / 2;
            }
            return elem == A[kozepe];
        }


        static void Main(string[] args)
        {
            int[] szamok = new int[] { 6, 12, 4, 8, 2};
            Console.WriteLine(csokkenoE(szamok));

            Console.WriteLine(keres(szamok, 3));
            Console.WriteLine(keres2(szamok, 3));


            Console.WriteLine(linKeres(szamok));

            int[] szamok2 = new int[] { 6, 12, 4, 8, 2, 3 };
            Console.WriteLine(strazsaKeres(szamok2));

            int[] szamok3 = new int[] { 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(binKeres(szamok3, 3));

            Console.ReadKey();
        }
    }
}
