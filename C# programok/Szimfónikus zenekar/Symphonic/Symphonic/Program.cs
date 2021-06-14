using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Symphonic
{
    class Program
    {
        static void Main(string[] args)
        {
            SymphonicInstrument si = new SymphonicInstrument();

            StreamReader file = new StreamReader("instrumentS.csv");
            int numberOfSmoothInstrument = 0;
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(';');

                Instrument i;

                switch (data.Length)
                {
                    case 2:
                        i = (new Instrument(
                            data[0],
                            int.Parse(data[1])));
                        si.Add(i);
                        numberOfSmoothInstrument++;
                        break;

                    case 4:
                        i = (new WindInstrument(
                        data[0],
                        int.Parse(data[1]),
                        (typeOfWind)Enum.Parse(typeof(typeOfWind), data[2]),
                        float.Parse(data[3])
                        ));
                        si.Add(i);
                        break;

                    case 6:
                        i = (new StringedInstrument(
                       data[0],
                       int.Parse(data[1]),
                       (typeOfStringed)Enum.Parse(typeof(typeOfStringed), data[2]),
                       int.Parse(data[3]),
                       bool.Parse(data[4]),
                       bool.Parse(data[5])
                       ));
                        si.Add(i);
                        break;

                    default:
                        throw new Exception("A CSV fájl nem megfelelő");
                }
            }
          
            for (int i = 0; i < si.InstrumentsCount; i++)
            {
                Console.WriteLine(si[i]);  
            }

            int index = si.theMostExpensiveTypeIndex(typeOfStringed.gitar);
            bool electric = si.theMostExpensiveTypeElectric(index);
            string favoriteSong = "Faint From Linkin Park";
            
            Console.WriteLine("\nVonó a zenekarban: {0}", si.numberOfBow);
            Console.WriteLine("Se nem húros, se nem fúvós hangszer darab: {0}", numberOfSmoothInstrument);
            Console.WriteLine("A legdrágább gitár adatai: {0}",si[index]);
            if (electric) Console.WriteLine("Yeah, ez a zenekar akár ezt a számot is nyomhatná: {0}", favoriteSong);

            Console.WriteLine("\n\n-------------------------");
            uint length = 0;
            do
            {
                Console.WriteLine("\n\nAdd meg a Mozart Requiem koncert hosszát (50 - 70 perc között)!");
                length = uint.Parse(Console.ReadLine());
            } while (!(length >= 50 && length <= 70));
            Console.WriteLine("A koncert alatt termelődő nyál: {0} liter.", si.droolInTheConcert(length));

        Console.ReadKey();

        }
    }
}

