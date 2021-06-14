using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGO.ADAM
{
    class Program
    {

        /*PSEUDO KÓDOK
         
         * 1. FELADAT
         
     FÜGGVÉNY Sorozat(i: egész): egész
     VÁLTOZÓK
     ALGORITMUS
        HA i = 0 AKKOR
            Sorozat <- 1;
        HA i = 1 AKKOR
            Sorozat <- 5;
        HA i = 2 AKKOR
            Sorozat <- 3;

        KÜLÖNBEN HA i MOD 2 = 0 AKKOR
            Sorozat <- POW(Sorozat(i-2 - i-3), 2) + Sorozat(i-1));
        KÜLÖNBEN 
            Sorozat <- POW(Sorozat(i-2 + i-1), 2) - Sorozat(i-3));
        HVÉGE;
     FVÉGE;

         2. FELADAT
         * 
         * ELJÁRÁS RekurKözv(tomb: SOROZAT, i: EGÉSZ)
         * VÁLTOZÓK
         * I: egész;
         * J: egész;
         * CS: egész;
         * ALGORITMUS
         * I <- 0;
         *  CIKLUS (i+1 ... N)
         *      HA(tomb[i] < tomb[j])
         *          CS <- tomb[j];
         *          tomb[j] <- tomb[i];
         *          tomb[i] <- CS;
         *       HVÉGE;  
         *      HA(i < N-1)
         *          RekurKözv <- RekurKözv(tomb, i+1);
         *      HVÉGE;
         *  CVÉGE;
         
        3.FELADAT
         * 
         * FÜGGVÉNY ListaLegkisebbElemHely(lista: LISTA, hely: EGÉSZ, i: EGÉSZ): EGÉSZ
         * ALGORITMUS
         * hely <- lista[i];
         * HA hely > lista[i+1]
         *     ListaLegkisebbElemHely <-  ListaLegkisebbElemHely(lista, hely, i+1); 
         * HVÉGE;
    
         4. FELADAT
         * 
        FÜGGVÉNY Hatvany(a: EGÉSZ, b: EGÉSZ): EGÉSZ;
        ALGORITMUS
	        HA (b = 0) AKKOR
		        Hatvany <- 1;
	        KÜLÖNBEN
		        Hatvany <- a * Hatvany(a, b - 1);
	        HVÉGE;
        FVÉGE;
         */
        static void Main(string[] args)
        {

            //TESZTELÉS
            //1. FELADAT
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Sorozat(i));
            }

            //2. FELADAT
            int[] tomb = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = rnd.Next(1, 10);

            }
            int j = 0;
            RekurKözv(tomb, j);


            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("{0}", tomb[i]);
            }

            //3. FELADAT
            List<int> l = new List<int>();
            int hely;
            int z = 0;
          
            for (int k = 0; k < l.Count; j++)
            {
                l.Add(rnd.Next(1, 10));
            }

            Console.WriteLine(ListaLegkisebbElemHely(l, out hely, z)); 

            //4. FELADAT
            Console.WriteLine(Hatvany(3, 3));
            Console.ReadLine();
            
        }

        static int Sorozat(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            if (i == 1)
            {
                return 5;
            }
            if (i == 2)
            {
                return 3;
            }

            else if (i % 2 == 0)
            {
                return (int)(Math.Pow(Sorozat(i - 2) - Sorozat(i - 3), 2) + Sorozat(i - 1));
            }
            else
            {
                return (int)(Math.Pow(Sorozat(i - 2) + Sorozat(i - 1), 2) - Sorozat(i - 3));
            }
        }

        static void RekurKözv(int[] tomb, int i)
        {
            for (int j = i + 1; j < tomb.Length; j++)
            {
                if (tomb[i] < tomb[j])
                {
                    int csere = tomb[j];
                    tomb[j] = tomb[i];
                    tomb[i] = csere;
                }

                if (i < tomb.Length - 1)
                {
                    RekurKözv(tomb, i + 1);
                }
            }

        }

        static int ListaLegkisebbElemHely(List<int> lista, out int hely, int i)
        {
            hely = lista[i];
            if (hely > lista[i + 1])
            {
                return ListaLegkisebbElemHely(lista, out hely, i + 1);
            }
            else return hely;


        }

        static int Hatvany(int a, int b)
        {
            if (b == 0)
                return 1;
            else
                return a * Hatvany(a, b - 1);

        }
    }
}
