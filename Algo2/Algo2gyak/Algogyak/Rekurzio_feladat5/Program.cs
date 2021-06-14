using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzio_feladat5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Listafeltolt(lista, 5, 17);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }

        static int Listafeltolt(List<int> l, int a, int b)
        {
           
            if (a < b-1)
            {
                if (a % 2 != 0)
                {
                   l.Add(a+1);
                   return Listafeltolt(l, a + 1, b);
                }
                else return Listafeltolt(l, a + 1, b);
            }
          

            else return b;
        }
    }
}
