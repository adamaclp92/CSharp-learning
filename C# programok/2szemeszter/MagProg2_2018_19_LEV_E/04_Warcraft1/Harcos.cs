using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Warcraft1
{
    class Harcos: Ork
    {
        public override int GyogyulasFaktor
        {           
            get
            {
                return Beallitasok.Default.HarcosGyogyulasFaktor;
            }
        }

        public override string Eszik()
        {
            return Nev + " letépi ellenfele élettelen fejét és az orrlukain keresztül kiszívja finom és tápláló agyvelejét.";
        }
        public override string Pihen()
        {
            return "Zzz...";
        }        
    }
}
