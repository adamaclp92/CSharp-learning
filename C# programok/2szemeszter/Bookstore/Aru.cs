using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    abstract class Aru
    {
        private string azonosito;

        public string Azonosito
        {
            get { return azonosito; }
            set
            {
                if(value.Length > 13) throw new IdTooLongException(value);
                azonosito = value;
            }
        }

        public Aru(string azonosito)
        {
            this.azonosito = azonosito;
        }

        List<Aru> aruk = new List<Aru>();


        public void Add(Aru i)
        {

            aruk.Add(i);

        }

        public Aru this[int index]
        {
            get
            {
                return aruk[index];
            }
        }

    }
}
