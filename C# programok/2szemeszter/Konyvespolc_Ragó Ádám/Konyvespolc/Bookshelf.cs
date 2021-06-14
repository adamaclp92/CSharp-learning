using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvespolc
{
    /// <summary>
    /// Konténerosztály
    /// </summary>
    class Bookshelf
    {
        List<Books> books = new List<Books>();
        
        public void AddBook(Books b)
        {
            books.Add(b);
        }

        /// <summary>
        /// Függvény, ami kiírja a könyvek összértékét.
        /// </summary>
        public void TotalPrice()
        {
                ushort sum = 0;
                for (int i = 0; i < books.Count; i++)
                {
                    sum += books[i].Price;
                }

                Console.WriteLine("A könyvek összértéke: {0} Ft.", sum); 
        }

    }
}

/*Egy könyvnek van:

írója (string): min. 3 betű, max. 50 betű
címe (string): min. 3 betű, max. 50 betű
kiadási éve (egész szám): min. 1910, max. az aktuális év
ára (egész szám): max. 30e Ft, 5-rel osztható
műfaja (enum): mese, regény, történelem, szakkönyv, külföldi
konstruktor az 5 mező kezdőértékével
konstruktor 3 mező értékével, az aktuális év legyen a kiadási év, a műfaj pedig szakkönyv

A könyveket egy könyvespolcon tároljuk, amely:

Tárolja könyveknek egy listáját.
AddBook(...) függvény: paramétere egy könyv, amelyet a könyvespolc listába kívánunk helyezni
TotalPrice: csak olvasható property, megadja a könyvespolcon tárolt könyvek összértékét
Search(...) függvény: egy paramétere egy író neve (string), visszatér könyvek egy listájával,
amelyek a könyvespolcon vannak tárolva, és amelyeknek az írója a megadott. Ha nem talál ilyen könyvet,
akkor 0 elemű listával tér vissza.

Főprogram:

Inicializál egy könyvespolcot, feltölti néhány megadott könyvvel.
Kiírja a könyvespolc összértékét.
Kilistázza egy választott íróhoz tartozó könyvek címeit.
*/
