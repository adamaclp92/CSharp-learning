using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadandowinform
{
    class uvegkontener
    {
        List<uvegek> uvegek = new List<uvegek>();

        public void Hozzaad(uvegek u)
        {
            if (u == null) throw new Exception("Nem lehet üres értéket hozzáadni!");

            uvegek.Add(u);
        }

        public uvegek this[int index]
        {
            get
            {
                return uvegek[index];
            }
            set
            {
                uvegek[index] = value;

            }

        }

        public int uvegfajtakszama()
        {
            int s = 0;

            foreach (uvegek u in uvegek)
            {
                s++;
            }

            return s;
        }

        public int fizetendo(int[] tomb)
        {
            int s = 0;
            int i = 0;
            foreach (uvegek u in uvegek)
            {
                s += tomb[i] * u.Uvegar;
                i++;
            }

            return s;
        }

   

        public void listaz()
        {

            foreach (uvegek u in uvegek)
            {
                Console.WriteLine(u);
            }
        }

    }
}
