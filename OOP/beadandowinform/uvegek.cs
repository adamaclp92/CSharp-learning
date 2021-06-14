using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadandowinform
{
    class uvegek
    {
		private Uvegfajtak _uvegfajta;

		public Uvegfajtak Uvegfajta
		{
			get { return _uvegfajta; }
			set { _uvegfajta = value; }
		}

		private int _uvegar;

		public int Uvegar
		{
			get { return _uvegar; }
			set { _uvegar = value; }
		}

		public uvegek(Uvegfajtak uvegfajta, int uvegar)
		{
			this.Uvegfajta = uvegfajta;
			this.Uvegar = uvegar;
		}



		public override string ToString()
		{
			return string.Format("Üvegfajta: {0}, ára: ", Uvegfajta, Uvegar);
		}
	}
}
