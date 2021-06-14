    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferivelgyak
{
    class Osztaly
    {
        List<Person> people = new List<Person>();

        public void Hozzaad(Person p)
        {
            if (p == null) throw new Exception("Nem lehet üres értéket hozzáadni!");

            people.Add(p);
        }

        public Person this[int index]
        {
            get
            {
                    return people[index];
            }
            set
            {
                    people[index] = value;

            }

        }

        public void listaz()
        {

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
        }


        public List<Fiuk> FiukListaz()
        {
            List<Fiuk> selection = new List<Fiuk>();
            foreach (Person p in people)
            {
                if (p is Fiuk)
                {
                    Fiuk s = p as Fiuk;
                    selection.Add(s);
                }
            }
            return selection;
        }

        public List<Lanyok> LanyokListaz()
        {
            List<Lanyok> selection = new List<Lanyok>();
            foreach (Person p in people)
            {
                if (p is Lanyok)
                {
                    Lanyok s = p as Lanyok;
                        selection.Add(s);
                }
            }
            return selection;
        }

        public List<Lanyok> KocsogLanyok()
        {
            List<Lanyok> selection = new List<Lanyok>();
            foreach (Person p in people)
            {
                if (p is Lanyok)
                {
                    Lanyok s = p as Lanyok;
                    if(s.Kocsoge)
                        selection.Add(s);
                }
            }
            return selection;
        }
    }
}
