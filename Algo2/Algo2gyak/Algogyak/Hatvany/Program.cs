using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatvany
{
    /*
     FÜGGVÉNY Hatvany(alap, kitevo: egész)
     ALGORITMUS
        HA (kitevo != 0) AKKOR
            Hatvany <- alap * Hatvany(alap * kitevo-1);
        KÜLÖNBEN
            Hatvany <- 1;
         HVÉGE;
     FVÉGE;
         */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hatvany(5, 3));
            Console.ReadLine();
        }

        static int Hatvany(int alap, int kitevo)
        {
            if (kitevo != 0)
                return alap * Hatvany(alap, kitevo - 1);
            else return 1;
        }
    }
}
