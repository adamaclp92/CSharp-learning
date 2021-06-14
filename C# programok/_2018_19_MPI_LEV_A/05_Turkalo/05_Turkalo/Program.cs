using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Turkalo
{
    class Program
    {
        //Egy turkálóban minden póló ára 500 Ft. Ha valaki két
        //pólót vásárol, akkor a második ára már csak 450 Ft.
        //Három, vagy annál több póló vásárlása esetén a harmadiktól
        //kezdve minden póló ára 400 Ft.
        //Írjon programot, mely bekéri a vásárolni kívánt pólók
        //számát, majd kiírja a fizetendő összeget.

        static void Main(string[] args)
        {
            Console.Write("Adja meg a pólók számát: ");
            int db = Convert.ToInt32(Console.ReadLine());

            Console.Write("A fizetendő összeg ");
            if (db == 1) Console.Write(500);
            else if (db == 2) Console.Write(950);
            else Console.Write(950 + (db - 2) * 400);
            Console.WriteLine(" Ft.");

            Console.ReadLine(); 
        }
    }
}
