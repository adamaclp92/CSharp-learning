using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    abstract class Ork
    {
        public static int GYOGYULASFAKTOR = 10;

        public string Nev { get; set; }
        public int Eletero { get; set; }
        public virtual int GyogyulasFaktor
        {
            get
            {
                return Ork.GYOGYULASFAKTOR;
            }
        }

        public abstract string Etkezik();
        public abstract string Pihen();
        public void Gyogyul(int Ertek)
        {
            this.Eletero += Ertek;
        }

        public string Regeneralodik()
        {
            Gyogyul(GyogyulasFaktor);
            return string.Format("{0}\n{1}",
                Etkezik(),
                Pihen());
        }
    }
}
