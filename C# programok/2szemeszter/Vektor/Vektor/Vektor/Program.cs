using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor
{
     
    
    class Program
    {
        static Random rnd = new Random();

        class Vektor
        {
            public void Beolvas(float[] tomb)
            {
                for (int i = 0; i < tomb.Length; i++)
                {
                    tomb[i] = rnd.Next(1, 101);
                }
            }

            public void Kiir(float[] tomb)
            {
                for (int i = 0; i < tomb.Length; i++)
                {
                    Console.WriteLine(tomb[i]);
                }
            }

            public float skalarszorzat(float[] tomb1, float[] tomb2)
            {
                float szorzat = 0;
                for (int i = 0; i < tomb1.Length; i++)
                {
                    szorzat = tomb1[i] * tomb2[i];
                }
                return szorzat;
            }
        }

        static void Main(string[] args)
        {
            float[] vektor = new float[1];
            float[] vektor2 = new float[1];
            Vektor v = new Vektor();
            Vektor d = new Vektor();
            v.Beolvas(vektor);
            v.Kiir(vektor);
           float d =  v.skalarszorzat(vektor, vektor2);
            Console.WriteLine("{0}", d);
            Console.ReadLine();


        }
    }
}
