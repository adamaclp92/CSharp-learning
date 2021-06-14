using System;
using System.Collections.Generic;
using System.IO;

namespace magasprog_2_3
{
    class UsedCarShop
    {



        public List<UsedCar> cars = new List<UsedCar>();
        private List<UsedCar> soldCars = new List<UsedCar>();

        public int RemainingCarsCount
        {
            get
            {
                return cars.Count;
            }
        }

        public UsedCar Buy(CarBrand brand, string modell,
            ConsoleColor color, string numberplate, ushort performance)
        {
            UsedCar c = new UsedCar(brand, modell, color, numberplate, performance);
            cars.Add(c);
            return c;
        }

        public UsedCar this[int index]
        {
            get { return cars[index]; }
          
        }

        public UsedCar this[string numberplate]
        {
            get { return cars.Find(c => c.Numberplate == numberplate); }
        }

        public bool Sell(UsedCar car)
        {
            if(!cars.Remove(car))
                return false;

            soldCars.Add(car);

            return true;
        }

        public void LoadFromFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);

            while (!sr.EndOfStream)
            {
                
               string line = sr.ReadLine();
               string[] data = line.Split(';');

                cars.Add(
                    new UsedCar(
                        (CarBrand)Enum.Parse(typeof(CarBrand), data[0]),
                        data[1],
                        (ConsoleColor)Enum.Parse(typeof(ConsoleColor), data[2]),
                        data[3],
                        ushort.Parse(data[4])
                        ));


            }

        }
    }
}
