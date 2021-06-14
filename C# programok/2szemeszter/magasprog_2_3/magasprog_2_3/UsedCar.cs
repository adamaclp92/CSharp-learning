using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasprog_2_3
{
     class UsedCar : Sortable
    {

        private CarBrand brand;

        public CarBrand Brand
        { get { return brand; } }

        private string modell;

        public string Modell
        { get { return modell; } }

        private ConsoleColor color;

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        private string numberplate;

        public string Numberplate
        {
            get { return numberplate; }
            set { numberplate = value; }
        }

        //teljesítmény (kW)
        private ushort performance;

        public ushort Performance
        {
            get { return performance; }
            set
            {
                if (value > performance)
                    performance = value;

                else
                    throw new Exception("Ne vedd lejjebb a teljesítményt, inkább tuningold a kocsit");
            }
        }

        private const double HP_kw_rate = 1.341;

        public uint PerformanceInHp
        {
            get
                {
                return (uint)(performance * HP_kw_rate);
                }
        }

        public static UsedCar operator +(UsedCar c, ushort x) // operátor overload
        {
            c.performance += x;
            return c;
        }

        public static bool operator <(UsedCar c1, UsedCar c2)
        {
            return c1.performance < c2.performance;
        }

        public static explicit operator ushort(UsedCar c) //explicit kasztolás overload
        {
            return c.performance;
        }

        public static bool operator >(UsedCar c1, UsedCar c2)
        {
            return c2 < c1;
        }

        public UsedCar(CarBrand brand, string modell, ConsoleColor color, string numberplate, ushort performance)
        {
            this.brand = brand;

            if (modell == "")
            { throw new Exception("Nincs megadva modell"); }
            this.modell = modell;
            this.color = color;
            this.numberplate = numberplate;
            this.performance = performance;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} in {2} ({3} LE)", brand, modell, color, performance);
        }

        public override int CompareTo(Sortable x)
        {
            UsedCar c = x as UsedCar;

            if (this.performance < c.performance)
                return -1;
            if (this.performance < c.performance)
                return 1;
            return 0;
        }
    }
}
