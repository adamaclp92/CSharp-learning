using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    class Program
    {
        static int Leglasabb(List<float> adatok)
        {
            float nagy=0;
            int nagyi =0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if(adatok[i] > nagy)
                {
                    nagy = adatok[i];
                    nagyi = i;
                }
            }
                      
            return nagyi;
        }
        static int Leggyorsabb(List<float> adatok)
        {
            float kicsi = adatok[Leglasabb(adatok)];
            int kisi = Leglasabb(adatok);
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i] < kicsi)
                {
                    kicsi = adatok[i];
                    kisi = i;
                }
            }

            return kisi;
        }
        static float atlag(List<float> adatok)
        {
            float szum = 0;
            
            for (int i = 0; i < adatok.Count; i++)
            {
                szum += adatok[i];
            }
            
            return szum/adatok.Count;
        }
        static void Main(string[] args)
        {
            List<string> tipus = new List<string>();
            List<float> gyorsul = new List<float>();
            do
            {
                Console.WriteLine("Add meg a kocsi típusát");
                tipus.Add(Console.ReadLine());
                float valami;
                if (tipus[tipus.Count - 1] != "") { 
                    do
                    {
                        Console.WriteLine("Add meg a {0} gyorsulását", tipus[tipus.Count - 1]);
                    } while (!float.TryParse(Console.ReadLine(), out valami));
                    gyorsul.Add(valami);
                }
            } while (tipus[tipus.Count-1]!="" );
            Console.WriteLine("A Leggyorsabb autó: {0}",tipus[Leggyorsabb(gyorsul)]);
            Console.WriteLine("A Leglassabb autó: {0}",tipus[Leglasabb(gyorsul)]);
            Console.WriteLine("Az átlag gyorsulásuk: {0}",atlag(gyorsul));
            Console.ReadKey();
        }
    }
}
