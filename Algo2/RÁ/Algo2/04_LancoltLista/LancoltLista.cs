using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LancoltLista
{

    /*
     * Beadandó:
     1, A ListaElem-et és ezt generikussá tenni.
        tehát:  használhatom így is: LancoltLista<string> = new LancoltLista<string>();
     2, Műveletek:
        Törlés adott pozíción
        Contains(érték) megvalósítása (szerepel-e az érték benne, vagy sem)
        
      
     3, STRÁZSÁS generikus Lista megvalósítása ugyanezekkel a műveletekkel
        Contains változik: strázsával oldjuk meg
        
     emalben a vizsga időszak elejéig elküldeni:
     * dbettenbuk@gmail.com
     */
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
                    akt = akt.kov; //léptetés
                }

                //for(ListaElem akt = this.Fej; akt.kov != null; akt=akt.kov); ez ugyanaz

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

        public void Insert(int adat, int index)
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
    }

}


       /* public void ForEach(Action<int> action)
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

        }*/

        //mutató értéke végjel!! nincs olyan, hogy a mutató végjelre mutat Gedánál
 