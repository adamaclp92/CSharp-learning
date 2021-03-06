using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ZH1_Klon
{
    class Ezred
    {
        private static uint Azonosito = Beallitasok.Default.AzonositoMin;

        public Ezred(bool Klon)
        {
            this.Klon = Klon;
            this.rohamosztagosok = new List<Rohamosztagos>();
        }

        public bool Klon { get; private set; }
        private List<Rohamosztagos> rohamosztagosok;
        public List<Szarazfoldi> Szarazfoldiek
        {
            get
            {
                List<Szarazfoldi> temp = new List<Szarazfoldi>();
                foreach (Rohamosztagos r in rohamosztagosok)
                {
                    if (r is Szarazfoldi && r.KikepzesIdeje >= 4)
                        temp.Add(r as Szarazfoldi);
                }
                return temp;
            }
        }
        public List<Pilota> Pilotak
        {
            get
            {
                List<Pilota> temp = new List<Pilota>();
                foreach (Rohamosztagos r in rohamosztagosok)
                {
                    if (r is Pilota && r.KikepzesIdeje >= 4)
                        temp.Add(r as Pilota);
                }
                return temp;
            }
        }

        public Rohamosztagos this[uint Azonosito]
        {
            get
            {
                return rohamosztagosok[(int)Azonosito].Clone();
            }
        }

        public int TisztekSzama
        {
            get
            {
                int db = 0;
                foreach (Szarazfoldi sz in Szarazfoldiek)
                {
                    if (sz.Tiszt)
                        db++;
                }
                return db;
            }
        }
        public List<Pilota> PilotakAdottJarmuvel(Jarmu Jarmu)
        {
            List<Pilota> temp = new List<Pilota>();
            foreach (Pilota p in Pilotak)
            {
                if (p.MitVezet == Jarmu)
                    temp.Add(p);
            }
            return temp;
        }

        public void AddSzarazfoldi(string Nev, byte KikepzesIdeje,
            SugarvetoSzine Szin, bool Tiszt, Sisak Sisak,
            byte TalalatiPontossag)
        {
            Szarazfoldi s = new Szarazfoldi(Ezred.Azonosito, Nev,
                KikepzesIdeje,Szin, this.Klon, Tiszt, Sisak,
                TalalatiPontossag);
            this.rohamosztagosok.Add(s);
            Ezred.Azonosito++;
        }
    }
}
