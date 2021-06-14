using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symphonic
{
    enum typeOfStringed
    {
        csello, nagybogo, bracsa, hegedu, harfa, gitar, csembalo
    }
    class StringedInstrument:Instrument
    {
        //típus
        private typeOfStringed typeStringed;

        public typeOfStringed TypeStringed
        {
            get { return typeStringed; }
            set { typeStringed = value; }
        }

        //húrok száma
        private int numberOfString;

        public int NumberOfString
        {
            get { return numberOfString; }
            private set
            {
                if (value < 2) throw new Exception("A húrok számának minimum 2-nek kell lennie!");
                else
                    numberOfString = value;
            }
        }

        //vonó van hozzá?
        private bool bow;

        public bool Bow
        {
            get { return bow; }
            private set { bow = value; }
        }

        //elektromos-e
        private bool electric;

        public bool Electric
        {
            get { return electric; }
            private set { electric = value; }
        }

        public StringedInstrument(string name, int price, typeOfStringed typeStringed, int numberOfString, bool bow, bool electric)
            : base(name, price)
        {
            this.TypeStringed = typeStringed;
            this.NumberOfString = numberOfString;
            this.Bow = bow;
            this.Electric = electric;
        }

        public override string ToString()
        {
            return string.Format("{0}, típus: {1}, húrok száma: {2}, vonó van hozzá: {3}, elektromos: {4}", base.ToString(), typeStringed, numberOfString, bow, electric);
        }
    }
}
