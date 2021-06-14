using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public int minimumHely(int[] s)
        {
            //int P = s[0];
            int H = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if(s[i] < s[H])
                {
                    H = i;
                }
                /*if (s[i] < P)
                {
                    P = s[i];
                    H = i;
                }*/
            }
            
            return H;
        }

        static public int osszegzes(int[] s)
        {
            // megvalósítani
            int osszeg = 0;
            for(int i=0; i < s.Length; i++)
            {
                osszeg = s[i] + osszeg;
            }

            return osszeg;
        }

        static public int[] kivalogatoas(int[] s)
        {
            int[] A = new int[s.Length];
            int JDARAB = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] % 2 == 0)
                {
                    A[JDARAB] = s[i];
                    JDARAB++;
                }
            }
            return A;
        }

        static public int megszamalalas(int[] s)
        {
            int darab = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] % 2 == 0)
                {
                    darab++;
                }
            }
            return darab;
        }

        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var item in tomb)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(osszegzes(tomb));

            Console.WriteLine(minimumHely(tomb));

            foreach (var item in kivalogatoas(tomb))
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine(megszamalalas(tomb));

            Console.ReadKey();
        }
    }
}
