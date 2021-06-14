using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hangyak
{
    abstract class AHangya : IHangya
    {
        public AHangya(int Eletkor, ConsoleColor Szin, Faj Faj,
            bool VanSzarnya)
        {
            this.Eletkor = Eletkor;
            this.Szin = Szin;
            this.Faj = Faj;
            this.VanSzarnya = VanSzarnya;
        }

        public abstract int CsapHossz { get; set; }
        public int Eletkor
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public ConsoleColor Szin
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public bool VanSzarnya { set; get; }

        private Faj faj;
        public Faj Faj
        {
            set { this.faj = value; }
            get { throw new NotImplementedException(); }
        }
    }
}
