using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class HarciGladiator:Gladiator, IHarcos
    {
        private int harciKedv;

        public int HarciKedv
        {
            get { return harciKedv; }
            set
            {
                if (value < -5 || value > 5)
                    throw new WrongFightingLoveNumber(value);
                else harciKedv = value;
            }
        }

        public bool Megtamad(Gladiator ellenfel)
        {
           
            return !(ellenfel.Felszabadult_e) && ellenfel.EletbenVan_e  && EletbenVan_e && !Felszabadult_e;
        }

        private int esely;

        public int Esely
        {
            get { return harciKedv + EvekSzama; }
          
        }


        public HarciGladiator(int sorszam, int evekSzama, Eredet eredet, int harciKedv) :base(sorszam, evekSzama, eredet)
        {
            this.HarciKedv = harciKedv;
        }

        public override string ToString()
        {
            return string.Format("Sorszám: {0}\tÉvek száma: {1}\teredet: {2}\tharci kedv: {3}",Sorszam, EvekSzama, Eredet, harciKedv);
        }

    }
}
