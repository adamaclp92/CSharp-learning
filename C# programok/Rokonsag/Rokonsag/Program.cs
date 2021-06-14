using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokonsag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az első nevet!");
            string nev1 = Console.ReadLine();
            Console.WriteLine("Kérem a második nevet!");
            string nev2 = Console.ReadLine();
            Console.WriteLine("Kérem {0} életkorát!",nev1);
            int kor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem {0} életkorát!",nev2);
            int kor2 = int.Parse(Console.ReadLine());
            if (kor2>kor1)
            {
                int temp = kor1;
                string tempn = nev1;
                kor1 = kor2;
                nev1 = nev2;
                kor2 = temp;
                nev2 = tempn;
            }
            int diff = kor1 - kor2;
            if (diff <= 18)
            {
                Console.WriteLine("{0} és {1} testvérek",nev1,nev2);
            }else if(diff <= 40)
            {
                Console.WriteLine("{0} az apa és {1} a fia",nev1,nev2);
            }else if (diff <= 60)
            {
                Console.WriteLine("{0} a nagyapa és {1} az unoka",nev1,nev2);
            }
            else
            {
                Console.WriteLine("{0} dédapja {1}nek",nev1,nev2);
            }
            Console.ReadKey();
        }
    }
}
