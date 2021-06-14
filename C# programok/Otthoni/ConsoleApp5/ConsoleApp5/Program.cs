using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int a = 0;
            int b = 1;
          
            for (int i = 1; i <= 10; i++)
            {
                
              
                Console.Write("{0}, ", a);
                int csere = a;
                a = b;
                b = csere + b;
            }*/
            int x1 = 0;
            int x2 = 1;

            for (int i = 0; i <=5 ; i++)
            {
                Console.Write("{0}, {1}, ", x1, x2);

                x1 = x1 + x2;
                x2 = x1 + x2;
            }
            Console.ReadKey();
        }  
    }
}
//1,1,2,3,5,8,13,21,34,55