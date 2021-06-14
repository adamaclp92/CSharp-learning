using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesAndWasps
{
    class Meh:Rovar, IBeporzo
    {

        public void Beporoz(Virag x)
        {
            x.Beporoztak();
            int nektar = x.NektarMennyiseg;
            x.NektartAd();
            gyujtottNektar += nektar - x.NektarMennyiseg;
        }   

        private int gyujtottNektar = 0;
        public int GyujtottNektar
        {
            get 
            {
                return gyujtottNektar;
            }
        }

        int IBeporzo.gyujtottNektar => throw new NotImplementedException();

        public Meh(string nev):base(nev)
        {

        }
    }
}
