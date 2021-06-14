using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bekérés
            Console.WriteLine("Ez a program egy szám prímtényezős felbontását mutatja be");
            Console.WriteLine("Adj meg egy nem prím számot");
            int a = Int32.Parse(Console.ReadLine());
            Console.Clear();
            #endregion



            /*  while (i <= a)
                  if (a % i == 0)
                  {
                      a = a / i;
                      Console.Write("{0}*", i);
                  }
                  else
                  {
                      i++;
                  } */
          
            for (int i = 2; i < a;)
            {
                if (a % i == 0)
                {
                    a = a / i;
                    Console.Write("{0}*", i);
                }
                else
                {
                    i++;
                }

            }
      Console.ReadKey();
        }
    }
}
