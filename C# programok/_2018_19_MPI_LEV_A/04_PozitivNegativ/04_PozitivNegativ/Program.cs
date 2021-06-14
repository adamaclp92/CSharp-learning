using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PozitivNegativ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot!");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("A(z) {0} pozitív.", a);
            }
            else if (a < 0)
            {
                Console.WriteLine("A(z) {0} negatív.", a);
            }
            else
            {
                Console.WriteLine("A(z) {0} se nem pozitív, se nem negatív.", a);
            }
            Console.ReadLine();
        }
    }
}
