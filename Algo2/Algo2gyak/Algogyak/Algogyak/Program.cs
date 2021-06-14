using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algogyak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] tomb = new int[10] {1,2,5,7,9,12,15,17,18,20 };
            int hely;
            if (ReBinKer(tomb, 3, out hely))
                Console.WriteLine(hely);
            else Console.WriteLine(hely);

            Console.ReadLine();

        }

        static bool ReBinKer(int[] tomb, int adat, out int hely)
        {
            return ReBinKer(tomb, adat, out hely, 0, tomb.Length-1);
        }

        static bool ReBinKer(int[] tomb, int adat, out int hely, int E, int V)
        {
            if (E <= V)
            {
                int K = (E + V) / 2;
                if (tomb[K] > adat)
                {
                    return ReBinKer(tomb, adat, out hely, E, K - 1);
                }
                else
                {
                    if (tomb[K] < adat)
                    {
                       return ReBinKer(tomb, adat, out hely, K + 1, V);
                    }
                    else
                    {
                        hely = K;
                        return true;
                    }
                }
            }
            else
            {
                hely = -1;
                return false;
            }
        }
    }
}
