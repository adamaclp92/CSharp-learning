using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsaZoli1
{
    class Pont
    {
        public Pont ()
            {
            this.x = x; this.y = y;
            }
       private int x;
       private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                if (value > 0 && value < Console.WindowWidth)
                {
                    x = value;
                }

                else
                {
                    Exception("Rossz koordináta");
                }
            }
        }

        public int Y
        {
            get
            { return y; }
            set
            {
                if (value > 0 && value < Console.WindowHeight)
                {
                    y = value;
                }

                else
                {
                    Exception("Rossz koordináta");
                }

            }
        }

        private void Exception(string s)
        {
            throw new FormatException(s);
        }

        public void Kirajzol()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("x");
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Pont p = new Pont();
            p.X = -10;
            p.Y = 60;
            p.Kirajzol();
           
            Console.ReadKey();
        }
    }
}
