using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2
{
    class Program
    {
        static Dictionary<int, int> cache = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            DateTime most = DateTime.Now;
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine(Sorozatcache(i));
            }
            TimeSpan meres1 = DateTime.Now - most;
            


            most = DateTime.Now;
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine(Sorozat(i));
            }
            TimeSpan meres2 = DateTime.Now - most;
            Console.WriteLine();
            Console.WriteLine("Cache: {0}", meres1.TotalMilliseconds);
            Console.WriteLine("Cache nélkül: {0}", meres2.TotalMilliseconds);
            Console.ReadKey();

        }

        static int Sorozatcache(int i)
        {
            if(i == 1)
            {
                return 1;
            }

            if(i==2)
            {
                return 4;
            }

            if (cache.ContainsKey(i))
            {
                return cache[i];
            }

            if (i % 2 == 0)
            {
                int eredmeny =  (int)Math.Pow(Sorozatcache(i - 1), 2);
                cache.Add(i, eredmeny);
                return eredmeny;

            }
            else 
            {
                int eredmeny =  Sorozatcache(i - 2) * Sorozatcache(i - 1);
                cache.Add(i, eredmeny);
                return eredmeny;
            }
        }

        static int Sorozat(int i)
        {
            if (i == 1)
            {
                return 1;
            }

            if (i == 2)
            {
                return 4;
            }

         
            if (i % 2 == 0)
            {
                return (int)Math.Pow(Sorozat(i - 1), 2);

            }
            else
            {
                return  Sorozat(i - 2) * Sorozat(i - 1);
               
            }
        }
    }
}
