using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace könyvespolc
{
    class Program
    {
        public enum Műfaj { mese, regény, történelem, szakkönyv, külföldi }

        class Könyv
        {
            private String iro;
            public string Író
            {
                get
                {
                    return iro;
                }
                set
                {
                    if (value.Length >= 3 && value.Length <= 50)
                        iro = value;
                    else
                        throw new Exception("Az író nevének min. 3 max. 50 karakterből kell állnia!");
                }
            }

            private String cim;
            public String Cim
            {
                get
                {
                    return cim;
                }
                set
                {
                    if (value.Length >= 3 && value.Length <= 50)
                        cim = value;
                    else
                        throw new Exception("A könyv címének min. 3 max. 50 karakterből kell állnia!");
                }
            }

            private ushort kiadasiEv;
            public ushort Kiadásiév
            {
                get
                {
                    return kiadasiEv;
                }
                 set
                {
                    if (value >= 1920 && value <= DateTime.Now.Year)
                        kiadasiEv = value;
                    else
                        throw new Exception("Az évszám nem lehet korábbi 1920-nál és későbbi az aktuális évnél!");
                }
            }

            private uint ar;
            public uint Ár
            {
                get
                {
                    return ar;
                }
                set
                {
                    if (ar <= 30000 && ar % 5 == 0)
                        ar = value;
                    else
                        throw new Exception("A könyv ára nem lehet több, mint 30ezer Ft és oszthatónak kell lennie 5-el!");
                }
            }

            public Műfaj műfajok;
            public Könyv(string írója, string címe, ushort kiadásiéve, uint ára, Műfaj műfaja)
            {
                Író = írója;
                Cim = címe;
                Kiadásiév = kiadásiéve;
                Ár = ára;
                műfajok = műfaja;

            }
            public Könyv(string címe, uint ára, String írója) : this(írója, címe, 2019, ára, Műfaj.szakkönyv) { }
           
        }

        class Könyvespolc
        {
            List<Könyv> book = new List<Könyv>();

            public void AddBook(Könyv konyv)
            {
                book.Add(konyv);
            }
            public void TotalPrice()
            {
                int összeg = 0;
                for (int i = 0; i < book.Count; i++)
                {
                    összeg += (int)book[i].Ár;
                }
                Console.WriteLine("A könyvespolc összértéke: {0}Ft", összeg);
            }

            public List<string> Search(string keresíró)
            {
                List<string> keresett = new List<string>();

                for (int i = 0; i < book.Count; i++)
                {
                    if(book[i].Író == keresíró)
                    keresett.Add(book[i].Cim);
                }

                return keresett;

            }
        }


        static void Main(string[] args)
        {
            Könyvespolc polc = new Könyvespolc();
            Könyv egy = new Könyv("Stephen King", "Ragyogás", 1977, 3000, Műfaj.regény);

            polc.AddBook(new Könyv("Ragyogás", 3000, "Stephen King"));

            polc.TotalPrice();
          
            Console.WriteLine("Kérek egy írót!");
            string keresíró = Console.ReadLine();
            
            Console.WriteLine(polc.Search(keresíró)[0]);

            Console.ReadKey();

           
        }
        
    }
}
