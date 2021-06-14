using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class KeresztenyGladiator : Gladiator, IHarcos
    {
        public bool Megtamad(Gladiator g)
        {
            return false;
        }
        public KeresztenyGladiator(int sorszam, int evekSzama, Eredet eredet) : base(sorszam, evekSzama, eredet)
        {
        }

        public override string ToString()
        {
            return string.Format("Sorszám: {0}\tÉvek száma: {1}\teredet: {2}",Sorszam, EvekSzama, Eredet);
        }
    }
}
