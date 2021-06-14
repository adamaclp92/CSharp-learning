using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombrendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            for (int i = 0; i <tomb.Length; i++)
            {
                tomb[i] = i / 2 + (8 * i - 1) / 3;  //ez egy példafeltöltés, hogy legyenek a tömbben tetszőleges elemek
                Console.Write("{0}, ",tomb[i]);
            }
            
            //Bináris keresés

            int E, V, K;
            E = 0;
            V = tomb.Length;
            K = (E + V) / 2;
            int lepes=0;

            int keresettElem = 101;
            while(E <= V && keresettElem!=tomb[K])
            {
                lepes++;
                if (keresettElem > tomb[K])
                    E = K + 1;
                else
                    V = K - 1;
                K = (E + V) / 2;
            }
            Console.WriteLine();
            Console.WriteLine("Helye: {0}", K);
            Console.WriteLine("Lépésszám: {0}", lepes);
            if (E <= V) Console.WriteLine("Benne van");
            else Console.WriteLine("Nincs benne");
            Console.WriteLine(E+ " " + V);




            Console.ReadKey();
        }
    }
}
