using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TestTomegIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a magasságod: ");
            double magassag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a tömeged: ");
            int tomeg = Convert.ToInt32(Console.ReadLine());

            double BMI = (double)tomeg / Math.Pow(magassag, 2);

            Console.WriteLine(" A testömeg indexed {0:0.###} BMI.",
               BMI);
            Console.ReadLine();
        }
    }
}
