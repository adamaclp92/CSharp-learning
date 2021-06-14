using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LancoltLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaElem elso = new ListaElem();
            elso.adat = 10;

            ListaElem masodik = new ListaElem();
            masodik.adat = 15;
            elso.kov = masodik;

            ListaElem harmadik = new ListaElem();
            harmadik.adat = 23;
            masodik.kov = harmadik;

            Console.WriteLine(elso.adat);
            Console.WriteLine(elso.kov.adat);
            Console.WriteLine(elso.kov.kov.adat);
            //ez a tökölős

            LancoltLista lista = new LancoltLista();
            lista.Add(32);
            lista.Add(42);
            lista.Add(10);
            lista.Add(19);
            lista.Add(18);
            lista.Add(17);


            //Bejárás:
            Console.WriteLine("\nLáncolt lista bejárás:");
            ListaElem akt = lista.Fej;
            while (akt != null)
            {
                Console.WriteLine(akt.adat);
                akt = akt.kov;
            }

            lista.Remove(32);

            //Bejárás:
            Console.WriteLine("\nLáncolt lista bejárás:");
            akt = lista.Fej;
            while (akt != null)
            {
                Console.WriteLine(akt.adat);
                akt = akt.kov;
            }

            lista.Insert(99, 4);
            Console.WriteLine("\nLáncolt lista bejárás:");
            akt = lista.Fej;
            while (akt != null)
            {
                Console.WriteLine(akt.adat);
                akt = akt.kov;
            }
            

            //..vagy:
          /*  lista.ForEach((adat) =>
                {
                    Console.WriteLine(adat);
                });*/

            Console.ReadLine();
        }
    }
}
