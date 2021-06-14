using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public void matrixKiir(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + ", " );
                }
                Console.WriteLine();
            }
        }

        static public int foatlo(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0;  j < M.GetLength(1);  j++)
                {
                    if(i == j)
                    {
                        A += M[i, j];
                    }
                }
            }
            return A;
        }

        static public int foatlo2(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                A += M[i, i];
            }
            return A;
        }

        static public int mellekatlo(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (i + j == M.GetLength(0) - 1)
                    {
                        A += M[i, j];
                    }
                }
            }
            return A;
        }

        static public int foatlofelett(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        A += M[i, j];
                    }
                }
            }
            return A;
        }

        static public int foatlofelett2(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < M.GetLength(1); j++)
                {
                    A += M[i, j];                    
                }
            }
            return A;
        }

        static public int foatloalatt(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (j < i)
                    {
                        A += M[i, j];
                    }
                }
            }
            return A;
        }

        static public int foatloalatt2(int[,] M)
        {
            int A = 0;
            for (int i = 1; i < M.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    A += M[i, j];
                }
            }
            return A;
        }

        static public int mellekatlo2(int[,] M)
        {
            int A = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                A += M[i, M.GetLength(0) - i - 1];
            }
            return A;
        }

        static public bool csokkenoE(int[] A)
        {
            int i = 0;
            while (i < A.Length-1  && A[i] > A[i+1])
            {
                i++;
            }
            return i == A.Length-1;
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16}
            };

            matrixKiir(matrix);

            Console.WriteLine(foatlo(matrix));
            Console.WriteLine(foatlo2(matrix));

            Console.WriteLine(mellekatlo(matrix));
            Console.WriteLine(mellekatlo2(matrix));

            Console.WriteLine();

            Console.WriteLine(foatlofelett(matrix));
            Console.WriteLine(foatlofelett2(matrix));

            Console.WriteLine(foatloalatt(matrix));
            Console.WriteLine(foatloalatt2(matrix));

            Console.WriteLine();

            int[] szamok = new int[] { 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(csokkenoE(szamok));
            Console.ReadKey();
        }
    }
}
