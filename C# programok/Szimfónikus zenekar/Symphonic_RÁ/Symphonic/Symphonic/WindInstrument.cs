using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symphonic
{
    enum typeOfWind
    {
        fafuvos,rezfuvos, sip, trombita, harsona, kurt, fuvola, oboa, klarinet
    }
    class WindInstrument:Instrument
    {
        //típus
        private typeOfWind typeWind;

        public typeOfWind TypeWind
        {
            get { return typeWind; }
            private set { typeWind = value; }
        }

        //percenként termelődő nyál
        private float droolPerMin;

        public float DroolPerMin
        {
            get { return droolPerMin; }
            private set
            {
                if (value <= 0) throw new Exception("A termelődő nyál pozitív tört szám lehet csak.");
                else
                    droolPerMin = value;
            }
        }

        public WindInstrument(string name, int price, typeOfWind typeWind, float droolPerMin)
            : base(name, price)
        {
            this.TypeWind = typeWind;
            this.DroolPerMin = droolPerMin;
        }

        public override string ToString()
        {
            return string.Format("{0}, típus: {1}, percenként termelődő nyál: {2} dl", base.ToString(), typeWind, droolPerMin);
        }
    }
}
