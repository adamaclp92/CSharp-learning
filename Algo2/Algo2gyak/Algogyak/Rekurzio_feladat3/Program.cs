using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzio_feladat3
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] Sorozat = new int[10] { 1, 5, 4, 7, 2, 3, 8, 9, 10, 6 };
            
            RekurMax(Sorozat, 0);
            for (int i = 0; i < Sorozat.Length; i++)
            {
                Console.WriteLine(Sorozat[i]);
            }
            Console.ReadLine();
        }

        static void RekurMax(int[] Sorozat, int i)
        {
            /*
            int max;
            for (i = 0; i < Sorozat.Length-1; i++)
            {
                max = i;
                for (int j = i+1; j < Sorozat.Length; j++)
                {
                    if (Sorozat[max] < Sorozat[j])
                    {
                        max = j;
                    }
                   
                }
                if (Sorozat[max] != Sorozat[i])
                {
                    int csere = Sorozat[i];
                    Sorozat[i] = Sorozat[max];
                    Sorozat[max] = csere;
                }
                
            }*/

               int max = i;
                for (int j = i + 1; j < Sorozat.Length; j++)
                {
                    if (Sorozat[max] < Sorozat[j])
                    {
                        max = j;
                    }
                }
                if (Sorozat[max] != Sorozat[i])
                {
                    int csere = Sorozat[i];
                    Sorozat[i] = Sorozat[max];
                    Sorozat[max] = csere;
                }

            if (i + 1 < Sorozat.Length)
                RekurMax(Sorozat, i + 1);

        }
    }
}
/*
 ELJÁRÁS RekurMax(A: Sorozat, i: egész): VOID
 VÁLTOZÓK
    max: egész;
    csere: egész;
ALGORITMUS
    max <- i;
    CIKLUS J <- (1..n-1)
        HA A[max] < A[i] AKKOR
            max <- j;
     CVÉGE;
     HA Sorozat[max] != A[i] AKKOR
         csere <- A[i];
         A[i] <- A[max];
         A[max] < csere;
     HVÉGE;
     HA i+1 < n-1 AKKOR
         RekurMax <- RekurMax(A, i+1);
     HVÉGE;
 EVÉGE;
     */
