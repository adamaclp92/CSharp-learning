using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    class Program
    {
        static void Main(string[] args)
        {
            Studio st = new Studio();
            Console.WriteLine("A stúdióban megtalálható monitorok: \n");

            StreamReader file = new StreamReader("StudioMonitors.csv");
         
            while (!file.EndOfStream)
            {

                string line = file.ReadLine();
                string[] data = line.Split(';');

                Monitor m;

                switch (data.Length)
                {
                    case 4:
                        m =  (new Monitor(
                        ushort.Parse(data[0]),
                        ushort.Parse(data[1]),
                        (MonitorTypes)Enum.Parse(typeof(MonitorTypes), data[2]),
                        bool.Parse(data[3])
                        ));
                        Console.WriteLine("{0}", m);
                        st.Add(m);
                        break;

                    case 6:
                        m = (new Monitor_3D(
                        ushort.Parse(data[0]),
                        ushort.Parse(data[1]),
                        (MonitorTypes)Enum.Parse(typeof(MonitorTypes), data[2]),
                        bool.Parse(data[3]),
                        data[4],
                        byte.Parse(data[5])));
                        Console.WriteLine("{0}", m);
                        st.Add(m);
                        break;

                    default:
                        throw new Exception("A CSV fájl nem megfelelő");  
                }
            }

            Console.WriteLine("\nA 3D monitorok száma: {0}",st.numberOf3DMonitors);
            Console.WriteLine("A 4K felbontású monitorok száma: {0}",st.numberOf4K);
            Console.WriteLine("A szemüvegek száma: {0}",st.numberOfglasses);
            Console.ReadKey();
            
        }
    }
}
/*Egy monitort jellemeznek a következő adatok:

felbontás (vertikális és horizontális), 10-zel osztható
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


Egy grafikai stúdióban monitorok sokaságát használják. Írj property-ket/metódusokat ehhez az osztályhoz:
s
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