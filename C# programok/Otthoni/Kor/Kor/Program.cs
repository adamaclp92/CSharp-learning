using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a kör sugarát!\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            float sugar = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\t A kör kerülete: {0} cm.", 2*sugar*Math.PI);
            Console.WriteLine("\t A kör területe: {0} cm2.", sugar*sugar*Math.PI);
            Console.WriteLine("A dátum: {0}", Convert.ToDateTime("2018/09/20 18:36:00"));
            Console.ReadKey();
        }
    }
}
