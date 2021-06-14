using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horgaszverseny
{
    enum halfaj { ponty, keszeg, csuka, amur, busa, karasz, harcsa }
    class hal
    {
        private static Random rnd = new Random();
        //
        protected double _sulya; // 1.0 .. 50.0, fel kilos osztas
        public halfaj faja;
        protected int _melyseg; // 0..1000
        protected int _ehseg;  // 0..10
        // ...
        public double sulya
        {
            get { return _sulya; }
            set
            {
                if (value < 1 || value > 50) throw new Exception("nem jo suly ertek!");
                if (value * 2 != (int)(value * 2)) throw new Exception("fel kilos pontossag kell!");
                _sulya = value;
            }
        }
        // ...
        public int melyseg
        {
            get { return _melyseg; }
            set
            {
                if (value < 0 || value > 1000) throw new Exception("melyseg nem jo!");
                _melyseg = value;
            }
        }
        // ............
        public int ehseg
        {
            get { return _ehseg; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("ehseg skala ertek nem jo!");
                _ehseg = value;
            }
        }
        // ...........
        public hal(double pSulya)
            : this(pSulya, halfaj.ponty, 50, 0)
        {
        }
        // ...........
        public hal(double pSulya, halfaj pFaja, int pMelyseg, int pEhseg)
        {
            sulya = pSulya;
            faja = pFaja;
            melyseg = pMelyseg;
            ehseg = pEhseg;
        }
        // ...........
        public hal(double pSulya, halfaj pFaja, int pMelyseg)
            : this(pSulya, pFaja, pMelyseg, 0)
        {
        }

        public bool raharap_e(int csaliMelyseg)
        {
            if (melyseg * 0.5 <= csaliMelyseg && csaliMelyseg <= melyseg * 1.5)
            {
                // elvileg latja a csalit
                int sor = rnd.Next(0, 100); // 100-as dobokocka
                if (sor < ehseg * 10) return true; // eleg ehes, raharap
            }
            return false;
        }
    }

    class horgasz
    {
        private static Random rnd = new Random();
        //
        protected double _teherbiras; // 0.0 - 80.0 Kg
        protected List<hal> _kifogottHalak;
        protected double _elvartFogas;
        //
        public List<hal> kifogottHalak
        {
            get
            {
                List<hal> r = new List<hal>();
                foreach (hal h in _kifogottHalak)
                    r.Add(h);
                return r;
            }
        }
        public double teherBiras
        {
            get { return _teherbiras; }
            set
            {
                if (value < 0 || value > 80) throw new Exception("nem jo teherbiras!");
                _teherbiras = value;
            }
        }
        // ...
        public double elvartFogas
        {
            get { return _elvartFogas; }
            set
            {
                if (value < 10 || value > _teherbiras) throw new Exception("nem jo elvaras!");
                _elvartFogas = value;
            }

        }

        public int csaliMelyseg()
        {
            int m = rnd.Next(1, 90) * 10;
            return m;
        }

        public bool kifog(hal h)
        {
            double sum = osszZsakmanySulya;
            //
            if (sum + h.sulya > _teherbiras) return false;
            else
            {
                _kifogottHalak.Add(h);
                return true;
            }
        }

        public double osszZsakmanySulya
        {
            get
            {
                double sum = 0;
                foreach (hal p in _kifogottHalak)
                    sum += p.sulya;
                return sum;
            }
        }

        public horgasz(double pTeherbiras, double pElvartFogas)
        {
            teherBiras = pTeherbiras;
            elvartFogas = pElvartFogas;
            _kifogottHalak = new List<hal>();
        }
        public horgasz(double pTeherbiras)
            : this(pTeherbiras, pTeherbiras)
        {
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<hal> to = new List<hal>();
            List<horgasz> pecasok = new List<horgasz>();
            //
            for (int i = 0; i < 100; i++)
            {
                double s = rnd.Next(20, 100) / 2.0;
                //                0       1       2     3     4     5       6
                // enum halfaj { ponty, keszeg, csuka, amur, busa, karasz, harcsa }
                int k = rnd.Next(0, 7);
                halfaj f = (halfaj)k;
                int m = rnd.Next(2, 100) * 10;
                int eh = rnd.Next(4, 11);
                hal h = new hal(s, f, m, eh);
                to.Add(h);

            }
            //
            for (int i = 0; i < 10; i++)
            {
                double t = rnd.Next(100, 800) / 10.0;
                horgasz p = new horgasz(t);
                pecasok.Add(p);
            }
            //
            Console.WriteLine("------- verseny kezdodik ------------");
            for (int i = 0; i < 100; i++)
            {
                int k = rnd.Next(0, pecasok.Count);
                horgasz lajos = pecasok[k];
                int melys = lajos.csaliMelyseg();
                //
                for (int j = 0; j < 5; j++)
                {
                    int n = rnd.Next(0, to.Count);
                    hal h = to[n];
                    if (h.raharap_e(melys) == true)
                    {
                        Console.WriteLine(" a {0}. pecas a {1}. halat elvileg kifogta", k, n);
                        if (lajos.kifog(h) == true)
                        {
                            Console.WriteLine("    --- eltette !!!");
                            to.RemoveAt(n);
                            break; // 5 halas ciklusbol kilep
                        }
                    }
                }
            }
            //
            Console.WriteLine("a toban megmaradt {0} db hal", to.Count);
            // 1: legtobb sulyu halat kifogo
            int max = 0;
            for (int i = 1; i < pecasok.Count; i++)
            {
                if (pecasok[i].osszZsakmanySulya > pecasok[max].osszZsakmanySulya)
                    max = i;
            }
            Console.WriteLine("az {0}. pecas nyert {1} Kg kifogott hal", max,
                pecasok[max].osszZsakmanySulya());
            foreach (hal h in pecasok[max].kifogottHalak)
            {
                Console.WriteLine("  - {0} Kg {1}", h.sulya, h.faja);
            }

            // 2: legnagyobb kifogott hal
            // HF !!!!!!!!!!
            Console.ReadLine();
        }
    }
}