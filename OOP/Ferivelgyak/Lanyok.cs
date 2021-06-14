using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferivelgyak
{
    class Lanyok: Person
    {
		private int _Kedvesseg;

		public int Kedvesseg
		{
			get
			{
				if (_Kedvesseg < 1)
					throw new Exception("Nem lehet kisebb, mint 0.");
				return _Kedvesseg;
			}
			set
			{

				_Kedvesseg = value;
			}
		}

		private Szemszinek _Szemszin;

		public Szemszinek Szemszin
		{
			get { return _Szemszin; }
			set { _Szemszin = value; }
		}

		public bool Kocsoge
		{
			get 
			{
				return Kedvesseg < 50;
			}
		}


		public void Iszik(int mennyiseg)
		{
			if (mennyiseg < 0 || mennyiseg > 100)
				throw new Exception("Az adagnak nagyobbnak kell lennie, mint 0, és kisebbnek, mint 100");
			Kedvesseg += mennyiseg;
		}

		public Lanyok(string vezeteknev, string keresztnev, int szulev, Hajszinek hajszin, int kedvesseg, Szemszinek szemszin) : base(vezeteknev, keresztnev, szulev, hajszin)
		{
			this.Kedvesseg = kedvesseg;
			this.Szemszin = szemszin;
		}

		public override string ToString()
		{
			return string.Format("{0}, kedvesség: {1}, szemszín: {2}", base.ToString(), Kedvesseg, Szemszin);
		}

	}
}
