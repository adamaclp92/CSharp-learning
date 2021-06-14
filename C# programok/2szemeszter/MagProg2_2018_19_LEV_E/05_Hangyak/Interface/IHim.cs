using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hangyak
{
    interface IHim : IHangya
    {
        int Ero { get; set; }

        void Megtermekenyit(INosteny Nosteny);
    }
}
