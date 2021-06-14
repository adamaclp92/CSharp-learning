using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hangyak
{
    class Hangyaboly
    {
        private List<IHangya> hangyak = new List<IHangya>();
        public List<ASzarnyasHim> SzarnyasHimek
        {
            get
            {
                List<ASzarnyasHim> temp = new List<ASzarnyasHim>();
                foreach (IHangya h in hangyak)
                {
                    if (h is ASzarnyasHim)
                        temp.Add(h as ASzarnyasHim);
                }
                return temp;
            }
        }
    }
}
