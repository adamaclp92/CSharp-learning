using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Adatbekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Nev;
            //Nev = "Troll Ede";
            //string Nev = "Troll Ede";

            Console.Write("Add meg a neved: ");
            string Nev = Console.ReadLine();

            Console.Write("Add meg az életkorod: ");
            //string eletkor = Console.ReadLine();
            //int Eletkor = Convert.ToInt32(eletkor);
            int Eletkor = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            //Console.WriteLine("A neved " + Nev + 
            //    ", " + Eletkor + 
            //    " éves vagy és 10 év múlva " + (Eletkor + 10) +
            //    " éves leszel.");
            Console.WriteLine("A neved {0}, {1} éves vagy és 10 év múlva {2} leszel.",
                Nev, Eletkor, Eletkor + 10);

            Console.ReadLine();
        }
    }
}
