using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Szalak_4
{
    class Gyujto
    {
        static List<int> lista = new List<int>();
        const int maxMeret = 50;
        static bool _termelokLealltak = false;
        static int _termeloSzalFutDb = 0;
        static bool _fogyasztokLealltak = false;
        static int _fogyasztoSzalFutDb = 0;

        public static void fogyasztoSzalindul() {
            lock (typeof(Gyujto))
            { _fogyasztoSzalFutDb++; }
        }

        public static void fogyasztoSzalLeall() {
            lock (typeof(Gyujto))
            {
                if (_fogyasztoSzalFutDb > 0)
                    _fogyasztoSzalFutDb--;
                if (_fogyasztoSzalFutDb <= 0)
                {
                    _fogyasztokLealltak = true;
                    lock (lista)
                    { Monitor.PulseAll(lista); }
                }
            }
        }


        public static bool fogyasztokLealltak {
            get { return _fogyasztokLealltak; }
        }

        public static void termeloSzalndul() {
            lock (typeof(Gyujto))
            {
                _termeloSzalFutDb++;
            }
        }

        public static void termeloSzalLeall()
        {
            lock (typeof(Gyujto))
            {
                if (_termeloSzalFutDb > 0)
                    _termeloSzalFutDb--;
                if (_termeloSzalFutDb <= 0)
                {
                    _termelokLealltak = true;
                    lock (lista)
                    { Monitor.PulseAll(lista); }
                }
            }
        }


        public static bool termelokLealltak
        {
            get { return _termelokLealltak; }
        }

        public static int kivesz()
        {
            int x;
            lock (lista)
            {
                while (lista.Count == 0)
                {
                    Monitor.Wait(lista);

                    if (termelokLealltak)
                        throw new Exception("Leállt minden termelő");

                }
                x = lista[0]; lista.RemoveAt(0);
                Monitor.PulseAll(lista);
            }
            return x;
        }

        public static void berak(int x)
        {
            lock (lista)
            {
                while (lista.Count >= maxMeret)
                {
                    Monitor.Wait(lista);
                    if (fogyasztokLealltak)
                        throw new Exception("Leállt minden fogyasztó");

                }
                lista.Add(x);
                Monitor.PulseAll(lista);
            }
        }

    }
}
