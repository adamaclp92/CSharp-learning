using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LancoltLista lista = new LancoltLista();
            lista.VegereBeszur(12);
            lista.VegereBeszur(5);
            lista.VegereBeszur(90);
            lista.VegereBeszur(3);

            lista.ForEach(Console.WriteLine);

            Console.ReadLine();
            
        }
    }
}
