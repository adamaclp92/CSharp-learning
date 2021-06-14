using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrazsaLista
{
    class StrazsaLista<T>
    {
        public ListaElem<T> Fej;
        
        public void Add(T adat)
        {
            ListaElem<T> strazsa = new ListaElem<T>();
            strazsa.adat = adat;
            strazsa.kov = null;

            if (this.Fej == strazsa.kov)
            {
                this.Fej = new ListaElem<T>();
                this.Fej.adat = adat;
            }
            else
            {
                ListaElem<T> akt = this.Fej;
                while (akt.kov != strazsa.kov)
                {
                    akt = akt.kov;
                }

                akt.kov = new ListaElem<T>();
                akt.kov.adat = adat;
            }
        }

        public void Remove(T adat)
        {
            ListaElem<T> strazsa = new ListaElem<T>();
            strazsa.adat = adat;
            strazsa.kov = null;

            if (this.Fej != strazsa.kov)
            {

                if (this.Fej.adat.Equals(adat))
                {

                    this.Fej = this.Fej.kov;
                }
                else
                {
                    ListaElem<T> akt = this.Fej;
                    while (akt.kov != strazsa.kov && !(akt.kov.adat.Equals(adat)))
                    {
                        akt = akt.kov;
                    }

                    if (akt.kov != strazsa.kov)
                    {
                        akt.kov = akt.kov.kov;
                    }
                }
            }
        }

        public bool Contains(T adat)
        {
            ListaElem<T> strazsa = new ListaElem<T>();
            strazsa.adat = adat;
            strazsa.kov = null;

            ListaElem<T> akt = this.Fej;
            while (akt != strazsa.kov)
            {
                if (!(akt.adat.Equals(adat)))
                    akt = akt.kov;
                else if (akt.adat.Equals(adat))
                    return true;
            }
          
            return false;
        }


        public void RemoveAt(int index)
        {
            ListaElem<T> strazsa = new ListaElem<T>();
            
            strazsa.kov = null;

            if (this.Fej != strazsa.kov)
            {
                if (index == 0)
                {
                    this.Fej = this.Fej.kov;
                  
                }

                else
                {
                    ListaElem<T> akt = this.Fej;
                    int szamlalo = 0;
                    while (akt.kov != strazsa.kov && szamlalo < index - 1)
                    {
                        akt = akt.kov;
                        
                        szamlalo++;
                    }

                    if (akt.kov != null)
                    {
                        akt.kov = akt.kov.kov;
                      
                    }
                }
            }

        }

        public void Insert(T adat, int index)
        {
            ListaElem<T> strazsa = new ListaElem<T>();
            strazsa.adat = adat;
            strazsa.kov = null;

            if (this.Fej != strazsa.kov)
            {
                if (index == 0)
                {
                    ListaElem<T> uj = new ListaElem<T>();
                    uj.adat = adat;
                    uj.kov = this.Fej;
                    this.Fej = uj;
                  
                }
                else
                {
                    ListaElem<T> akt = this.Fej;
                    int szamlalo = 0;
                    while (akt.kov != strazsa.kov && szamlalo < index - 1)
                    {
                        akt = akt.kov;
                        szamlalo++;
                    }

                    ListaElem<T> uj = new ListaElem<T>();
                    uj.adat = adat;
                    uj.kov = akt.kov;
                    akt.kov = uj;
                  
                }
            }
            else if (index == 0)
            {
                this.Fej = new ListaElem<T>();
                this.Fej.adat = adat;
            }
        }

        public void ForEach(Action<T> action)
        {
            ListaElem<T> strazsa = new ListaElem<T>();
            
            strazsa.kov = null;

            if (this.Fej != strazsa.kov)
            {
                ListaElem<T> akt = this.Fej;
                while (akt != strazsa.kov)
                {
                    action(akt.adat);
                    akt = akt.kov;
                   
                }
            }
        }
    }
}
