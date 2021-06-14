using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvespolc
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {

            Bookshelf book = new Bookshelf();
            Books b = new Books("George R. R. Martin", "Game of thrones", 2003, 28000, Books.Genre.regény);
            Books b2 = new Books("J. K. Rowling", "Harry Potter", 2001, 21000, Books.Genre.külföldi);
            Books b3 = new Books("Christopher Paolini", "Eragon", 2005, 18000, Books.Genre.külföldi);

            book.AddBook(b);
            book.AddBook(b2);
            book.AddBook(b3);

            book.TotalPrice();
      
            Console.ReadKey();

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