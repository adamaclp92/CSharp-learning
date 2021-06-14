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

            LancoltLista lista = new LancoltLista();
            lista.Add(32);
            lista.Add(42);
            lista.Add(11);

            // Bejárás:
            //ListaElem akt = lista.Fej;
            //while (akt != null)
            //{
            //    Console.WriteLine(akt.adat);
            //    akt = akt.kov;
            //}

            // ...vagy:
            lista.ForEach((adat) =>
            {
                Console.WriteLine(adat);
            });

            Console.WriteLine();
            lista.Insert(10, 0);
            lista.Insert(99, 1);
            lista.Insert(55, 0);
            lista.ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
