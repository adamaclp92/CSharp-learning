using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// írta Ragó Ádám
/*
 2018.09.14 
 Eger C épület 104.
 */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a neved!");
            string nev = Console.ReadLine();
            Console.WriteLine("Add meg a testsúlyod kg-ban!");
            int suly = Convert.ToInt32(Console.ReadLine());
            //konvertál stringből intbe
            Console.WriteLine("Add meg a magasságod cm-ben!");
            float magas = float.Parse(Console.ReadLine());
            // ez is konvertál
            magas = magas / 100;
            float BMI = (float)(suly / (Math.Pow(magas, 2)));
           // Console.WriteLine("Kedves {0}!", nev);
           // Console.WriteLine("A testtömeg indexed: {0}", BMI);
            Console.WriteLine("Kedves {0}! A testtömeg indexed: {1}", nev, BMI);

            if (BMI < 16)
                Console.WriteLine("Súlyosan sovány");
            else if  (BMI < 17)
            Console.WriteLine("Mérsékelt sovány");
            else if (BMI < 18.5)
            Console.WriteLine("Enyhe sovány");
            else if (BMI < 25)
            Console.WriteLine("Normális");
             else if (BMI < 30)
            Console.WriteLine("Túlsúlyos");
            else if (BMI < 35)
            Console.WriteLine("I. fokú elhízás");
            else if (BMI < 40)
            Console.WriteLine("II. fokú elhízás");
            else 
            Console.WriteLine("III. fokú elhízás");
         
            Console.ReadKey();
        }
    }
}
