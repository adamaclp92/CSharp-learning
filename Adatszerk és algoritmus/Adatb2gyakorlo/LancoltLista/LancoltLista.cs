using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    class LancoltLista
    {
        public ListaElem Fej;

        public void Add(int adat)
        {
            if (this.Fej == null) // ha a fej értéke nem végjel
            {
                this.Fej = new ListaElem();
                this.Fej.adat = adat;
            }
            else
            {
                ListaElem akt = this.Fej;
                while (akt.kov != null)
                {
                    akt = akt.kov;
                }
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

                    if(akt.kov != null)
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
