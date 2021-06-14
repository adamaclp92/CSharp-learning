using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static public bool haromszog(int a, int b, int c)
        {
            bool igaze = false;
            if (a + b > c)
            {
                if (a + c > b)
                {
                    if(b + c> a)
                    {
                        igaze = true;
                    }
                }
            }

            return igaze;
        }

        static public bool haromszog2(int a, int b, int c)
        {
            bool igaze = false;
            if (a + b > c && a + c > b && b + c > a)
            {
                igaze = true;
            }

            return igaze;
        }

        static public double tavolsag(Point Z, Point O)
        {
            return Math.Sqrt((Z.X-O.X)* (Z.X - O.X) + (Z.Y-O.Y)*(Z.Y - O.Y));
        }

        static public void korZombi(Point Z, Point O, double R)
        {
            if(tavolsag(Z, O) > R)
            {
                Console.WriteLine("Nem tudjuk lelőni ezt a Zombit!");
            } else if(tavolsag(Z,O) < R)
            {
                Console.WriteLine("Le tudjuk lőni ezt a Zombit!");
            } else
            {
                Console.WriteLine("Ez a Zombi mászkál a kerítésen!");
            }
        }

        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 15;

            Console.WriteLine(haromszog(a,b,c));
            Console.WriteLine(haromszog2(a,b,c));

            double R = 100;
            Point O = new Point(0, 0);

            Random rand = new Random();
            //List<Point> zombik = new List<Point>();
            for (int i = 0; i < 20; i++)
            {
                int X = rand.Next(150);
                int Y = rand.Next(150);
                Point ujZombi = new Point(X, Y);
                //zombik.Add(ujPont);
                Console.Write(ujZombi.ToString() + ":");
                korZombi(ujZombi, O, R);
            }

            Console.ReadKey();
        }
    }
}
