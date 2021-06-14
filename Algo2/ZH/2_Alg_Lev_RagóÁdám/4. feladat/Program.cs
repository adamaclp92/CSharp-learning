using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    class Program
    {
        /*
         FÜGGVÉNY ListaValogatas(lista: elemtípus, a,b:egész):egész
         * ALGORITMUS
         * HA a <= b AKKOR
         *      HA A MOD 2 = 0 AKKOR
         *          lista.Add(a);
         *          ListaValogatas <- ListaValogatas(lista, a+1, b);
         *      KÜLÖNBEN  ListaValogatas <- ListaValogatas(lista, a+1, b);
         *      HVÉGE;
         * KÜLÖNBEN ListaValogatas <- b;
         * HVÉGE;
         * FVÉGE;
         
         */

        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            ListaValogatas(l, 2, 20);

            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.ReadLine();
        }

        static int ListaValogatas(List<int> lista, int a, int b)
        {
            if (a <= b)
            {
                if (a % 2 == 0)
                {
                    lista.Add(a);
                    return ListaValogatas(lista, a + 1, b);
                }
                else return ListaValogatas(lista, a + 1, b);   
            }    
            else return b;
        }
    }
}
