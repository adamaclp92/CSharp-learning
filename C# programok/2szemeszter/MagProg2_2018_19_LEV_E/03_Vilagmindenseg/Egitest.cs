using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vilagmindenseg
{
    //Ctrl + M + O: Összezár mindent
    //Ctrl + M + L: Kinyit mindent
    //Ctrl + K + D: Összerendezi a kódot

    class Egitest
    {
        #region Konstruktorok
        public Egitest(string Azonosito)
        {
            this.Azonosito = "E-" + Azonosito;
        }
        /// <summary>
        /// Az égitest legbővebb konstruktora.
        /// </summary>
        /// <param name="Azonosito">Egész szám, 7 karakterig balról feltöltve '0-ákkal'</param>
        /// <param name="Nev">Vagy null, vagy legalább 2 karakter hosszú szöveg</param>
        /// <param name="Eletkor">Az életkort millió években mérjük.</param>
        public Egitest(string Azonosito,
            string Nev, ushort Eletkor)
            : this(Azonosito)
        {
            this.Nev = Nev;
            this.Eletkor = Eletkor;
        }
        #endregion

        #region Mezők és property-k
        private string azonosito;
        public string Azonosito
        {
            protected set
            {
                if (value != null && value.Length >= 5)
                    azonosito = value;
                else throw new Exception("Hibás azonoító");
            }
            get { return azonosito; }
        }

        private string nev;
        public string Nev
        {
            set
            {
                if (value == null || value.Length >= 2)
                    nev = value;
                else throw new Exception("Hibás név!");
            }
            get { return nev; }
        }

        private ushort eletkor;
        /// <summary>
        /// Az életkort millió években mérjük.
        /// </summary>
        public ushort Eletkor
        {
            set
            {
                if (value >= 13600)
                    throw new Exception("Semmi sem lehet öregebb az Univerzumnál!");
                eletkor = value;
            }
            get { return eletkor; }
        }
        #endregion

        #region Megjelenítés
        public override string ToString()
        {
            string minta = "Azonosító: {0}\n" +
                "Név: {1}\n" +
                "Életkor: {2} millió év\n";
            return string.Format(minta,
                Azonosito,
                Nev == null ? "-" : Nev,
                Eletkor);
        }
        #endregion
    }
}
