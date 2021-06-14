using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasprogr2
{
    class Uralkodo
    {
        /// <summary>
        /// Az uralkodás kezdete (év)
        /// </summary>
        private int kezdetiEv;  //adat elrejtése, hogy ne tudják illetéktelenek felülírni
        public int KezdetiEv //property-k
        {
            get  //ezzel lehet olvasni az értéket, általában publikus
            {
                return kezdetiEv; //visszaadja a mező értékét
            }
            private set //általában privát, ha nem akarjuk, hogy valaki módosítson rajta
            {
                if (value <= DateTime.Today.Year)
                    kezdetiEv = value; //beállítandó érték
                else
                    throw new Exception("Az évszám nem lehet korábbi, az aktuális évnél!");  //hibaüzenet
            }
        }

        /// <summary>
        /// Az uralkodás hossza (években)
        /// </summary>
        private byte uralkodasHossz;

        public byte UralkodasHossz //property-k
        {
            get  
            {
                return uralkodasHossz; //visszaadja a mező értékét
            }
            set
            {
                if (value > 100)
                    throw new Exception("Az uralkodás hossza nem lehet nagyobb 100-nál");  //hibaüzenet

                if (value < 1)
                    throw new Exception("Az uralkodás hossza minimum 1 év");

                else
                    uralkodasHossz = value;
            }
        }

        /// <summary>
        /// A nép elégedettsége (0-10, 0 a zsarnok, 10 a kedvelt)
        /// </summary>
        private byte elegedettseg;

        public byte Elegedettseg
        {
            get 
            { 
                return elegedettseg; 
            }
            set 
            {
                if (value > 10)
                    throw new Exception("Az elégedettség maximum 10 lehet.");
                else
                elegedettseg = value; 
            }
        }

        public Uralkodo(int KezdetiEv, byte UralkodasHossz, byte Elegedettseg) //konstruktor (az osztály nevével kell megegyezőnek lennie, nincs visszatérési típusa)
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
        /// <param name="u2">A 2. uralkodó</param>
        /// <returns>true, ha átfedésben vannak; false az egyébként</returns>
        public bool Atfed(Uralkodo u2)
        {
            Uralkodo u1 = this;  //az aktuális példányra lehet vele hivatkozni
            if (u1.kezdetiEv > u2.kezdetiEv)
            {
                Uralkodo temp = u1;
                u1 = u2;
                u2 = temp;
            }
            if (u1.kezdetiEv + u1.uralkodasHossz < u2.kezdetiEv)
                return false;
            else return true;

            // return u1.kezdetiEv + u1.uralkodasHossz >= u2.kezdetiEv;   <-- ugyanaz, mint az if-es megoldás
        }
        public override string ToString() //példányszintű metódus, nem kell a static, a stringgel lehet elérni, hogy ne csak a konzolra legyen érvényes a metódus  
        {
         return string.Format("{0} évtől uralkodott {1} éven keresztül. Elégedettség: {2}", kezdetiEv, uralkodasHossz, elegedettseg);  //ugyanaz, mint a Console.WriteLine, de így tudjuk más helyre is kiírni
        }

        }
}
