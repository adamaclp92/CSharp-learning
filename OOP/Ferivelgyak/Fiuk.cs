using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferivelgyak
{
    class Fiuk : Person
    {
		private int _Energia;

		public int Energia
		{
			get {
				if (_Energia < 1)
					throw new Exception("Nem lehet kisebb, mint 0.");
				return _Energia; }
			set 
			{

				_Energia = value;
			}
		}

		public void Eszik(int adag)
		{
			if(adag < 0 || adag > 100)
				throw new Exception("Az adagnak nagyobbnak kell lennie, mint 0, és kisebbnek, mint 100");
			Energia += adag;
		}

		public Fiuk(string vezeteknev, string keresztnev, int szulev, Hajszinek hajszin, int energia) : base(vezeteknev, keresztnev, szulev, hajszin)
		{
			this.Energia = energia;
		}

		public override string ToString()
		{
			return string.Format("{0}, energia: {1}", base.ToString(), Energia);
		}

	}
}
