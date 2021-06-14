using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{

    /*
      ELJÁRÁS BeuszoRendRek(lista: elemtípus, i: egész)
      VÁLTOZÓK
      k: elemtípus;
      j: egész;
      ALGORITMUS
           k <-lista[i];
           j <- i-1;
      AMÍG (j >= 0 ^ lista[j] < k)
           lista[j+1] <- lista[j];
           j <- j-1;
      CVÉGE;
      lista[j+1] <- k;
      HA i< lista.Hossz-1 AKKOR
           BeszuroRendRek <- BeszuroRendRek(lista, i+1);
      HVÉGE;
      EVÉGE;
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<double> l = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
			{
                l.Add(rnd.NextDouble() * 10);
                
			}
            
            BeszuroRendRek(l, 1);
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine("{0:N2}", l[i]);
            }
            Console.ReadLine();
        }

        static void BeszuroRendRek(List<double> lista, int i)
        {
                double k = lista[i];
                int j = i - 1;

                while (j >= 0 && lista[j] < k)
                {
                    lista[j + 1] = lista[j];
                    j = j - 1;
                }
                lista[j + 1] = k;

                if (i < lista.Count - 1)
            {
                BeszuroRendRek(lista, i + 1);
            }
        } 
    }
}
