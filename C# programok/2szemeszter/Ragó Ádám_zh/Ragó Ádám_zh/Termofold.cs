using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragó_Ádám_zh
{
         enum muvelesiAg
    {
        szanto,erdo,gyumolcsos,szolo
    }
    class Termofold:Ingatlan
    {
        private muvelesiAg muvelesiAg;
        public muvelesiAg MuvelesiAg
        {
            get { return muvelesiAg; }
            set { muvelesiAg = value; }
        }

        private float teruletNagysaga;
        public float TeruletNagysaga
        {
            get { return teruletNagysaga; }
             set
            {
                    teruletNagysaga = value;
            }
        }

        public Termofold(string helyrajziSzam, uint ar, muvelesiAg muvelesiAg, float teruletNagysaga)
            : base(helyrajziSzam, ar)
        {
            this.MuvelesiAg = muvelesiAg;
            this.TeruletNagysaga = teruletNagysaga;

        }

        public override string ToString()
        {
            return string.Format("{0}, művelési ág: {1}, terület nagysága: {2} hektár", base.ToString(), muvelesiAg, teruletNagysaga);
        }
    }
}


/*Egy termőföldet (mint ingatlant) jellemeznek még a következő adatok:
    művelési ág: pl. szántó, erdő, gyümölcsös, szőlő stb.
    terület nagysága (hektárban)*/
