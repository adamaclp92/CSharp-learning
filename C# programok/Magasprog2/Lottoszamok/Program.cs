using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottoszamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte[] lotto = new Byte[5];

            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = (byte)rnd.Next(1, 91);

           //     bool egyezik = false;
                for (int j = 0; j < i; j++)
                {
                   if (lotto[i] == lotto[j])
                   {
                       i--;
                       break;
                  //     egyezik = true;
                   }
                }  
           /*     if (egyezik)
                {
                    i--;
                }
                */
            }
            Console.WriteLine("Lottószámok: ");
            foreach (byte x in lotto)
            {
                Console.Write("{0}, ", x);
            }
            Console.ReadKey();
        }
    }
}
