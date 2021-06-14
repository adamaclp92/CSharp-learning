using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vilagmindenseg
{
    class Galaxis
    {
        private static uint Id = 1;

        public Galaxis()
        {
            this.egitestek = new List<Egitest>();
        }

        private List<Egitest> egitestek;
        public List<Egitest> Egitestek
        {
            get
            {
                return new List<Egitest>(egitestek);
            }
        }
        public List<Bolygo> Bolygok
        {
            get
            {
                List<Bolygo> temp = new List<Bolygo>();
                foreach (Egitest egitest in Egitestek)
                {
                    if (egitest is Bolygo)
                        temp.Add(egitest as Bolygo);
                }
                return temp;
            }
        }
        public List<Bolygo> FoldszeruBolygok
        {
            get
            {
                List<Bolygo> temp = new List<Bolygo>();
                foreach (Bolygo bolygo in Bolygok)
                {
                    if (bolygo.Foldszeru)
                        temp.Add(bolygo);
                }
                return temp;
            }
        }
        public List<Csillag> Csillagok
        {
            get
            {
                List<Csillag> temp = new List<Csillag>();
                foreach (Egitest egitest in Egitestek)
                {
                    if (egitest is Csillag)
                        temp.Add(egitest as Csillag);
                }
                return temp;
            }
        }
        public List<Csillag> Neutroncsillagok
        {
            get
            {
                List<Csillag> temp = new List<Csillag>();
                foreach (Csillag csillag in Csillagok)
                {
                    if (csillag.Osztaly == CsillagOsztaly.NEUTRON)
                        temp.Add(csillag);
                }
                return temp;
            }
        }

        public Egitest this[int index]
        {
            get
            {
                return Egitestek[index];
            }
            //set
            //{
            //    egitestek[index] = value;
            //}
        }
        public Egitest this[string Azonosito]
        {
            get
            {
                foreach (Egitest egitest in Egitestek)
                {
                    if (egitest.Azonosito == Azonosito)
                        return egitest;
                }
                throw new Exception("Az azonosító nem található!");
            }
        }

        public List<Csillag> AdottCsillaghozHasonloak(Csillag csillag)
        {
            List<Csillag> temp = new List<Csillag>();
            foreach (Csillag cs in Csillagok)
            {
                if (csillag.Hasonlo(cs))
                    temp.Add(cs);
            }
            return temp;
        }
        public List<Bolygo> AdottOsztalybaTartozoBolygok(BolygoOsztaly Osztaly)
        {
            List<Bolygo> temp = new List<Bolygo>();
            foreach (Egitest egitest in egitestek)
            {
                if (egitest is Bolygo &&
                    (egitest as Bolygo).Osztaly == Osztaly)
                    temp.Add(egitest as Bolygo);
            }
            return temp;
        }

        public void Osszeolvad(Csillag egyik, Csillag masik)
        {
            Csillag cs = new Csillag(GetId());
            cs.Osztaly = CsillagOsztaly.NEUTRON;
            cs.Eletkor = 0;
            cs.Atmero = egyik.Atmero + masik.Atmero;
            egitestek.Add(cs);
            Id++;
            //Megbeszéltük, h itt mi a baj
            //Kéne egy metódus, ami azonosító alapján töröl
            //egitestek.Remove(egyik);
            //egitestek.Remove(masik);
        }

        private string GetId()
        {
            return Id.ToString().PadLeft(7, '0');
        }

        public int FoldszeruBolygokDb
        {
            get
            {
                int db = 0;
                foreach (Bolygo bolygo in Bolygok)
                {
                    if (bolygo.Foldszeru)
                        db++;
                }
                return db;
            }
        }        

        public void AddCsillag()
        {
            egitestek.Add(new Csillag(GetId()));
            Id++;
        }
        public void AddCsillag(string Nev, ushort Eletkor)
        {
            egitestek.Add(new Csillag(
                GetId(), Nev, Eletkor));
            Id++;
        }
        /// <summary>
        /// Ezeket itt illene kitölteni...
        /// </summary>
        /// <param name="Nev"></param>
        /// <param name="Eletkor"></param>
        /// <param name="Osztaly"></param>
        /// <param name="Atmero"></param>
        public void AddCsillag(string Nev, ushort Eletkor,
            CsillagOsztaly Osztaly, float Atmero)
        {
            Csillag cs = new Csillag(GetId());
            cs.Nev = Nev;
            cs.Eletkor = Eletkor;
            cs.Osztaly = Osztaly;
            cs.Atmero = Atmero;
            egitestek.Add(cs);
            Id++;
        }

        public void AddBolygo()
        {
            egitestek.Add(new Bolygo(GetId()));
            Id++;
        }
        public void AddBolygo(string Nev, ushort Eletkor)
        {
            egitestek.Add(new Bolygo(
                GetId(), Nev, Eletkor));
            Id++;
        }
        public void AddBolygo(string Nev, ushort Eletkor,
            BolygoOsztaly Osztaly, float KeringesiTavolsag)
        {
            Bolygo b = new Bolygo(GetId());
            b.Nev = Nev;
            b.Eletkor = Eletkor;
            b.Osztaly = Osztaly;
            b.KeringesiTavolsag = KeringesiTavolsag;
            egitestek.Add(b);
            Id++;
        }
    }
}
