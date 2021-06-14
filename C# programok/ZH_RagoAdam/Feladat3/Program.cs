using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[40];
            int a;
            int b;
            uint x;

            do
            {
                Console.WriteLine("Add meg az 'A'-t:");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Add meg a 'B'-t:");
                b = int.Parse(Console.ReadLine());

                if (a < b)
                {
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        tomb[i] = rnd.Next(a, b);
                    }
                }
                else if (a > b)
                {
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        tomb[i] = rnd.Next(b, a);
                    }
                }

            } while (a == b);

            do
            {
                Console.WriteLine("Adj meg egy pozitív számot!");

            } while (!uint.TryParse(Console.ReadLine(), out x) || x==0);

            Console.WriteLine("A tömb elemei, melyek oszthatók {0}-val: ", x);
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % x == 0)
                {
                    Console.Write("{0}, ", tomb[i]);
                }
                else { }
            }
            Console.ReadLine();
        }
    }
}
/*Kérj be egy a és egy b számot.

Generálj le egy tömbbe 40 db. véletlen számot az [a,b] intervallumból. Figyelem: nem biztos, hogy a<=b, ezért kezeld az egyéb szituációt is!

Ezek után kérj be egy pozitív x számot. (Ehhez vizsgáld meg, hogy pozitív számot írt-e be a felhasználó, és ha nem, kérd be az x-et újra! A parse-olási hibát is kezeld!)

Írasd ki a tömb azon elemeit a képernyőre egy sorban (az elemeket vesszőkkel elválasztva), melyek oszthatóak x-szel.*/