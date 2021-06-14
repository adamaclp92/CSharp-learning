using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutya
{
    class kutya
    {
		private string _Nev;

		public string Nev
		{
			get { return _Nev; }
			set { _Nev = value; }
		}

		private int _Eletkor;

		public kutya(string nev, int eletkor)
		{
			this._Nev = nev;
			this._Eletkor = eletkor;
		}

		public override string ToString()
		{
			return string.Format("{0}: {1}", _Nev, _Eletkor);
		}

	}
}
