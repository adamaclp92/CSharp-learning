using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class OrkParaszt : Ork
    {
        public override string Etkezik()
        {
            return Nev + " előveszi az édesanyja által csomagolt hamuban sült brokkoliját és szépen, felnőtt ork módjára elfogyasztja.";
        }

        public override string Pihen()
        {
            return "Zzzzzzzzzzz...";
        }
    }
}
