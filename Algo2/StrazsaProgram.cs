using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrazsaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            StrazsaLista<string> lista = new StrazsaLista<string>();
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
