using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace magasprog_2_3
{
  
    class Program
    {
        static void BubbleSort(List<Sortable> arr)
        {
            Sortable temp = null;

            for (int write = 0; write < arr.Count; write++)
            {
                for (int sort = 0; sort < arr.Count-1; sort++)
                {
                    if (arr[sort].CompareTo(arr[sort + 1]) > 0)
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            UsedCarShop shop = new UsedCarShop();
            shop.LoadFromFile("Cars.csv");

            /*   UsedCar c = shop[0];
               Console.WriteLine(c);

               Console.WriteLine(shop["2FAST"]);*/

            UsedCar t = shop["Musk-1"]; //tunngolás, operátor overload
            t +=  60;

            UsedCar tr = shop["SEXY-1"];
            if (t < tr)
            {
                Console.WriteLine("A trabant a király");
            }
            else {
                Console.WriteLine("Akkor is a trabant a király");
            }

            ushort x = (ushort)tr; //explicit overload

            BubbleSort(shop.cars);

            for (int i = 0; i < shop.RemainingCarsCount; i++)
            {
                Console.WriteLine(shop[i]);
            }


            Console.ReadKey();
          
        }
    }
}

