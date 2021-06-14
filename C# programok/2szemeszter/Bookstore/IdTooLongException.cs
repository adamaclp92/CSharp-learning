using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class IdTooLongException:Exception
    {
        private string azonosito;

        public string Azonosito
        {
            get { return azonosito; }
        }


        public IdTooLongException(string azonosito)
        {
            this.azonosito = Azonosito;
        }

        public override string Message
        {
            get
            {
                return string.Format("Ez az azonosító túl hosszú: {0}", azonosito);
            }
        }
    }
}
