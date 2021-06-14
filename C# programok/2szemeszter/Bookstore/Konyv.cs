using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Konyv:Aru,IOlvashato
    {
        private string szerzo;

        public string Szerzo
        {
            get { return szerzo; }
            set
            {
                if (value.Length < 5) throw new TooShortException(value);
                szerzo = value;
            }
        }

        private string cim;

        public string Cim
        {
            get { return cim; }
            set
            {
                if(value.Length < 5) throw new TooShortException(value);
                cim = value;
            }
        }
        private int oldalszam;

        public int Oldalszam
        {
            get { return oldalszam; }
        }

        private int hanyanOlvastakBele;
        public int HanyanOlvastakBele
        {
            get { return hanyanOlvastakBele; }
            set { hanyanOlvastakBele = value; }
        }

        int IOlvashato.HanyanOlvastakBele => throw new NotImplementedException();

        public void Beleolvas(Konyv x)
        {
            x.hanyanOlvastakBele++;    
        }

        public bool Learazhato_e(Konyv x)
        {
            return x.HanyanOlvastakBele > 1000;
        }

        public Konyv(string azonosito, string szerzo, string cim, int oldalszam) : base(azonosito)
        {
            this.Szerzo = szerzo;
            this.Cim = cim;
            this.oldalszam = oldalszam;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}, oldalszám: {2}", szerzo, cim, oldalszam);
        }
    }
}


