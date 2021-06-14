using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_Elotti_Feladat
{
    class AtlagErtek
    {
        public AtlagErtek()
        {
            Console.WriteLine("Harmadik feladat");
            Console.WriteLine();

            Random rand = new Random();
            int[] VeletlenSzamok = new int[25];
            List<int> SzamokEgyszer = new List<int>();
            int SzamokOsszege = 0;
            double Atlag = 0;

            //tömb feltöltés
            for (int i = 0; i < VeletlenSzamok.Length; i++)
            {
                VeletlenSzamok[i] = rand.Next(10, 81);
                SzamokOsszege = SzamokOsszege + VeletlenSzamok[i];
            }

            //átlag számolás
            Atlag = SzamokOsszege / VeletlenSzamok.Length;

            //hozzá adás és ellnőrzés
            for (int i = 0; i < VeletlenSzamok.Length; i++)
            {
                if ((VeletlenSzamok[i] >= (Atlag*0.9)) && (VeletlenSzamok[i] <= (Atlag * 1.1)))
                {
                    VoltEMarBenne(ref SzamokEgyszer ,VeletlenSzamok[i]);
                }
            }

            //kiiratás
            Console.WriteLine("Ez(ek) a szám(ok) esik/esett bele az átlagba");
            for (int i = 0; i < SzamokEgyszer.Count; i++)
            {
                Console.WriteLine(SzamokEgyszer[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Folytatáshoz üss le egy gombot a billentyűzeten");
            Console.ReadKey();
        }

        private void VoltEMarBenne(ref List<int> SzamokEgyszer , int VeletlenSzam)
        {
            bool voltE = false;

            for (int i = 0; i < SzamokEgyszer.Count; i++)
            {
                if (SzamokEgyszer[i] == VeletlenSzam)
                {
                    voltE = true;
                }
            }
            if (!voltE)
            {
                SzamokEgyszer.Add(VeletlenSzam);
            }
        }
    }
}
