using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    class Monitor_3D : Monitor
    {
        private string technology;

        public string Technology

        {
            get { return technology; }
            
        }

        private byte numberOfGlasses;

        public byte NumberOfGlasses
        {
            get { return numberOfGlasses; }
           
        }


        public Monitor_3D(ushort vertical_Resolution, ushort horizontal_Resolution, MonitorTypes m_Type, bool touchScreen, string technology, byte numberOfGlasses) 
            : base (vertical_Resolution, horizontal_Resolution, m_Type, touchScreen)
        {
            this.technology = technology;
            this.numberOfGlasses = numberOfGlasses;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), technology, numberOfGlasses);
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
*/
  