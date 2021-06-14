using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesAndWasps
{
    class NameTooShortException:Exception
    {
        private string name;

        public string Name
        {
            get { return name; }
        }


        public NameTooShortException(string name)
        {
            this.name = name;
        }

        public override string Message
        {
            get
            {
                return string.Format("Ez a név túl rövid: {0}", name);
            }
        }
    }
}
