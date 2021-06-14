using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class WrongYearsNumber:Exception
    {
        private int wrongYear;

        public int WrongYear
        {
            get { return wrongYear; }
        }


        public WrongYearsNumber(int wrongYear)
        {
            this.wrongYear = WrongYear;
        }

        public override string Message
        {
            get
            {
                return string.Format("Ennek a számnak 0 és 10 közötti egész kell lennie: {0}", wrongYear);
            }
        }
    }
}
