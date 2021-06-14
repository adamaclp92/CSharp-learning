using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    class Konyv
    {
        private Konyv()
        {
            this.Kiadas = 1;
        }
        public Konyv(uint Id, string Szerzo, string Cim)
            :this()
        {
            this.Id = Id;
            this.Szerzo = Szerzo;
            this.Cim = Cim;
        }
        //opcionális konstruktor

        public uint Id { get; set; }
        public string Szerzo { get; set; }
        public string Cim { get; set; }
        public byte Kiadas { get; set; }//Csak egyesével nőhet, nem csökkenhet
        public uint Ar { get; set; }
        public bool Elerheto { get; set; }        
    }
}
