using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragó_Ádám_zh
{
    class Ingatlan
    {
        
      
        private string helyrajziSzam;
        public string HelyrajziSzam
        {
           get { return helyrajziSzam; }
           set
            {
                if (value.Length < 3) throw new Exception("A helyrajzi számnnak minimum 3 karakternek kell lennie!");
                else
                    helyrajziSzam = value;
            }
        }

        private uint ar;
        public uint Ar
        {
            get { return ar; }
            set
            {
                if (value % 100000 != 0) throw new Exception("Az árnak oszthatónak kell lennie 100.000-rel!");
                else
                    ar = value;
            }
        }

        public Ingatlan(string helyrajziSzam, uint ar)
        {
            this.HelyrajziSzam = helyrajziSzam;
            this.Ar = ar;
            
        }

        public override string ToString()
        {
            return string.Format("Ingatlan helyrajzi száma: {0}, ára: {1} Ft", helyrajziSzam, ar);
        }
    }
}

/*Egy ingatlant jellemeznek a következő adatok:
    helyrajzi szám: min. 3 karakter
    ár: pozitív, 100 ezerrel osztható*/