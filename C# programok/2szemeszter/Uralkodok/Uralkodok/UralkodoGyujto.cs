using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uralkodok
{
    class UralkodoGyujto
    {
        private List<Uralkodo> uralkodok = new List<Uralkodo>();

        public void Hozzaad(Uralkodo u)
        {
            if (u == null)
                throw new Exception("A hozzáadandó uralkodó nincs példányosítva");
            if (uralkodok == null)
                throw new Exception("A lista nincs példányosítva");

            uralkodok.Add(u);
        }

        public int UralkodokSzama
        {
            get
            {
                return uralkodok.Count;
            }
        }

        public Uralkodo this[int i]
        {
            get
            {
                return uralkodok[i];
            }
        }
    }
}
