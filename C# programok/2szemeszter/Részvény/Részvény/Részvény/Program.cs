using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Részvény
{

    class Részvény
    {

        private readonly string részvénynév;

        public string Részvénynév
        {
            get { return részvénynév; }
        }


        private double részvényárfolyam;

        public double Részvényárfolyam
        {
            get { return részvényárfolyam; }
            set { részvényárfolyam = value; }
        }

     
        private int darabszám;

        public int Darabszám
        {
            get { return darabszám; }
            set { darabszám = value; }

        }


        public Részvény(string név, double árfolyam, int darabszám)
        {
            this.részvénynév = név;
            this.részvényárfolyam = árfolyam;
            this.darabszám = darabszám+5;
            

        }

        public void Vétel(int mennyiség)
        {
            darabszám += mennyiség;
        }

        public void Eladás(int mennyiség)
        {
            darabszám -= mennyiség;
        }

        public void ÁrfolyamBeállítás(double árfolyam)
        {
            részvényárfolyam = árfolyam;
        }

        public  double Érték(int darabszám, double részvényárfolyam)
        {
            double érték = darabszám * részvényárfolyam;
            return érték;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Részvény IBM = new Részvény("IBM", 77.59, 100);
            Részvény nVidia = new Részvény("NVIDIA", 21.49, 100);
            IBM.Darabszám = 200;
            IBM.Vétel(50);
            nVidia.Vétel(25);
            nVidia.ÁrfolyamBeállítás(29.15);
            nVidia.Eladás(50);
            double ibm_érték = IBM.Érték(IBM.Darabszám, IBM.Részvényárfolyam);
            double nvidia_érték = nVidia.Érték(nVidia.Darabszám, nVidia.Részvényárfolyam);
            Console.WriteLine("{0}: Árfolyam: {1}, Darabszám: {2}, Érték: {3:N2}", IBM.Részvénynév, IBM.Részvényárfolyam, IBM.Darabszám, ibm_érték);
            Console.WriteLine("{0}: Árfolyam: {1}, Darabszám: {2}, Érték: {3:N2}", nVidia.Részvénynév, nVidia.Részvényárfolyam, nVidia.Darabszám, nvidia_érték);
            Console.ReadLine();
        }
    }
}
