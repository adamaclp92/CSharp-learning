using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ragó_Ádám_zh
{
    class Program
    {
        static void Main(string[] args)
        {
            IngatlanNyilvantarto iny = new IngatlanNyilvantarto();

            StreamReader file = new StreamReader("ingatlanok.csv");
          
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(';');

                Ingatlan i;

                switch (data.Length)
                {
                    case 2:
                        i = (new Ingatlan(
                            data[0],
                            uint.Parse(data[1])));
                        iny.Add(i);
                        break;

                   case 4:
                        i = (new Termofold(
                        data[0],
                        uint.Parse(data[1]),
                        (muvelesiAg)Enum.Parse(typeof(muvelesiAg), data[2]),
                        float.Parse(data[3])
                        ));
                        iny.Add(i);
                        break;

                    case 6:
                        i = (new Lakoepulet(
                        data[0],
                        uint.Parse(data[1]),
                         data[2],
                        (fajta)Enum.Parse(typeof(fajta), data[3]),
                        bool.Parse(data[3])
                        ));
                        iny.Add(i);
                        break;

                    default:
                        throw new Exception("A CSV fájl nem megfelelő");
                }
            }
            for (int i = 0; i < iny.IngatlanCount; i++)
            {
                Console.WriteLine(iny[i]);
            }

            int legdragabb = iny.aLegdragabbIngatlan();
            Console.WriteLine("A legdrágább ingatlan: {0}", legdragabb);
            float termofoldatlag = iny.termofoldAtlag(muvelesiAg.erdo);
            Console.WriteLine("Az erdők átlagosan {0} hektár terüetűek.", termofoldatlag);
            iny.bontandoEpulet(fajta.csaladi_haz);

        }
    }
}


/*Ingatlannyilvántartás

Írj főprogramot, mely:
    Létrehoz egy ingatlan-nyilvántartó rendszer példányt és feltölti azt ingatlanokkal egy szöveges fájlból. A szöveges fájl innen letölthető.
    A példány property-jeinek/metódusainak hívásával kiírja a képernyőre:
        Mi a legdrágább ingatlan helyrajzi száma és ára?
        Átlagosan hány hektárosak az erdők?
        Az összes bontandó családi ház címe.
*/