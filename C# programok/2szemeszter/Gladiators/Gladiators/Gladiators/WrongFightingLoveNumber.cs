using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class WrongFightingLoveNumber:Exception
    {
        private int wrongNumber;

        public int WrongNumber
        {
            get { return wrongNumber; }
        }

        public WrongFightingLoveNumber(int wrongNumber)
        {
            this.wrongNumber = WrongNumber;
        }

        public override string Message
        {
            get
            {
                return string.Format("Ennek a számnak -5 és 5 közötti egész kell lennie: {0}", wrongNumber);
            }
        }
    }
}

