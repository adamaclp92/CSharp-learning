using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hangyak
{
    class ASzarnyasHim : AHangya, IHim, ISzarnyas
    {
        public ASzarnyasHim(int Eletkor, ConsoleColor Szin, Faj Faj)
            :base(Eletkor, Szin, Faj, true)
        {

        }

        public override int CsapHossz
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

        public int Ero
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

        public void Megtermekenyit(INosteny Nosteny)
        {
            Nosteny.SzarnyElveszit();
        }

        public void Repul()
        {
            throw new NotImplementedException();
        }
    }
}
