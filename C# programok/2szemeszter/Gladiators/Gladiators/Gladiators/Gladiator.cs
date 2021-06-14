using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    enum Eredet
    { romai, trak, gall, pun }

    class Gladiator
    {
        private int sorszam;
        public int Sorszam
        {
            get { return sorszam; }
           
        }

        private int evekSzama;
        public int EvekSzama
        {
            get { return evekSzama; }
            set
            {
                if (value < 0 || value > 10)
                    throw new WrongYearsNumber(value);
               else evekSzama = value;
            }
        }

        private Eredet eredet;
        public Eredet Eredet
        { get { return eredet; }  }

        private bool felszabadult_e = false;
        public bool Felszabadult_e
        {
            get { return felszabadult_e; }
            set
            {
                if (evekSzama == 10)
                    felszabadult_e = true; 
            }
        }

        private bool eletbenVan_e = true;
        public bool EletbenVan_e
        {
            get { return eletbenVan_e; }
            set { eletbenVan_e = value; }
        }

        List<Gladiator> gladiatorok = new List<Gladiator>();

        public void Add(Gladiator g)
        {
            gladiatorok.Add(g);

        }

        public Gladiator this[int index]
        {
            get
            {
                return gladiatorok[index];
            }
        }

        public Gladiator(int sorszam, int evekSzama, Eredet eredet)
        {
            this.sorszam = sorszam;
            this.EvekSzama = evekSzama;
            this.eredet = eredet;
        }

        
    }
}
