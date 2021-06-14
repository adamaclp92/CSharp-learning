using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokonsag
{ 
    class Program
    {
        public static object EndWhile { get; private set; }

        static void Main(string[] args)
        {
            //névbekérés
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kérem az első férfi nevét!");
            String nev1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kérem a második férfi nevét!");
            String nev2 = Console.ReadLine();

            //születési év bekérés
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kérem {0} születési évét!", nev1);
            int ev1 = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kérem {0} születési évét!", nev2);
            int ev2 = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //abszolút érték
            int a = Math.Abs(ev1 - ev2);
            int b = ev1 - ev2;
            int c = ev2 - ev1;
            
            //feltétel
                   if (a < 18)
                Console.WriteLine("Valószínűleg testvérek");

                  else if (c > 0 && (18 <= a && 40 >= a))
                Console.WriteLine("Valószínűleg {0} az apja {1}-nak.", nev1, nev2);
                  else if (c > 0 && (40 < a && 60 > a))
                Console.WriteLine("Valószínűleg {0} a nagyapja {1}-nak.", nev1, nev2);
                  else if (c > 0 && (60 < a))
                Console.WriteLine("Valószínűleg {0} a dédnagyapja {1}-nak. És {2} az ükunoka.", nev1, nev2, nev2);

                  else if (b > 0 && (18 <= a && 40 >= a))
                Console.WriteLine("Valószínűleg {0} az apja {1}-nak.", nev2, nev1);
                  else if (b > 0 && (40 < a && 60 > a))
                Console.WriteLine("Valószínűleg {0} a nagyapja {1}-nak.", nev2, nev1);
                  else if (b > 0 && (60 < a))
                Console.WriteLine("Valószínűleg {0} a dédnagyapja {1}-nak. És {2} az ükunoka.", nev2, nev1, nev1);

            Console.ReadKey();

        }
    }
}
/*Tegyük fel, hogy van két férfi, akikről tudjuk hogy valamiféle rokoni kapcsolatban állnak egymással. 
 Kérjük be először a neveiket (pl. Lajos és Pista), majd kérdezzük meg a születési évüket (a kérdésben nevükkel hivatkozzunk rájuk: "kérem Lajos születési évét..."). 
 A születési évek szerint állapítsuk meg a közöttük lévő korkülönbséget, majd az alábbi alapján adjuk meg a lehetséges rokoni kapcsolat megnevezését:

korkülönbség nem nagyobb 18 évnél: valószínűleg testvérek
korkülönbség legalább 18 év, de nem több mint 40 év: az idősebbik a másik apja. Ezt megfelelő nevekkel írjuk ki, pl: ''valószínűleg Lajos az apja Pista-nak''
korkülönbség több mint 40 év, de kevesebb mint 60 év: nagyapa-unoka. Hasonlóan, nevekkel írjuk ki: ''valószínűleg Pista a nagyapja Lajos-nak''.
korkülönbség több mint 60 év: dédnagypapa-ükunoka. Hasonlóan, nevek kiírásával oldjuk meg.
Ügyeljünk a program írásakor arra, hogy nem lehet tudni előre, hogy a fiatalabb, vagy az idősebb férfi adatait vesszük előre. 
A program minden sorrend és minden korkülönbség esetén működjön helyesen!*/
//Powered by Ragó Ádám