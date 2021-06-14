using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Warcraft1
{
    abstract class Ork
    {
        public string Nev { get; set; }
        public int Eletero { get; set; }

        public virtual int GyogyulasFaktor
        {
            get
            {
                return Beallitasok.Default.OrkGyogyulasFaktor;
            }
        }

        public abstract string Eszik();
        public abstract string Pihen();

        public void Gyogyul(int Ertek)
        {
            this.Eletero += Ertek;
        }
        public string Regeneralodik()
        {
            Gyogyul(GyogyulasFaktor);
            return string.Format("{0}\n{1}", Eszik(), Pihen());
        }
    }
}
