using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesAndWasps
{
    class NegativNumberException:Exception
    {
        private int number;

        public int Number
        {
            get { return number; }
        }


        public NegativNumberException(int number)
        {
            this.number = number;
        }

        public override string Message
        {
            get
            {
                return string.Format("Ez az érték sajnos negatív: {0}", number);
            }
        }
    }
    }
}
