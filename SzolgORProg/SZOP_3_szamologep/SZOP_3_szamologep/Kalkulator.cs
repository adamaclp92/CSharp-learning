using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace SZOP_3_szamologep
{
    class Kalkulator : MarshalByRefObject, szamologepsz.ISzamologep
    {
        public int osszead(int a, int b)
        {
            return a + b;
        }
        public int osztas(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("B nem lehet 0");
            return a / b; //persze 2 egész szám hányadosa egész lesz, de most mind1
        }
    }
}
