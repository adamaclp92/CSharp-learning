using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Körpont
{
    class Pont
    {
       public int x;
       public int y;
    }

    
    class Program
    {
        static void HanyPontKor(double r, Pont[] pontok, Pont O)
        {
            int rajta = 0;
            int belul = 0;
            int kivul = 0;
            for (int i = 0; i < pontok.Length; i++)
            {
                if (Math.Sqrt(pontok[i].x - O.x * pontok[i].x - O.x + pontok[i].y - O.y * pontok[i].y - O.y) == r)
                    rajta++;
                else if (Math.Sqrt(pontok[i].x - O.x * pontok[i].x - O.x + pontok[i].y - O.y * pontok[i].y - O.y) > r)
                    kivul++;
                else belul++;
            }
        }

        

       


        static void Main(string[] args)
        {
        }
    }
}
/*Adott koordinátáival a sík egy pontja és az origó középpontú sugarú kör. Adjuk meg azt a logikai kifejezést, amely akkor igaz, ha a pont
*/