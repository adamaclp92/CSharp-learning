using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesAndWasps
{
    class Darazs:Rovar, IBeporzo
    {


        public void Beporoz(Virag x)
        {
            x.Beporoztak();
        }

        public int gyujtottNektar
        {
            get
            {
                return 0;
            }
        }

        public Darazs(string nev):base(nev)
        {

        }
    }
}
