using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragó_Ádám_zh
{

    enum fajta
    {
       emeletes_haz, csaladi_haz, tarsas_haz
    }
    class Lakoepulet : Ingatlan
    {
        private string cim;
        public string Cim
        {
            get { return cim; }
            private set
            {
                if (value.Length <= 0) throw new Exception("A cím nem lehet üres!");
                else
                    cim = value;
            }
        }

        private fajta fajta;
        public fajta Fajta
        {
            get { return fajta; }
            set { fajta = value; }
        }


        private bool bontando_e;

        public bool Bontando_e
        {
            get { return bontando_e; }
            private set
            {
                    bontando_e = value;
            }
        }

        public Lakoepulet(string helyrajziSzam, uint ar, string cim, fajta fajta, bool bontando_e)
            : base(helyrajziSzam, ar)
          
        {
            this.Cim = cim;
            this.Fajta = fajta;
            this.Bontando_e = bontando_e;

        }

      

        public override string ToString()
        {
            return string.Format("{0}, ingatlan címe: {1}, épület fajtája: {2} bontadó-e:", base.ToString(), cim, fajta, bontando_e);
        }
    }

    }


/*Egy lakóépületet (mint ingatlant) jellemeznek még a következő adatok:

    cím: nem lehet üres

    fajta: pl. emeletes ház, családi ház, társasház stb.

    bontandó-e
*/
