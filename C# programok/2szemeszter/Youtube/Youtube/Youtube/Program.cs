using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "adam", LastName = "rago" });
            people.Add(new Person { FirstName = "asd", LastName = "asdasd" });

            foreach (var person in people)
            {
                Console.WriteLine($"Hello { person.FirstName} { person.LastName}");
            }

            Console.ReadLine();
        }
    }
}
