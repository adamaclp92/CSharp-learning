using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Monitor
{

    public enum Tipus
    {
        LCD, LED, Plasma
    }

    class Monitor
    {

        private int vertikális;
        private int horizontális;
        private bool érintőképernyős;
        private Tipus tipus;

        public int Vertikális { get { return vertikális; } set { vertikális = value; } }
        public int Horizontális { get { return horizontális; } set { horizontális = value; } }
        public bool Érintőképernyős { get { return érintőképernyős; } set { érintőképernyős = value; } }

        public Monitor(int vertikális, int horizontális, Tipus tipus, bool érintőképernyős)
        {
            this.Vertikális = vertikális;
            this.Horizontális = horizontális;
            this.Érintőképernyős = érintőképernyős;
            this.tipus = tipus;
        }

        public Monitor(int vertikális, int horizontális, Tipus tipus)
        {
            this.Vertikális = vertikális;
            this.Horizontális = horizontális;
            this.Érintőképernyős = false;
            this.tipus = tipus;
        }

        public bool FullHd()
        {
            if (Vertikális > 2000 && Horizontális > 1500)
                return true;
            else return false;
        }

        public bool NégyK()
        {
            if (Vertikális > 4000 && Horizontális > 2500)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return "Monitor: " + Vertikális + " x " + Horizontális + " " + tipus + " " + Érintőképernyős;
        }

    }

    class Studio
    {

        public List<Monitor> monitorok = new List<Monitor>();

        public void AddMonitor(Monitor m)
        {

            monitorok.Add(m);
        }


        class Program
        {
            static void Main(string[] args)
            {
                
                Studio st = new Studio();


                StreamReader sr = new StreamReader("TextFile1.csv");
                while (!sr.EndOfStream)
                {
                    Monitor m;
                    string line = sr.ReadLine();
                    string[] data = line.Split(';');

                    switch (data.Length)
                    {
                        case 4:
                           st.AddMonitor(new Monitor(
                           int.Parse(data[0]),
                           int.Parse(data[1]),
                           (Tipus)Enum.Parse(typeof(Tipus), data[2]),
                           bool.Parse(data[3])
                           ));

                            
                            Console.WriteLine(m);
                          

                            break;


                    }

                    
                }
                


                Console.ReadLine();
            }
        }
    }

}






/*Egy monitort jellemeznek a következő adatok:

felbontás(vertikális és horizontális), 10-zel osztható
típus: LCD, LED, Plasma stb.
érintőképernyő-e?
konstruktor a 4 mező kezdőértékével
konstruktor 3 mező kezdőértékével, a bool mező false legyen
Írj property-t, mely megmondja, hogy Full HD-e (1080p)?
Írj property-t, mely megmondja, hogy 4K-e?

Egy 3D monitort a fentieken túl a következő adatok jellemeznek:
aktív vagy passzív technológiát használ?
hány szemüveget mellékel a gyártó a monitorhoz?
konstruktor az összes mező kezdőértékével
Egy grafikai stúdióban monitorok sokaságát használják.Írj property-ket/metódusokat ehhez az osztályhoz:

Hány darab van adott típusú (LCD, LED, Plasma stb.) monitorból?
Hány 4K felbontású monitor van?
Hány 3D monitor van?
Hány aktív szemüveg van a stúdió birtokában?
Új monitor hozzáadása: Csak akkor vehessen a stúdióhoz egy új monitort, ha annak horizontális felbontása legalább olyan nagy, mint az eddigi legjobb monitoré.

Írj Main eljárást, mely
példányosít egy grafikai stúdiót
egy szöveges fájlból beolvassa a stúdió monitorainak adatait és hozzáadja azokat a stúdióhoz
listázza a stúdió monitorait a képernyőn
kiírja egyenként, hogy hány darab van ebből és amabból a fajta eszközből, a megfelelő metódusok hívásával (ehhez akár egy menüt is készíthetsz)
*/