using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoazonosito
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gyujto = new List<int>();
            //első karakter
            int egy = 8;
            gyujto.Add(egy);

            //kiíratás
            Console.WriteLine("Add meg a születési dátumod, és legenerálok neked egy adószámot!\n A folytatáshoz nyomj meg egy gombot!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Add meg a születési évedet!");
            int ev = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add meg a születési hónapot!");
            int honap = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add meg a születési napot!");
            int nap = int.Parse(Console.ReadLine());
            Console.Clear();

            //2-6. karakter
            DateTime ketto = new DateTime(1867, 01, 01);
            DateTime enyem = new DateTime(ev, honap, nap);

            int result = (enyem - ketto).Days;
            int[] digits = result.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            for (int i = 0; i < digits.Length; i++)
            {
                gyujto.Add(digits[i]);
                
            }

            //7-9. karakter
            Random rnd = new Random();
            int[] masodikresz = new int[3];
            for (int i = 0; i < masodikresz.Length; i++)
            {
                masodikresz[i] = rnd.Next(1, 10);
                gyujto.Add(masodikresz[i]);
            }

            int a = 1;
            int sum = 0;
            for (int i = 0; i < gyujto.Count; i++)
            {
                sum += a * gyujto[i];
                a++;
            }

            int vegleges = sum % 11;
            gyujto.Add(vegleges);

            //kiíratás
            Console.WriteLine("Az azonosítószámod:");
            for (int i = 0; i < gyujto.Count; i++)
            {
                Console.Write(gyujto[i]);
            }
         
            Console.ReadKey();

        }
    }
}
