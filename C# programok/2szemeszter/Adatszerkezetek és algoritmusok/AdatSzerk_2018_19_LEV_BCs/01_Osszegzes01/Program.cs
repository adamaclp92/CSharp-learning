using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Osszegzes01
{
    class Program
    {
        //FÜGGVÉNY PI(N: EGÉSZ): VALÓS;
        //    VÁLTOZÓK
        //        I: EGÉSZ;
        //        S: VALÓS;
        //        E: EGÉSZ;
        //    ALGOITMUS
        //        S <- 0;
        //        E <- 1;
        //        CIKLUS I <- 1..N			
        //            S <- S + E * (1 / (I * 2 - 1));			
        //            E = -E;
        //        CIKLUS_VÉGE;
        //        PI <- 4 * S;
        //FÜGGVÉNY_VÉGE;
        static double Pi(int n)
        {
            double s = 0.0;
            int e = 1;
            int i = 1;
            while(i <= n)
            {
                s += e * ((double)1 / i);
                e = -e;
                i = i + 2;
            }
            return 4 * s;
        }

        //FÜGGVÉNY E_v1(N: EGÉSZ): VALÓS;
        //    VÁLTOZÓK
        //        I: EGÉSZ;
        //        J: EGÉSZ;
        //        F: EGÉSZ;
        //        S: VALÓS;
        //    ALGOITMUS
        //        S <- 1; //Az első tag biztosan 1
        //        CIKLUS I <- 1..N - 1	
        //            F <- 1; //A szorzás művelet miatt
        //            CIKLUS J <- 1..I
        //                F = F * J;
        //            CIKLUS_VÉGE;
        //            S <- 1 / F;
        //        CIKLUS_VÉGE;
        //        E <- S;
        //FÜGGVÉNY_VÉGE;
        static double e_v1(int n, ref int num, ref int log, ref int iter, ref int ert)
        {
         

            double s = 1.0;
          
            for (int i = 1; i < n; i++)
            {
          
                ulong f = 1; 
             
                for (int j = 1; j <= i; j++)
                {
              
                    f *= (ulong)j; 
                }
                s += (double)1 / f;
            }
            return s;
        }

        //FÜGGVÉNY E_v2(N: EGÉSZ): VALÓS;
        //    VÁLTOZÓK
        //        I: EGÉSZ;
        //        J: EGÉSZ;
        //        F: EGÉSZ;
        //        S: VALÓS;
        //    ALGOITMUS
        //        S <- 1; //Az első tag biztosan 1
        //        F <- 1; //A szorzás művelet miatt
        //        CIKLUS I <- 1..N - 1	
        //            F <- F * I;
        //            S <- 1 / F;
        //        CIKLUS_VÉGE;
        //        E <- S;
        //FÜGGVÉNY_VÉGE;
        static double e_v2(int n, ref int num, ref int log, ref int iter, ref int ert)
        {
            num = 0; log = 0; iter = 0; ert = 0;

            double s = 1.0; ert++;
            ulong f = 1; ert++;
            ert++; //ciklusváltozó miatt
            for (int i = 1; i < n; i++)
            {
                iter++;
                log++; ert++; num++; //i változó miatt a ciklusban
                f *= (ulong)i; num++; ert++;
                s += (double)1 / f; num++; ert++;
            }
            return s;
        }

        static void Main(string[] args)
        {
            //numerikus művelet, logikai kiértékelés, iteráció, értékadás
            int num = 0, log = 0, iter = 0, ert = 0;

            Console.WriteLine("Pi ~ {0}", Pi(100000));
            Console.WriteLine("Pi = {0}", Math.PI);

            Console.WriteLine("e ~ {0}", e_v1(50, ref num, ref log, ref iter, ref ert));
            Console.WriteLine("Num: {0}\tLog: {1}\tIter: {2}\tÉrt: {3}", num, log, iter, ert);
            Console.WriteLine("e ~ {0}", e_v2(50, ref num, ref log, ref iter, ref ert));
            Console.WriteLine("Num: {0}\tLog: {1}\tIter: {2}\tÉrt: {3}", num, log, iter, ert);
            Console.WriteLine("e = {0}", Math.E);

            Console.Write("\nNyomjon Enter-t a kilépéshez!");
            Console.ReadLine();
        }
    }
}
