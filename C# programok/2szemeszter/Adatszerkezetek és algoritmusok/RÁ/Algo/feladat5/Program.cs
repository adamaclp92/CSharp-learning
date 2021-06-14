using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat5
{
    /*FÜGGVÉNY Hánypontvanakörönkívül(p: pontsorozat, O:PONT, R: VALÓS): EGÉSZ;
     *  VÁLTOZÓK
     *      I: EGÉSZ;
     *      DB: EGÉSZ;
     *    ALGORITMUS
     *      DB <- 0;
     *      CIKLUS I <- 1...N
     *          HA(SQRT(P[I].X-O.X) * (P[I].X-O.X) + (P[I].Y-O.Y) * (P[I].Y-O.Y)) > R) AKKOR
     *              DB <- DB+1;
     *          HA_VÉGE;
     *      CIKLUS_VÉGE;
     * FÜGGVÉNY_VÉGE
     * */
    class Pont
    {
        public double x;
        public double y;
    
    }

    static int HanyPontVanAKoronKivul(Pont[] Pontok, Pont O, double r)
    {
    int db = 0;
        for (int i = 0; i < Pontok.Length; i++)
			{
			 
			}
    
    
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
