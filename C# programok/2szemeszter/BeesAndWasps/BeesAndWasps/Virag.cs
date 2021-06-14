using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesAndWasps
{
    class Virag
    {
        private string nev;

        public string Nev
        {
            get { return nev; }
            set {
                if (value.Length < 3) throw new NameTooShortException(value);
                nev = value; }
        }

        private uint beporzasokSzama;
        public uint BeporzasokSzama
        {
            get { return beporzasokSzama; }
        }

        public void Beporoztak()
        {
            beporzasokSzama++;
        }

        private int nektarMennyiseg;

        public int NektarMennyiseg
        {
            get { return nektarMennyiseg; }
            set { 
                if(value < 0)
                    throw new NegativNumberException(value);
                nektarMennyiseg = value; }
        }


        private static Random rnd = new Random();

        public void NektartAd()
        {
            nektarMennyiseg -= rnd.Next(nektarMennyiseg + 1); //csak a felsőkorlátnál mindig nem negatív számot ad vissza, szóval minimum 0 az alsó
        }

        public Virag(string nev, int nektarMennyiseg)
        {
            this.Nev = nev;
            this.NektarMennyiseg = nektarMennyiseg;
            this.beporzasokSzama = 0;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} porozták be, {2} ml nektár", nev, beporzasokSzama, nektarMennyiseg);
        }
        
    }
}
