using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 7, 8, 11 };
            int[] b = { 2, 5, 8, 9 };

            int[] c = new int[a.Length+b.Length];
            /*
            int adb = 0;
            int bdb = 0;
            int cdb = 0;

            while (adb < a.Length && bdb < b.Length)
            {
                if (a[adb] < b[bdb])
                {
                    c[cdb] = a[adb];
                    adb++;
                }
                else
                {
                    c[cdb] = b[bdb];
                    bdb++;
                }
                cdb++;
            }
            while (adb < a.Length)
            {
                c[cdb] = a[adb];
                adb++; cdb++;
            }
            while (bdb < b.Length)
            {
                c[cdb] = b[bdb];
                bdb++; cdb++;
            }*/

            OsszefuttatasRek(a, b, c, 0, 0, 0);
     
            for (int i = 0; i < c.Length; i++)
            { 
                Console.WriteLine(c[i]); 
            }

            Console.ReadLine();
        }

        static void OsszefuttatasRek(int[] a, int[] b, int[] c, int adb, int bdb, int cdb)
        {
            if (adb < a.Length && bdb < b.Length)
            {
                if (a[adb] < b[bdb])
                {
                    c[cdb] = a[adb];
                    OsszefuttatasRek(a, b, c, adb++, bdb, cdb++);
                }
                else
                {
                    c[cdb] = a[adb];
                    OsszefuttatasRek(a, b, c, adb, bdb++, cdb++);
                }
            }

            if (adb < a.Length)
            {
                c[cdb] = a[adb];
                OsszefuttatasRek(a, b, c, adb, adb++, cdb++);
            }
            if (bdb < b.Length)
            {
                c[cdb] = b[bdb];
                OsszefuttatasRek(a, b, c, adb, bdb++, cdb++);
            }
            
        
        }
    }
}
