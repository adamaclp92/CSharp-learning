using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_feladat
{
   
    class Program
    {


        static void Main(string[] args)
        {
          

      /*      Első megoldás
         double piPerKetto = szamlalo/nevezo;  
         for (int i = 0; i < 10000; i++)
            { 
            
             if (i % 2 == 0)
                    nevezo += 2;
                
                else 
                    szamlalo += 2;

                piPerKetto *= szamlalo / nevezo;*/

            //Második Megoldás
            double piPerKetto = 1;
            for (double i = 2; i < 10000; i += 2)
            {
                piPerKetto *= i / (i - 1) * i / (i + 1);  
            }
            Console.WriteLine(piPerKetto*2);
            Console.ReadKey();
        }
    }
}
