using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Eletkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az életkorod: ");
            int Eletkor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Te ");
            if (Eletkor >= 0 && Eletkor < 8) Console.Write("gyerek");
            else if (Eletkor >= 8 && Eletkor < 18) Console.Write("fiatalkorú");
            else if (Eletkor >= 18 && Eletkor < 60) Console.Write("felnőtt");
            else if (Eletkor >= 60 && Eletkor <= 120) Console.Write("nyugíjas");
            else Console.Write("nem létező személy");
            Console.WriteLine(" vagy. ");

            Console.ReadLine();
        }
    }
}
