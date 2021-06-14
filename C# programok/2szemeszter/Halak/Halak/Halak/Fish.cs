using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halak
{
    class Fish
    {
        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0.5 || value > 40) throw new Exception("Nem jó a súly adat!");
                if (weight == 0) weight = value;
                else
                {
                    double arany = value * 100 / weight;
                  /*  if (0.9 <= arany && arany <= 1.1) weight = value;
                    else throw new Exception("Ennyivel nem ugorhat meg a sulya!");*/
                }
            }
        }

  

        private bool predator;

        public bool Predator
        {
            get { return predator; }
            set { predator = value; }
        }

        public int NumberOfPredator
        {
            get
            {
                int count = 0;
                if (Predator)
                {
                   count++;
                }
                return count;
            }
        }

        private int top;

        public int Top
        {
            get { return top; }
            set
            {
                if (value < 0 || value > 400) throw new Exception("0 cm és 400 cm közötti lehet a mélység, ami fölé nem merészkedik");
                top = value;
            }
        }

        private int depth;

        public int Depth
        {
            get { return depth; }
            set
            {
                if (value < 10 || value > 400) throw new Exception("10 cm és 400 cm közötti lehet a hal mozgási sávjának mélysége");
                depth = value;
            }
        }

        private TypeOfFish fishType;

        public TypeOfFish FishType
        {
            get { return fishType; }
            set
            {
                fishType = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Hal súlya: {0:F2}, ragadozó: {1}, víz magasság: {2}, mélység: {3}, fajta: {4} ", weight, predator, top, depth, fishType);
        }
    }



}


/*Egy halat (fish) jellemez, hogy a vízben milyen mélységben szeret úszni. Megadjuk ezen mélység-intervallum (tól-ig) felső határát (top) és mélységét (depth). 
 * Pl. ha top=30, depth=80, akkor a hal nem úszik 30 centinél közelebb a vízfelszínhez, és 1.1m (30cm+80cm=110cm) mélység alá sem úszik. Minden halnak van súlya, 
 * és tároljuk hogy ragadozó-e vagy növényevő.

weight: súlya, tört érték, 0.5 kilótól 40.0 kilóig valid, a hal súlya növekedhet és csökkenhet is, de egyszerre maximum az aktuális halsúly 10% -val
predator: ragadozó-e (vagy növényevő), bool, true/false, ha egyszer beállítottuk, nem módosítható
top: hány cm mélység fölé nem merészkedik, egész, 0cm-től 400cm-ig valid,
depth: hány cm a mozgási sávjának mélysége, egész, 10cm-től 400cm-ig valid
a halfaj (busa, keszeg, stb) string formában kerül tárolásra (most), a hal fajának neve nem lehet null, legalább 3 betű, maximum 30 betű hosszú lehet.

    Készítsünk egy listába

100 db halat,
90% eséllyel növényevőt,
különböző random súllyal és úszási mélységekkel, halfajjal,
írassuk ki a 100 halból hány darab lett végül is a ragadozó, mennyi a növényevő,
mennyi a legnagyobb súlyú hal súlya,
illetve számoljuk meg hány hal képes 1.1m mélységben úszni.
válasszunk random 2 halat, ha az egyik növényevő, a másik ragadozó, és az ragadozó be tud úszni a növényevő sávjába, akkor 30% eséllyel megeszi azt. 
Ekkor a ragadozó hal súlya nőjön meg, és töröljük a listából a növényevőt (100 ismétlés).
a végén írassuk ki a 100 halból hány darab és hány kilónyi növényevő halat ettek meg a ragadozók.
*/
