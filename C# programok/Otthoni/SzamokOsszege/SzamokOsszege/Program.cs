using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamokOsszege
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Adj meg egy számot");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a következő számot");
            double y = double.Parse(Console.ReadLine());
           
            if (x > 0 && y > 0)
            {
                while (x + y <100)
                {
                    double z = x + y;
                    Console.WriteLine("Az eddig eredmény: {0}", z++);
                   
                    Console.WriteLine("Add meg a következő számot");
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());*/






            Console.WriteLine("Adj meg egy számot");
            float x = float.Parse(Console.ReadLine());
            /* if (x > 0)
             {
                 Console.WriteLine("Add meg a következő számot");
             }
             else
             {
                 Console.WriteLine("A megadott szám nem pozitív! Próbáld újra!");
                 Console.ReadKey();
             }*/
            Console.WriteLine("Add meg a következő számot");
            float y = float.Parse(Console.ReadLine());
            /*  if (y < 0)
              {

                      Console.WriteLine("A megadott szám nem pozitív! Próbáld újra!");
                  }
              else  
              {*/


            // ha a bekért darabszám eléri a 8+2-t.
            for (byte a = 1; a <= 8; a++)
            {
                while (x > 0 && y > 0)
                {
                    //  ha az összeg eléri a százat
                    if (x + y < 100)
                    {

                        Console.WriteLine("Az eddig eredmény: {0}", x + y);
                        y = y + x;
                        Console.WriteLine("Add meg a következő számot");
                        x = float.Parse(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine("Az eredmény: {0}", x + y);
                        Console.WriteLine("A legkisebb érték: {0}", Math.Min(x, y));
                        Console.ReadKey();
                    }

                }
            }
                Console.WriteLine("Az eredmény: {0}", x + y);
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
Powered by Adam Rago*/
