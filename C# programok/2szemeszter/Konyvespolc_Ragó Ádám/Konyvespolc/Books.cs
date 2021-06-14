using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvespolc
{
    class Books
    {
        /// <summary>
        /// A könyv írója
        /// </summary>
        private string writer;

        public string Writer
        {
            get { return writer; }
            set
            {
                if (value.Length < 3 || value.Length > 50) { Exception("A könyv írójának minimum 3 és maximum 50 karakter hosszúnak kell lennie!"); }
                else { writer = value; }
            }
        }
        /// <summary>
        /// A könyv címe
        /// </summary>
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3 || value.Length > 50) { Exception("A könyv írójának minimum 3 és maximum 50 karakter hosszúnak kell lennie!"); }
                else { title = value; }
            }
        }
        /// <summary>
        /// A kiadás dátuma
        /// </summary>
        private ushort release;

        public ushort Release
        {
            get { return release; }
            set
            {
                if (value < 1910 || value > DateTime.Now.Year) { Exception("A kiadás dátuma 1910 és a jelenlegi év között lehet!"); }
                else { release = value; }
            }
        }
        /// <summary>
        /// A könyv ára
        /// </summary>
        private ushort price;

        public ushort Price
        {
            get { return price; }
            set
            {
                if (value > 30000 || value % 5 != 0) { Exception("A könyv maximális értéke 30 000 Ft, és az értéknek 5-tel oszthatónak kell lennie!"); }
                else { price = value; }
            }
        }
        /// <summary>
        /// A könyv műfaja
        /// </summary>
        public enum Genre
        { mese, regény, történelem, szakkönyv, külföldi }
        public Genre genre;

        /// <summary>
        /// Kivételkezelés függvény
        /// </summary>
        /// <param name="s"></param>
        private void Exception(string s)
        {
            throw new Exception(s);
        }
        /// <summary>
        /// Konstruktor, 5 mező értékével
        /// </summary>
        public Books(string Writer, string Title, ushort Release, ushort Price, Genre genre)
        {
            this.Writer = Writer;
            this.Title = Title;
            this.Release = Release;
            this.Price = Price;
            this.genre = genre;
        }

        /// <summary>
        /// Konstruktor, 3 mező értékével
        /// </summary>
        public Books(string Writer, string Title, ushort Price) : this(Writer, Title, 2019, Price, Genre.szakkönyv)
        { }
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
