using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Warcraft1
{
    class Paraszt : Ork
    {
        public override string Eszik()
        {
            return Nev + " szépen csendben megebédel.";
        }

        public override string Pihen()
        {
            return "Zzz...";
        }
    }
}
