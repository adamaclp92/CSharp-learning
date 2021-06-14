using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hangyak
{
    interface INosteny : IHangya
    {
        bool Szuz { get; }
        void SzarnyElveszit();
    }
}
