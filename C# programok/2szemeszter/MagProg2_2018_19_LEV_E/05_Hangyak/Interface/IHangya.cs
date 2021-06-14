using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hangyak
{
    interface IHangya
    {
        int CsapHossz { set; get; }
        int Eletkor { get; set; }
        ConsoleColor Szin { get; set; }
        bool VanSzarnya { get; }
        Faj Faj { get; }
    }
}
