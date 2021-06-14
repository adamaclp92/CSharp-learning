using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Osszegzes02
{
    class Program
    {
        static int MatrixOsszesElemOsszeg(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    s += matrix[i, j];
            
            return s;
        }
        static int MatrixOsszesElemOsszegOszlopfolytonosan(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0); //Megtehetjük, mert abból induéunk ki, hogy a mátrix négyzetes
            for (int j = 0; j < n; j++)
                for (int i = 0; i < n; i++)
                    s += matrix[i, j];
            return s;
        }

        static int MatrixFoatloOsszeg_v1(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        s += matrix[i, j];
                }
            }
            return s;
        }
        static int MatrixFoatloOsszeg_v2(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                s += matrix[i, i];
            }
            return s;
        }
        static int MatrixMellekatloOsszeg(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0) - 1;
            for (int i = 0; i <= n; i++)
            {
                s += matrix[i, n - i];
            }
            return s;
        }
        static int MatrixFoatloFolottiElemekOsszegeOszlopfolytonosan_v1(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0); //Megtehetjük, mert abból induéunk ki, hogy a mátrix négyzetes
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i < j)
                        s += matrix[i, j];
                }
            }
            return s;
        }
        static int MatrixFoatloFolottiElemekOsszegeOszlopfolytonosan_v2(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0); //Megtehetjük, mert abból induéunk ki, hogy a mátrix négyzetes
            for (int j = 1; j < n; j++) //Az első oszlop tuti kimarad
            {
                for (int i = 0; i < n - 1; i++) //Utolsó sor tuti kimarad
                {
                    if (i < j)
                        s += matrix[i, j];
                }
            }
            return s;
        }
        static int MatrixFoatloFolottiElemekOsszegeOszlopfolytonosan_v3(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0); //Megtehetjük, mert abból induéunk ki, hogy a mátrix négyzetes
            for (int j = 1; j < n; j++) //Az első oszlop tuti kimarad
            {
                for (int i = 0; i < j - 1; i++) //Főátló és alatta minden kimarad
                {                 
                        s += matrix[i, j];
                }
            }
            return s;
        }

        static void Main(string[] args)
        {
        }
    }
}
