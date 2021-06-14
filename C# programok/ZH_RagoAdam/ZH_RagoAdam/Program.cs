using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_RagoAdam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cimek = new string[2];
            float[] negyzetmeter = new float[2];
            double[] ar = new double[2];

            for (int i = 0; i < cimek.Length; i++)
			{
			 
                Console.WriteLine("Add meg a(z) {0}. lakás címét.", i+1);
                cimek[i] = Console.ReadLine();

                Console.WriteLine("Add meg, hogy a(z) {0}. lakás hány négyzetméter.", i+1);
                negyzetmeter[i] = float.Parse(Console.ReadLine());

			}
            Console.WriteLine("Add meg a négyzetméter árat.");
            float negyzetmeterar = float.Parse(Console.ReadLine());


            for (int i = 0; i < negyzetmeter.Length; i++)
			{
                ar[i] = negyzetmeter[i] * negyzetmeterar;
			 Console.WriteLine("A(z) {0}. lakás ára: {1:F2} Ft.", i+1, ar[i]);
			}

            if (ar[0] > 40000000 && ar[1] > 40000000)
            {
                Console.WriteLine("Tök mindegy, melyik drágább, úgysem tudom megvenni.");
            }
            else if (ar[0] == ar[1])
            {
                Console.WriteLine("A {0} és {1} alatti lakások ugyanannyiba kerülnek.", cimek[0], cimek[1]);
            }

            else if (ar[0] > ar[1])
            {
                Console.WriteLine("A {0} alatti lakás drágább, mint a {1:F2} alatti lakás.", cimek[0], cimek[1]);
            }
            else 
            {
                Console.WriteLine("A {0} alatti lakás drágább, mint a {1:F2} alatti lakás.", cimek[1], cimek[0]);
            }
            Console.ReadLine();

           
        }
    }
}

/*Kérd be a felhasználótól 2 lakás címét és azt is, hogy hány négyzetméteresek (ez lehet tört szám is).

Ezek után kérd be, hogy hány Ft a négyzetméter ár.

Számítsd és írd ki a két lakás árát.

Ezek után vizsgáld meg, hogy a két lakás közül melyik drágább:

Ha mindkét lakás 40 millió Ft fölött van, akkor írd ki, hogy "Tök mindegy, melyik drágább, úgysem tudom megvenni."
Egyébként ha az áruk egyenlő, akkor írd ki, hogy "A ... és ... alatti lakások ugyanannyiba kerülnek."
Egyébként vizsgáld meg, hogy melyikük ára magasabb és írd ki, hogy "A ... alatti lakás drágább, mint a ... alatti lakás."*/