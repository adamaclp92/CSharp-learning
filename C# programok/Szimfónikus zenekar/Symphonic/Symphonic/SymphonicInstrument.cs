using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symphonic
{
    class SymphonicInstrument
    {
        List<Instrument> Instruments = new List<Instrument>();

        public int InstrumentsCount
        {
            get
            {
                return Instruments.Count;
            }
        }

        public void Add(Instrument i)
        {

            Instruments.Add(i);

        }

        public int numberOfBow
        {

            get
            {
                int count = 0;

                foreach (Instrument i in Instruments)
                {
                    if (i is StringedInstrument)
                    {
                        StringedInstrument s = i as StringedInstrument;
                        if (s.Bow)
                            count++;
                    }
                }
                return count;
            }
        }

        public int theMostExpensiveTypeIndex(typeOfStringed type)
        {
            int price = 0;
            int index = 0;

            for (int i = 0; i < InstrumentsCount; i++)
            {
                if (Instruments[i] is StringedInstrument)
                {
                    StringedInstrument s = Instruments[i] as StringedInstrument;
                    if (s.TypeStringed == type)
                    {
                        if (Instruments[i].Price > price)
                        {
                            price = Instruments[i].Price;
                            index = i;
                            
                        }
                    }
                }
            }
            return index;
        }

        public bool theMostExpensiveTypeElectric(int index)
        {
            StringedInstrument s = Instruments[index] as StringedInstrument;
            return s.Electric;
        }

        public float droolInTheConcert(uint ConcertLength)
        {
            float sum = 0;
            foreach (Instrument i in Instruments)
            {
                if (i is WindInstrument)
                {
                    WindInstrument w = i as WindInstrument;
                    sum += w.DroolPerMin * ConcertLength;
                }

            }
            return sum/100;
        }

        public Instrument this[int index]
        {
            get
            {
                return Instruments[index];
            }
        }

    }

}
