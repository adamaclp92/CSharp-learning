using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uralkodok
{
    class Uralkodo
    {
        /// <summary>
        /// Az uralkodás kezdete (év)
        /// </summary>
        private int kezdetiEv;
        public int KezdetiEv
        {
            get
            {
                return kezdetiEv;
            }
            private set
            {
                if (value <= DateTime.Today.Year)
                    kezdetiEv = value;
                else
                    throw new Exception("Az évszám nem lehet korábbi az aktuális évnél!");
            }
        }

        /// <summary>
        /// Az uralkodás hossza (év)
        /// </summary>
        private byte uralkodasHossz;
        public byte UralkodasHossz
        {
            get
            {
                return uralkodasHossz;
            }
            set
            {
                if (value > 100)
                    throw new Exception("Az uralkodás hossza nem lehet nagyobb 100-nál");
                if (value < 1)
                    throw new Exception("Az uralkodás hossza min. 1 év");

                uralkodasHossz = value;
            }
        }

        /// <summary>
        /// A nép elégedettsége (0..10 skálaérték, 0=zsarnok gyűlölt uralkodó, 10=kedvelt jóságos és igazságos)
        /// </summary>
        private byte elegedettseg;

        public byte Elegedettseg
        {
            get { return elegedettseg; }
            set {
                if (value > 10)
                    throw new Exception("Az elégedettség max. 10 lehet");

                elegedettseg = value;
            }
        }

        public Uralkodo(int KezdetiEv, byte UralkodasHossz, byte Elegedettseg)
        {
            this.KezdetiEv = KezdetiEv;
            this.UralkodasHossz = UralkodasHossz;
            this.Elegedettseg = Elegedettseg;
        }

        public Uralkodo(int KezdetiEv, byte UralkodasHossz) : this(KezdetiEv, UralkodasHossz, 10)
        {
        }


        /// <summary>
        /// Vajon 2 uralkodó uralkodása átfedi-e egymást?
        /// </summary>
        /// <param name="u1">Az 1. uralkodó</param>
        /// <param name="u2">Az 2. uralkodó</param>
        /// <returns>true, ha átfedésben vannak; hamis, egyébként</returns>
        public bool Atfed(Uralkodo u2)
        {
            Uralkodo u1 = this;
            if (u1.kezdetiEv > u2.kezdetiEv)
            {
                Uralkodo temp = u1;
                u1 = u2;
                u2 = temp;
            }
            return u1.kezdetiEv + u1.uralkodasHossz >= u2.kezdetiEv;
        }



        public override string ToString()
        {
            return string.Format("{0} évtől uralkodott {1} éven keresztül. Elégedettség: {2}",
                    kezdetiEv, uralkodasHossz, elegedettseg);
        }
    }
}
