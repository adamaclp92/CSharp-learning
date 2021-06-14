using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symphonic
{
    class Instrument
    {
        //név
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        //ár
        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value % 100 != 95) throw new Exception("Az árnak 95-re kell végződnie");
                else
                    price = value;
            }
        }

        public Instrument(string name, int price)
        {
            this.Name = name;
            this.Price = price;
            
        }

        public override string ToString()
        {
            return string.Format("Név: {0}, ára: {1} Ft", name, price);
        }
    }
}
