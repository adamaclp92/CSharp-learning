using System;
using System.Threading;

namespace Kozos_valtozok
{
    class Osszeadas
    {
        public int bemeno_a; public int bemeno_b; public int kimeno_c;
        public volatile bool szal_kesz; public Exception kivetel;
        protected Thread t = null;
        public Osszeadas(int a, int b)
        {
            this.bemeno_a = a; this.bemeno_b = b;
            void indit()
            {
                this.t = new Thread(osszeadas); t.Start();
            }
            bool bevarMigKesz()
            {
                t.Join(); return szal_kesz;
            }
            void osszeadas()
            {
                try
                {
                    kimeno_c = bemeno_a + bemeno_b;
                    szal_kesz = true; //Ha ide jövünk, akkor tuti sikerült}
                }
                catch (Exception e)
                {
                    kivetel = e;  //a kivétel fajtája. }
                }
            }
        }
    }
class program
        {
            static void Main()
            {
                Osszeadas p = new Osszeadas(10, 20);
                p.indit();
                p.bevarMigKesz(); //elindítja a szálat
                if (p.szal_kesz) // megvárja, amíg fut le
                    Console.WriteLine(p.kimeno_c);
                else
                {
                    Console.WriteLine("A szál kivétel miatt állt le");
                    Console.WriteLine(p.kivetel.Message);
                }
                Console.ReadLine();
            }
        }
    }
