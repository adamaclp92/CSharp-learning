using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class CD:Aru,IMeghallgathato
    {
        private string eloado;

        public string Eloado
        {
            get { return eloado; }
            set
            {
                if (value.Length < 3) throw new TooShortException(value);
                eloado = value;
            }
        }

        private string cim;
        public string Cim
        {
            get { return cim; }
            set
            {
                if (value.Length < 3) throw new TooShortException(value);
                cim = value;
            }
        }

        private int hanyanHallgattakBele;
        public int HanyanHallgattakBele
        {
            get { return hanyanHallgattakBele; }
            set { hanyanHallgattakBele = value; }
        }

        int IMeghallgathato.HanyanHallgattakBele => throw new NotImplementedException();

        public void Belehallgat(CD x)
        {
            x.hanyanHallgattakBele++;

        }

        public bool Leselejtezheto_e(CD x)
        {
            return x.HanyanHallgattakBele > 500;
        }

        public CD(string azonosito, string eloado, string cim) : base(azonosito)
        {
            this.Eloado = eloado;
            this.Cim = cim;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", eloado, cim);
        }
    }
}

