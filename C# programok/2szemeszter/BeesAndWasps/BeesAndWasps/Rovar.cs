using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesAndWasps
{
    abstract class Rovar
    {
        private string nev;
        public string Nev
        {
            get { return nev; }
            set
            {
                if (value.Length < 3) throw new NameTooShortException(value);
                nev = value;
            }
        }

        public Rovar(string nev)
        {
            this.Nev = nev;
        }
        
    }
}
