using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_Rago_Adam
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaElem<int> elso = new ListaElem<int>();
            elso.adat = 12;

            ListaElem<int> masodik = new ListaElem<int>();
            masodik.adat = 5;
            elso.kov = masodik;

            ListaElem<int> harmadik = new ListaElem<int>();
            harmadik.adat = 90;
            masodik.kov = harmadik;

            Console.WriteLine(elso.adat);
            Console.WriteLine(elso.kov.adat);
            Console.WriteLine(elso.kov.kov.adat);

            Console.WriteLine();

            LancoltLista<string> lista = new LancoltLista<string>();
            lista.Add("a");
            lista.Add("b");
            lista.Add("c");

            lista.ForEach((adat) =>
            {
                Console.WriteLine(adat);
            });

            Console.WriteLine();
            lista.Insert("d", 0);
            lista.Insert("e", 1);
            lista.Insert("f", 4);
            lista.ForEach(Console.WriteLine);


            Console.WriteLine();
            lista.Remove("c");

            lista.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine(lista.Contains("e"));
            Console.WriteLine(lista.Contains("c"));

            Console.WriteLine();
            lista.RemoveAt(3);
            lista.ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
