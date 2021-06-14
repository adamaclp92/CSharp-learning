using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurbubi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10] {3,2,6,1,7,9,8,4,5,2 };
            Buborek(tomb, tomb.Length-1);
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadLine();
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
                if(j >0)
                    Buborek(tomb, j - 1);

            
        }
    }
}
