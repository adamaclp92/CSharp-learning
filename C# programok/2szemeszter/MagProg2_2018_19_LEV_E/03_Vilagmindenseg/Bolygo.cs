using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vilagmindenseg
{
    class Bolygo : Egitest
    {
        public Bolygo(string Azonosito)
            :this(Azonosito, null, 0)
        {
        }
        public Bolygo(string Azonosito, string Nev, ushort Eletkor)
            :base(Azonosito, Nev, Eletkor)
        {
            this.Azonosito += "-B";
            //KeringesiTavolsag -> minimum érték
        }
        public Bolygo(string Azonosito, string Nev, ushort Eletkor,
            BolygoOsztaly Osztaly, float KeringesiTavolsag)
            : this(Azonosito, Nev, Eletkor)
        {
            this.Osztaly = Osztaly;
            this.KeringesiTavolsag = KeringesiTavolsag;
        }

        public BolygoOsztaly Osztaly { get; set; }

        //[0,37; 30,07]
        public float KeringesiTavolsag { get; set; }

        public bool Foldszeru
        {
            get
            {
                if (this.KeringesiTavolsag >= 0.9 &&
                    this.KeringesiTavolsag <= 1.1)
                    return true;
                return false;
            }
        }

        //BolygóOsztályFormat() -> string
        public override string ToString()
        {
            string minta = "Osztály: {0}\n" +
                "Keringési távolság: {1} CsE\n";
            return base.ToString() + 
                string.Format(minta,
                Osztaly, //Formázás
                KeringesiTavolsag);
        }
    }
}
