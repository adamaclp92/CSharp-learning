using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husvet
{
    class Pub
    {
        List<Person> people = new List<Person>();

        public int numberOfSprinklers
        {

            get
            {
                int numberOfDrunkards = 0;

                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i] is Sprinkler)
                        numberOfDrunkards++; 
                } 
                return numberOfDrunkards;
            }
        }

        public List<Sprinkler> PersonsWithParfume(ParfumeTypes parfumeTypes)
        {
            List<Sprinkler> selection = new List<Sprinkler>();
            foreach (Person p in people)
            {
                if (p is Sprinkler)
                { 
                  Sprinkler s = p as Sprinkler;
                  if (s.Parfume == parfumeTypes)
                      selection.Add(s);
                }
            }
            return selection;
        }

        public void Add(Person p)
        {
            people.Add(p);
        }
    }
}
    



/*A kocsmában húsvétkor összegyűlnek az emberek, azaz nyilvántartjuk a kocsmában összegyűlt emberek listáját.

    Írj property-t, mely visszaadja a kocsmában összegyűlt locsolkodók számát!

    Írj metódust, mely visszaadja a kocsmából azokat az embereket, akiknek a paraméterként megadott típusú kölni van a zsebében!*/