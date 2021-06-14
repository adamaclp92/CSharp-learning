using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class OrkHarcos : Ork
    {
        public new static int GYOGYULASFAKTOR = 20;

        public override int GyogyulasFaktor
        {
            get
            {
                return OrkHarcos.GYOGYULASFAKTOR;
            }
        }

        public override string Etkezik()
        {
            return Nev + " letépi ellenfele halott fejét és az orrlukain keresztül kiszívja annak finom és tápláló agyvelejét.";
        }

        public override string Pihen()
        {
            return "Zzz...";
        }
    }
}
