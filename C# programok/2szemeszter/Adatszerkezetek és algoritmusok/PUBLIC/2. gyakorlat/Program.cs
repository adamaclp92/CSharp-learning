using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public double PiNegyzetPerHat(int N)
        {
            double A = 0;   
            for (int i = 1; i < N+1; i++)
            {
                A += 1 / Math.Pow(i, 2);
            }

            return A;
        }

        static public double PiPerNegy(int N)
        {
            double A = 0;
            double A2 = 0;
            double A3 = 0;
            double nevezo = 1;
            double nevezo2 = 1;
            double A4 = 1;
            for (int i = 0; i < N; i++)
            {
                A += Math.Pow(-1, i) / (1 + 2 * i);

                if (i % 2 == 0)
                {
                    A2 += 1.0 / (1 + 2 * i);
                    A3 += 1 / nevezo;
                } else
                {
                    A2 -= 1.0 / (1 + 2 * i);
                    A3 -= 1 / nevezo;
                }
                nevezo += 2;

                nevezo2 += 2;
                A4 -= 1 / nevezo2;
                nevezo2 += 2;
                A4 += 1 / nevezo2;
            }
            Console.WriteLine(A2);
            Console.WriteLine(A3);
            Console.WriteLine(A4);
            return A;
        }


        static public double euler(int N)
        {
            double E = 1;
            for (int i = 1; i <= N; i++)
            {
                int A = 1;
                for (int j = 1; j <= i; j++)
                {
                    A *= j;
                }
                E += 1.0 / A;
            }
            return E;
        }

        static public double euler2(int N)
        {
            double E = 1;
            int A = 1;
            for (int i = 1; i <= N; i++)
            {
                A *= i;
                E += 1.0 / A;
            }
            return E;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PiNegyzetPerHat(10));
            Console.WriteLine(PiPerNegy(10));
            Console.WriteLine(euler(10));
            Console.WriteLine(euler2(10));
            Console.ReadKey();
        }
    }
}
