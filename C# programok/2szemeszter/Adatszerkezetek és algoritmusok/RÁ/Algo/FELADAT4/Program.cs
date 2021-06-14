using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELADAT4
{
    class Program
    {
        static int MatrixOsszesElemOsszeg(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) //dimenzió hosszának lekérdezése
                for (int j = 0; j < matrix.GetLength(1); j++)
                    s += matrix[i, j];
            return s;     
        }

        static int MatrixFoatloElemOsszegv1(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) //dimenzió hosszának lekérdezése
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if(i==j)
                    s += matrix[i, j];
            return s;
        }
        static int MatrixFoatloElemOsszegv2(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) //dimenzió hosszának lekérdezése
                        s += matrix[i, i];
            return s;
        }

        static int MatrixMellekatloElemOsszegv2(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0);
            for (int i = 0; i <= n; i++) 
                s += matrix[i, n-i];
            return s;
        }

        static int MatrixOsszesElemOsszegOszlopFolytonosan(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0);
            for (int j = 0; j < n; j++) 
                for (int i = 0; i < n; i++)
                    s += matrix[i, j];
            return s;
        }

        static int MatrixFoatlofolottiElemOsszegOszlopFolytonosanv1(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0);
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

        static int MatrixFoatlofolottiElemOsszegOszlopFolytonosanv2(int[,] matrix)
        {
            int s = 0;
            int n = matrix.GetLength(0);
            for (int j = 1; j < n; j++) //j 1től indítva, mert az első oszlop tuti kimarad
                for (int i = 0; i < n; i++)
                        s += matrix[i, j];
            return s;
        }
        static void Main(string[] args)
        {
        }
    }
}
