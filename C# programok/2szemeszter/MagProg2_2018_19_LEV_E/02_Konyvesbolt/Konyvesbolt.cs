using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    class Konyvesbolt
    {
        private static uint Id = 1;

        public Konyvesbolt()
        {
            this.konyvek = new List<Konyv>();
        }

        private List<Konyv> konyvek;
        public List<Konyv> Konyvek
        {
            get {
                //List<Konyv> temp = new List<Konyv>();
                //foreach (Konyv konyv in konyvek)
                //    temp.Add(konyv);
                //return temp;
                return new List<Konyv>(konyvek);
            }
        }

        public void HozzaadKonyv(string Szerzo, string Cim)
        {
            Konyv konyv = new Konyv(Id, Szerzo, Cim);
            //konyv.Ar = 500;
            this.konyvek.Add(konyv);
            Id++;
        }
    }
}
