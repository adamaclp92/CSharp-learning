using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monitors
{
    class Studio
    {
        List<Monitor> StudioMonitors = new List<Monitor>();

        public int MonitorsCount
        {
            get
            {
                return StudioMonitors.Count;
            }
        }

        public int numberOf3DMonitors
        {

            get
            {
                int count = 0;

                for (int i = 0; i < StudioMonitors.Count; i++)
                {
                    if (StudioMonitors[i] is Monitor_3D)
                        count++;
                }
                return count;
            }
        }

        public int numberOf4K
        {

            get
            {
                int count = 0;

                for (int i = 0; i < StudioMonitors.Count; i++)
                {
                    if (StudioMonitors[i].Resolution_4k)
                        count++;
                }
                return count;
            }
        }

        public int numberOfglasses
        {
            get
            {
                int count = 0;
                foreach (Monitor m in StudioMonitors)
                {
                    if (m is Monitor_3D)
                    {
                        Monitor_3D s = m as Monitor_3D;
                        count += s.NumberOfGlasses;
                    }
                }
                return count;
            }
        }

        public void Add(Monitor m)
        {

            StudioMonitors.Add(m);

        }
    }
}

       
     


/*
Egy grafikai stúdióban monitorok sokaságát használják. Írj property-ket/metódusokat ehhez az osztályhoz:

Hány darab van adott típusú (LCD, LED, Plasma stb.) monitorból?
Hány 4K felbontású monitor van?
Hány 3D monitor van?
Hány aktív szemüveg van a stúdió birtokában?
Új monitor hozzáadása: Csak akkor vehessen a stúdióhoz egy új monitort, ha annak horizontális felbontása legalább olyan nagy, mint az eddigi legjobb monitoré.
*/