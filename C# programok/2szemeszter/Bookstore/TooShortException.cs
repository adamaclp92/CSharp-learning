using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class TooShortException:Exception
    {
        private string rovid;

        public string Rovid
        {
            get { return rovid; }
        }


        public TooShortException(string rovid)
        {
            this.rovid = Rovid;
        }

        public override string Message
        {
            get
            {
                return string.Format("Ez az elem túl rövid: {0}", rovid);
            }
        }
    }
}
