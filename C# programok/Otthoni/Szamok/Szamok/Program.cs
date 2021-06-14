using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarálás
            int minimum = 100;
            int maximum = 0;
            int paros = 0;
            int osszeg = 0;
            int i = 1;

            //Ciklus
            while (osszeg <= 100 && i <= 10)
            {
                Console.Write("Add meg a(z) {0}. számot: ", i);
                int a = Int32.Parse(Console.ReadLine());
                osszeg = a + osszeg;
                
                //Legnagyobb és legkisebb szám és a páros szám feltétele
                if (a > maximum)
                { maximum = a; }
                if (a < minimum)
                { minimum = a; }
                if (a % 2 == 0)
                { paros = a; }

                //Csak a pozitív számok figyelembevétele
                if (a < 1)
                {
                    Console.WriteLine("Ez nem pozitív szám. Nem lesz figyelembe véve az összegképzés során!");
                    osszeg = osszeg - a;
                }

                //Ha eléri a 10 bekért számot
                if (i == 10)
                { Console.WriteLine("10 darab számot adtál meg. Ezeknek az összegük: {0}", osszeg); }

                //Ha eléri a bekért számok összege a 100-at
                if (osszeg >= 100)
                {
                    Console.WriteLine("Az összeg 100 fölött van! Az eredmény: {0}", osszeg);
                    break;
                }
                i = i + 1;
            } //Ciklus vége

            //A legkisebb és legnagyobb számok kiíratása
            Console.WriteLine("A megadott számok közül a legkisebb: {0}", minimum);
            Console.WriteLine("A megadott számok közül a legnagyobb: {0}", maximum);

            //Páros és páratlan meghatározása
            if (paros > 0)
            { Console.WriteLine("Volt a számok között páros? Igen!"); }
            else
            { Console.WriteLine("Volt a számok között páros? Nem!"); }
            Console.ReadKey();
        }
    }
}

/*Addig kérjünk be számokat billentyűzetről, amíg azok összege el nem éri a 100-at. A végén írjuk ki a képernyőre a számok összegét.

Lehetséges módosítások:

a bekérést hagyjuk abba, ha elérjük a 100 összeget, de legfeljebb 10 db számot
csak a pozitív számokat vegyük figyelembe az összegképzés során
írjuk ki a legkisebb és legnagyobb értéket amelyet beírtak
határozzuk meg, volt-e a beírt értékek között páros szám (igen/nem)
Ragó Ádám
PTI FOSZ */