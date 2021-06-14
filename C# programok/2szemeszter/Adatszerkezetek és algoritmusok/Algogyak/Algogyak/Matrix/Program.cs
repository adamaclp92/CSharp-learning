using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {

        static int MatrixOsszesElemOsszeg(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        static int MatrixOsszesElemOsszegOszlopfolytonosan(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
            }
            return sum;
        }

        static int MatrixFoatloOsszeg(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    sum += matrix[i, i];
                
            }
            return sum;
        }

        static int MatrixMellekatloOsszeg(int[,] matrix)
        {
            int sum = 0;
            int n = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, n-i];

            }
            return sum;
        }

        static int MatrixFoatloFolottiElemekOsszegeOszlopfolytonosan(int[,] matrix)
        {
            int sum = 0;
            int n = matrix.GetLength(0);
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if(i>j)
                    sum += matrix[j, i];
                }
            }
            return sum;
        }

        static int MatrixFoatloAlattiElemekOsszegeOszlopfolytonosan(int[,] matrix)
        {
            int sum = 0;
            int n = matrix.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (i < j)
                        sum += matrix[j, i];
                }
            }
            return sum;
        }



        static int MatrixMellekAtloFolottiElemekOsszegeOszlopfolytonosan(int[,] matrix)

        static int MatrixMellekAtloAlattiElemekOsszegeOszlopfolytonosan(int[,] matrix)


        static void Main(string[] args)
        {
        }
    }
}
