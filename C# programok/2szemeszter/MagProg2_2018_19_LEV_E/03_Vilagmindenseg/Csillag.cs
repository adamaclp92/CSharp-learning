using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vilagmindenseg
{
    class Csillag : Egitest
    {
        #region Konstruktorok
        public Csillag(string Azonosito)
            :this(Azonosito, null, 0)
        {
        }
        public Csillag(string Azonosito, string Nev, ushort Eletkor)
            :base(Azonosito, Nev, Eletkor)
        {
            this.Azonosito += "-CS";
        }
        public Csillag(string Azonosito, string Nev, ushort Eletkor,
            CsillagOsztaly Osztaly, float Atmero)
            : this(Azonosito, Nev, Eletkor)
        {
            this.Osztaly = Osztaly;
            this.Atmero = Atmero;
        }
        #endregion

        #region Mezők és property-k
        public CsillagOsztaly Osztaly  { get; set; }

        private float atmero;
        /// <summary>
        /// Az átmérőt Napátmérő (NA) mérjük.
        /// </summary>
        public float Atmero
        {
            set
            {
                if (value >= 0 && value <= 1420)
                    atmero = value;
                else throw new Exception("Hibás átmérő!");
            }
            get { return atmero; }
        }
        #endregion

        #region Függvények és metódusok
        public bool Hasonlo(Csillag masik)
        {
            //Ugyanaz az osztályuk és az átmérőjük 20%-ban tér el legfeljebb
            if (this.Osztaly == masik.Osztaly &&
                Math.Abs(this.Atmero - masik.Atmero) < ((30.07 - 0.37) / 100) * 20)
                return true;
            return false;
        }
        #endregion

        #region Megjelenítés
        private static string CsillagOsztalyFormat(CsillagOsztaly Osztaly)
        {
            switch (Osztaly)
            {
                case CsillagOsztaly.BARNATORPE:
                    return "Barna törpe";
                case CsillagOsztaly.VOROSORIAS:
                    return "Vörös óriás";
                case CsillagOsztaly.FEHERTORPE:
                    return "Fehér törpe";
                case CsillagOsztaly.HALAL:
                    return "Halálcsillag";
                case CsillagOsztaly.HALAL2:
                    return "2. Halálcsillag";
                case CsillagOsztaly.NEUTRON:
                    return "Neutroncsillag";
                default:
                    throw new Exception("Utólag definiált osztály!");
            }
        }
        public override string ToString()
        {
            string minta = "Osztály: {0}\n" +
                "Átmérő: {1} CsE\n";
            return base.ToString() +
                string.Format(minta,
                CsillagOsztalyFormat(Osztaly),
                Atmero);
        }
        #endregion
    }
}