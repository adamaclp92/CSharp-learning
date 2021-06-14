using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
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

            Console.WriteLine();

            LancoltLista lista = new LancoltLista();
            lista.Add(32);
            lista.Add(42);
            lista.Add(11);

            lista.ForEach((adat) =>
            {
                Console.WriteLine(adat);
            });


            Console.WriteLine();

            lista.Insert(10, 0);
            lista.Insert(99, 1);
            lista.Insert(55, 4);
            lista.ForEach(Console.WriteLine);

            Console.WriteLine();
            lista.Remove(12);
            lista.Remove(11);
            lista.ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
