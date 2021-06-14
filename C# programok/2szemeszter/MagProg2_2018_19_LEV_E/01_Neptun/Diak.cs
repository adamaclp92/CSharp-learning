using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Neptun
{
    class Diak
    {
        private Diak()
        {
            this.Kreditek = 0;
        }
        public Diak(string Neptunkod) : this()
        {            
            this.Neptunkod = Neptunkod;
        }
        public Diak(string Neptunkod, string Nev, DateTime SzuletesiDatum)
            : this(Neptunkod)
        {
            this.Nev = Nev;
            this.SzuletesiDatum = SzuletesiDatum;
        }

        //Tartalmaznia kell space-t
        public string Nev;
        
        private string neptunkod;
        public string Neptunkod
        {
            set
            {
                if (value.Length == 6)
                    neptunkod = value.ToUpper();
                else throw new Exception("Hiba");
            }
            get
            {
                return neptunkod;
            }
        }

        private bool szuletesiDatumBeallitva = false;
        private DateTime szuletesiDatum;
        public DateTime SzuletesiDatum
        {
            /*private*/ set
            {
                //TimeSpan
                if (szuletesiDatumBeallitva)
                    throw new Exception("A születési dátumot csak egyszer állíthatod be!");
                if ((DateTime.Now - value).TotalDays / 365 < 17)
                    throw new Exception("A minimális életkor 17 év!");

                szuletesiDatum = value;
                szuletesiDatumBeallitva = true;
            }
            get
            {
                return szuletesiDatum;
            }
        }
        
        //private NemiIdentitas nem;
        //public NemiIdentitas Nem
        //{
        //    set { nem = value; }
        //    get { return nem; }
        //}
        public NemiIdentitas Nem { get; set; }

        public int Eletkor
        {
            get
            {
                return (int)(DateTime.Now - szuletesiDatum).TotalDays / 365;
            }
        }

        private int kreditek;
        public int Kreditek
        {
            set
            {
                if (value >= 0 && value <= 190)
                    kreditek = value;
                else throw new Exception("Hiba: A kreditek értke egész szám a [0; 190]-ből!\nA regisztrált érték: " + value);
            }
            get
            {
                return kreditek;
            }
        }

        public void Kiir()
        {            
            Console.WriteLine("Név: {0}", Nev);
            Console.WriteLine("Neptunkód: {0}", Neptunkod);
            Console.WriteLine("Születési dátum: {0}",
                SzuletesiDatum.ToString("yyyy.MM.dd"));
            Console.WriteLine("Nem: {0}", Nem);
            Console.WriteLine("Kreditek: {0}", Kreditek);
            Console.WriteLine();
        }

        public string DiakString()
        {
            string minta = "Név: {0}\n" +
                "Neptunkód: {1}\n" +
                "Születési dátum: {2}\n" +
                "Nem: {3}\n" +
                "Kreditek: {4}\n";
            return string.Format(minta,
                Nev,
                Neptunkod,
                SzuletesiDatum.ToString("yyyy.MM.dd"),
                Nem,
                Kreditek);
        }

        public override string ToString()
        {
            string minta = "Név: {0}\n" +
                "Neptunkód: {1}\n" +
                "Születési dátum: {2}\n" +
                "Nem: {3}\n" +
                "Kreditek: {4}\n" +
                "Életkor: {5} év\n";
            return string.Format(minta,
                Nev,
                Neptunkod,
                SzuletesiDatum.ToString("yyyy.MM.dd"),
                Nem,
                Kreditek,
                Eletkor);
        }
    }
}
