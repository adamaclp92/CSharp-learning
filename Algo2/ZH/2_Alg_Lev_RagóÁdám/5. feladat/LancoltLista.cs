using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.feladat
{
    
    class LancoltLista
    {
        public ListaElem Fej;

        public void VegereBeszur(int adat)
        {
            if (this.Fej != null)
            {
                ListaElem akt = this.Fej;

                while (akt.kov != null)
                {
                    akt = akt.kov;

                }

                ListaElem uj = new ListaElem();
                uj.adat = adat;
                uj.kov = akt.kov;
                akt.kov = uj;

            }
            else
            {
                this.Fej = new ListaElem();
                this.Fej.adat = adat;
            }
        }
        public void ForEach(Action<int> action)
        {
            if (this.Fej != null)
            {
                ListaElem akt = this.Fej;
                while (akt != null)
                {
                    action(akt.adat);
                    akt = akt.kov;
                }
            }
        }
    }
}



