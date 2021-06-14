using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferivelgyak
{
	class Person
	{
		private string _VezezekNev;

		public string VezetekNev
		{
			get { return _VezezekNev; }
			set { _VezezekNev = value; }
		}

		private string _KeresztNev;

		public string KeresztNev
		{
			get { return _KeresztNev; }
			set { _KeresztNev = value; }
		}

		private int _SzulEv;

		public int SzulEv
		{
			get { return _SzulEv; }
			set { _SzulEv = value; }
		}

		private int _Eletkor;

		public int Eletkor
		{

			get
			{
				if (DateTime.Now.Year - SzulEv < 18)
					throw new Exception("Túl fiatal.");
				return DateTime.Now.Year - SzulEv;

			}
			set
			{
				_Eletkor = value;
			}
		}

		private Hajszinek _Hajszin;

		public Hajszinek Hajszin
		{
			get { return _Hajszin; }
			set { _Hajszin = value; }
		}


		public Person(string vezeteknev, string keresztnev, int szulev, Hajszinek hajszin)
		{
			this.VezetekNev = vezeteknev;
			this.KeresztNev = keresztnev;
			this.SzulEv = szulev;
			this.Hajszin = hajszin;
		}


		public override string ToString()
		{
			return string.Format("Neve: {0} {1} életkora: {2}, hajszíne: {3}", VezetekNev, KeresztNev, Eletkor, Hajszin);
		}
	}
}