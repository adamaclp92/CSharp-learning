using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tomb = new int[10] { 1, 3, 2, 4, 5,7, 6, 9,8, 10 };

            /* for (int i = 0; i < tomb.Length-1; i++)
                 for (int j = i+1; j < tomb.Length; j++)
                 {
                     {
                         if (tomb[i] < tomb[j])
                         {
                             int csere = tomb[i];
                             tomb[i] = tomb[j];
                             tomb[j] = csere;
                         }
                     }
                 }*/

            rekurMin(tomb, 0, tomb.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadLine();
        }

        static void rekurMin(int[] tomb, int i, int n)
        {
            int min = i;
            for (int j = i+1; j < n; j++)
            {
                if (tomb[j] > tomb[min])
                    min = j;
            }
            int csere = tomb[i];
            tomb[i] = tomb[min];
            tomb[min] = csere;

            if (i + 1 < n)
                rekurMin(tomb, i + 1, n);
        }
        
    }
}
