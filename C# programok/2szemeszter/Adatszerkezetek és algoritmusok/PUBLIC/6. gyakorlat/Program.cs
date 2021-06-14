using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static public void maxRend(int[] A)
        {
            int max;
            int csere;

            for (int i = 0; i < A.Length-1; i++)
            {
                max = i;
                for (int j = i+1; j < A.Length; j++)
                {
                    if(A[j] > A[max])
                    {
                        max = j;
                    }
                }

                csere = A[i];
                A[i] = A[max];
                A[max] = csere;
            }
        }

        static public void kozvetlenRend(int[] A)
        {
            int csere;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    if(A[i] > A[j])
                    {
                        csere = A[j];
                        A[j] = A[i];
                        A[i] = csere;
                    }
                }
            }
        }

        static public void buborek(int[] A)
        {
            int csere;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = 0; j < A.Length-i-1; j++)
                {
                    if(A[j] > A[j + 1])
                    {
                        csere = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = csere;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] szamok = new int[] { 3, 4, 2, 1, 6, 5 };
            maxRend(szamok);

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();

            int[] szamok2 = new int[] { 3, 4, 2, 1, 6, 5 };
            kozvetlenRend(szamok2);

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write(szamok2[i] + " ");
            }

            Console.WriteLine();

            int[] szamok3 = new int[] { 3, 4, 2, 1, 6, 5 };
            buborek(szamok3);

            for (int i = 0; i < szamok3.Length; i++)
            {
                Console.Write(szamok3[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
