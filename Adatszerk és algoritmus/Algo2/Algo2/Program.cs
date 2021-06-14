using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int fakt = Fakt(a);
            int faktI = FaktI(a);
            Console.WriteLine("{0} faktoriálisa rekurzív: {1}", a, fakt);
            Console.WriteLine("{0} faktoriálisa iteratív: {1}", a, faktI);
            int fibo = Fibo(a);
            int fiboI = FiboI(a);

            Console.WriteLine("{0}. Fibonacci szám rekurzívan: {1}", a, fibo);
            Console.WriteLine("{0}. Fibonacci szám iteratívan: {1}", a, fiboI);

            int hely = 0;
            int[] tomb1 = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            RekBinKer(tomb1, out hely, 7, 0, tomb1.Length - 1);

            Hanoi(3, 'a', 'c', 'b');


            List<int> l = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                l.Add(rnd.Next(1, 10));

            }

            BeszuroRendRek(l, 1);
            Console.WriteLine("Beszúró rendezés:");
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write("{0}, ", l[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Összefuttatás:");

            int[] t1 = new int[4] { 1, 3, 5, 6 };
            int[] t2 = new int[4] { 2, 4, 6, 7 };
            int[] t3 = new int[t1.Length + t2.Length];
            int ai = 0;
            int bi = 0;
            int ci = 0;

            OsszRek(t1, t2, t3, ai, bi, ci);

            for (int i = 0; i < t3.Length; i++)
            {
                Console.Write("{0}, ", t3[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Bináris bejárással:");
            int e = 0;
            int u = t3.Length-1;
            BinBejaras(t3, e, u);
            Console.ReadLine();
        }

        static int Fakt(int K)
        {
            if (K > 0)
                return K * Fakt(K - 1);
            else return 1;
        }

        static int FaktI(int K)
        {
            int s = 1;

            for (int i = 1; i <= K; i++)
            {
                s *= i;
            }
            return s;
        }

        static int Fibo(int N)
        {
            if (N > 1)
                return Fibo(N - 1) + Fibo(N - 2);
            else
                return N;
        }

        static int FiboI(int N)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (N < 2)
                return N;
            else
            {
                for (int i = 2; i <= N; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
        }

        static void RekBinKer(int[] tomb, out int hely, int adat, int E, int U)
        {
            
            int k = 0;
            if (E > U)
            {
                hely = 0;
            }
            else
            {
                k = (E + U) / 2;
                if (tomb[k] > adat)
                    RekBinKer(tomb, out hely, adat, E, k - 1);
                else
                { 
                    if(tomb[k] < adat)
                    RekBinKer(tomb, out hely, adat, k + 1, U);
                    else
                    {
                        hely = k;
                        Console.WriteLine("A keresett elem ezen a pozíción van: {0}", hely+1);

                    } 
                }
            }
                
        }

        static void Hanoi(int N, char R1, char R3, char R2)
        {
            if (N > 0)
            {
                Hanoi(N - 1, R1, R2, R3);
                Console.WriteLine(N + ". korong áthelyezése: " + R1 + "=>" + R3);
                Hanoi(N - 1, R2, R3, R1);
            }
        }

        static void BeszuroRendRek(List<int> lista, int i)
        {
            int k = lista[i];
            int j = i - 1;

            while (j >= 0 && lista[j] > k)
            {
                lista[j + 1] = lista[j];
                j = j - 1;
            }
            lista[j + 1] = k;

            if (i < lista.Count - 2)
            {
                BeszuroRendRek(lista, i + 1);
            }
        }

        static void Buborek(int[] tomb, int j)
        {

            for (int i = 0; i < j; i++)
            {
                if (tomb[i] > tomb[i + 1])
                {
                    int csere = tomb[i];
                    tomb[i] = tomb[i + 1];
                    tomb[i + 1] = csere;
                }
            }
            if (j > 0)
                Buborek(tomb, j - 1);


        }

        static void OsszRek(int[] t1, int[] t2, int[] t3, int ai, int bi, int ci)
        {
            if (ai < t1.Length && bi < t2.Length)
            {
                if (t1[ai] < t2[bi])
                {
                    t3[ci] = t1[ai];
                    OsszRek(t1, t2, t3, ai + 1, bi, ci + 1);
                }
                else if (t1[ai] > t2[bi])
                {
                    t3[ci] = t2[bi];
                    OsszRek(t1, t2, t3, ai, bi + 1, ci + 1);
                }
                else
                {
                    t3[ci] = t1[ai];
                    ci++;
                    t3[ci] = t2[bi];
                    OsszRek(t1, t2, t3, ai + 1, bi + 1, ci + 1);
                }


            }
            else
            {

                if (ai < t1.Length)
                {
                    t3[ci] = t1[ai];
                    OsszRek(t1, t2, t3, ai + 1, bi, ci + 1);
                }
                else if (bi < t2.Length)
                {
                    t3[ci] = t2[bi];
                    OsszRek(t1, t2, t3, ai, bi + 1, ci + 1);
                }
            }


        }

        static void BinBejaras(int[] t3, int e, int u)
        {
            int k;

            if (e <= u)
            {
                k = (e + u) / 2;

                Console.Write(t3[k] + ", ");

                BinBejaras(t3, e, k - 1);
                BinBejaras(t3, k + 1, u);
            }
        }
    }
}
