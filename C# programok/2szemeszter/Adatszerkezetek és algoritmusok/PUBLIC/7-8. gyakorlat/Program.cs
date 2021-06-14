using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public void kozvetlenRend(int[] A)
        {
            int csere;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    if(A[i] > A[j])
                    {
                        csere = A[i];
                        A[i] = A[j];
                        A[j] = csere;
                    }
                }
            }
        }

        static public void minRend(int[] A)
        {
            int csere;
            int min;

            for (int i = 0; i < A.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j < A.Length; j++)
                {
                    if(A[j] < A[min])
                    {
                        min = j;
                    }
                }

                csere = A[i];
                A[i] = A[min];
                A[min] = csere;
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

        static public void buborek2(int[] A)
        {
            int csere;
            bool B = true;
            int i = 0;
            while(i <A.Length-1 && B)
            {
                B = false;
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        csere = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = csere;
                        B = true;
                    }
                }
                i++;
            }
        }

        static public void buborek3(int[] A)
        {
            int csere;
            int BHelye = 0;
            int i = 0;
            while (i < A.Length - 1)
            {
                BHelye = 0;
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        csere = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = csere;
                        BHelye = j;
                    }
                }
                i = A.Length-1 - BHelye;
            }
        }

        static public void buborek4(int[] A)
        {
            int csere;
            int BHelye = 0;
            int i = A.Length - 1;
            while (i > 0)
            {
                BHelye = 0;
                for (int j = 0; j < i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        csere = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = csere;
                        BHelye = j;
                    }
                }
                i = BHelye;
            }
        }

        static public void koktel(int[] A)
        {
            int csere;
            bool B = true;
            int SZ = 0;
            while (B)
            {
                B = false;
                for (int j = SZ; j < A.Length - SZ - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        csere = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = csere;
                        B = true;
                    }
                }

                for (int j = A.Length - SZ - 2; j > SZ; j--)
                {
                    if (A[j] < A[j - 1])
                    {
                        csere = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = csere;
                        B = true;
                    }
                }

                SZ++;
            }
        }

        static public void beszuro(int[] A)
        {
            //int csere;
            for (int i = 1; i < A.Length; i++)
            {
                int j = i - 1;
                int T = A[i];
                while (j>=0 && A[j] > T)
                {
                    //csere = A[j];
                    //A[j] = A[j + 1];
                    //A[j + 1] = csere;
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = T;
            }
        } 

        static void Main(string[] args)
        {
            int[] szamok = new int[] { 3, 2, 1, 5, 6, 4 };
            kozvetlenRend(szamok);

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();

            int[] szamok2 = new int[] { 3, 2, 1, 5, 6, 4 };
            minRend(szamok2);

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write(szamok2[i] + " ");
            }
            Console.WriteLine();

            int[] szamok3 = new int[] { 3, 2, 1, 5, 6, 4 };
            buborek(szamok3);

            for (int i = 0; i < szamok3.Length; i++)
            {
                Console.Write(szamok3[i] + " ");
            }
            Console.WriteLine();

            int[] szamok4 = new int[] { 3, 2, 1, 5, 6, 4 };
            buborek2(szamok4);

            for (int i = 0; i < szamok4.Length; i++)
            {
                Console.Write(szamok4[i] + " ");
            }
            Console.WriteLine();

            int[] szamok5 = new int[] { 3, 2, 1, 5, 6, 4 };
            buborek3(szamok5);

            for (int i = 0; i < szamok5.Length; i++)
            {
                Console.Write(szamok5[i] + " ");
            }
            Console.WriteLine();

            int[] szamok6 = new int[] { 3, 2, 1, 5, 6, 4 };
            buborek4(szamok6);

            for (int i = 0; i < szamok6.Length; i++)
            {
                Console.Write(szamok6[i] + " ");
            }
            Console.WriteLine();

            int[] szamok7 = new int[] { 3, 2, 1, 5, 6, 4 };
            koktel(szamok7);

            for (int i = 0; i < szamok7.Length; i++)
            {
                Console.Write(szamok7[i] + " ");
            }
            Console.WriteLine();

            int[] szamok8 = new int[] { 3, 2, 1, 5, 6, 4 };
            beszuro(szamok8);

            for (int i = 0; i < szamok8.Length; i++)
            {
                Console.Write(szamok8[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
