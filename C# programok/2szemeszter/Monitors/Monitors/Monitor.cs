using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    class Monitor
    {
        //vertikális felbontás
        private ushort vertical_Resolution;

        public ushort Vertical_Resolution
        {
            get { return vertical_Resolution; }
            private set
            {
                if (value % 10 != 0) throw new Exception("A monitor felbontásának 10-zel oszthatónak kell lennie!");
                else
                vertical_Resolution = value;
            }
        }

        //horizontális felbontás
        private ushort horizontal_Resolution;

        public ushort Horizontal_Resolution
        {
            get { return horizontal_Resolution; }
            private set
            {
                if (value % 10 != 0) throw new Exception("A monitor felbontásának 10-zel oszthatónak kell lennie!");
                else
                    horizontal_Resolution = value;
            }
        }

        public bool Full_Hd
        {
            get
            {

                return Horizontal_Resolution == 1920 && Vertical_Resolution == 1080;
            }
        }

        public bool Resolution_4k
        {
            get
            {
                return Horizontal_Resolution >= 3840 && Vertical_Resolution >= 1080;
               
            }
        }


        //típus
        private MonitorTypes m_Type;

        public MonitorTypes M_Type
        {
            get { return m_Type; }
           
        }

        //érintőképernyő
        private bool touchScreen;

        public bool TouchScreen
        {
            get { return touchScreen; }
          
        }

        public Monitor(ushort vertical_Resolution, ushort horizontal_Resolution, MonitorTypes m_Type, bool touchScreen)
        {
            this.Vertical_Resolution = vertical_Resolution;
            this.Horizontal_Resolution = horizontal_Resolution;
            this.m_Type = m_Type;
            this.touchScreen = touchScreen;
        }

      /*  public Monitor(ushort vertical_Resolution, ushort horizontal_Resolution, MonitorTypes m_Type)
        {
            this.vertical_Resolution = vertical_Resolution;
            this.horizontal_Resolution = horizontal_Resolution;
            this.m_Type = m_Type;
            touchScreen = false;
        }*/
       public Monitor(ushort vertical_Resolution, ushort horizontal_Resolution, MonitorTypes m_Type) : this(vertical_Resolution, horizontal_Resolution, m_Type, false) { }



        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} ",vertical_Resolution, horizontal_Resolution, m_Type, touchScreen);
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
*/