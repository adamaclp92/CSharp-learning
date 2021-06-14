using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LancoltLista
{
    /* A ListaElem-et és ezt generikussá tenni.
     * tehát használhatom így is: LancoltLista<string> = new LancoltLista<string>();
     * 
     * Műveletek:
     * - Törlés adott pozíción
     * - Contains(érték) megvalósítása (szerepel-e az érték benne, vagy sem)
     * 
     * STRÁZSÁS LISTA:
     * - Ő is legyen generikus
     * - Ugyanezeket a műveleteket + a fentieket megvalósítani
     * - Contains változik: strázsával oldjuk meg
     * */
    class LancoltLista
    {
        public ListaElem Fej;

        public void Add(int adat)
        {
            if (this.Fej == null)
            {
                this.Fej = new ListaElem();
                this.Fej.adat = adat;
            }
            else
            {
                ListaElem akt = this.Fej;
                while (akt.kov != null)
                {
                    akt = akt.kov; // LÉPTETÉS
                }
                // ugyanaz:
                // for(ListaElem akt = this.Fej; akt.kov != null; akt = akt.kov);
                akt.kov = new ListaElem();
                akt.kov.adat = adat;
            }
        }

        public void Remove(int adat)
        {
            if (this.Fej != null)
            {
                if (this.Fej.adat == adat)
                {
                    this.Fej = this.Fej.kov;
                }
                else
                {
                    ListaElem akt = this.Fej;
                    while (akt.kov != null && akt.kov.adat != adat)
                    {
                        akt = akt.kov;
                    }

                    if (akt.kov != null)
                    {
                        akt.kov = akt.kov.kov;
                    }
                }
            }
        }

        public void Insert(int adat, int index)
        {
            if (this.Fej != null)
            {
                if (index == 0)
                {
                    ListaElem uj = new ListaElem();
                    uj.adat = adat;
                    uj.kov = this.Fej;
                    this.Fej = uj;
                }
                else
                {
                    ListaElem akt = this.Fej;
                    int szamlalo = 0;
                    while (akt.kov != null && szamlalo < index - 1)
                    {
                        akt = akt.kov;
                        szamlalo++;
                    }

                    ListaElem uj = new ListaElem();
                    uj.adat = adat;
                    uj.kov = akt.kov;
                    akt.kov = uj;
                }
            }
            else if (index == 0)
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
