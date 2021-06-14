using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[25];
            int osszeg = 0;
            int kisebbnagyobb = 0;

            Console.WriteLine("A tömbünk:");

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(10, 80);
                osszeg = osszeg + tomb[i];

                Console.Write("{0} ", tomb[i]);
            }

            double atlag = osszeg / tomb.Length;

            Console.WriteLine("\nA tömb átlaga: {0}\nAz átlagérték 90%-tól kisebb és az átlagérték 110% nagyobb intervallumba \na következő számok tartoznak:", atlag);

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < (atlag*0.9) || tomb[i] > (atlag * 1.1))
                {
                    kisebbnagyobb++;
                    Console.Write(tomb[i]+" ");
                }
            }
            Console.WriteLine("\nDarabszám: {0}", kisebbnagyobb);
           
            Console.ReadLine();
        }
    }
}
/*3. feladat
Egy 25 elemű vektort töltsünk fel véletlen értékekkel (10-80 közötti számokkal)! 
Határozzuk meg a tömbelemek átlagát, és hogy hány olyan szám van, amelyik ezen átlagérték 90%-tól kisebb, vagy nagyobb mint az átlagérték 110%-a! 
Soroljuk fel ezen számokat!

Szorgalmi: A fenti kiíratásnál minden számot csak egyszer írhatunk ki!
Ragó Ádám*/
