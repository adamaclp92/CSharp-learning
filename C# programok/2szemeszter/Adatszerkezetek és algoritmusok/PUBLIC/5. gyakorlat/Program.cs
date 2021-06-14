using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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

        static public bool rendezettBenneVanE(int[] A, int elem)
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

        static public bool rendezettBenneVanE2(int[] A, int elem)
        {
            int i = 0;
            while (i < A.Length && A[i] > elem)
            {              
                i++;
            }
            return (i < A.Length && A[i] == elem);
        }

        public static bool keresStrazsa(int[] A)
        {
            int i = 0;
            while (A[i] % 2 != 0)
            {
                i++;
            }
            return i < A.Length - 1;
        }

        public static bool binKeres(int[] A, int elem)
        {
            int elso = 0;
            int utolso = A.Length - 1;
            int fele = (elso + utolso) / 2;

            while (utolso > elso && elem != A[fele])
            {
                if(elem > A[fele])
                {
                    utolso = fele - 1;
                }
                else
                {
                    elso = fele + 1;
                }
                fele = (elso + utolso) / 2;
            }
            return elem == A[fele];
        }

        static void Main(string[] args)
        {
            int[] szamok = new int[] { 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(csokkenoE(szamok));
            Console.WriteLine(rendezettBenneVanE(szamok, 4));
            Console.WriteLine(rendezettBenneVanE2(szamok, 4));

            int[] paratlan = new int[] { 7, 5, 9, 9, 13, 2 };
            Console.WriteLine(keresStrazsa(paratlan));

            Console.WriteLine(binKeres(szamok, 3));
            Console.ReadKey();

        }
    }
}
