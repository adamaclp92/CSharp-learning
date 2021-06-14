using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            University university = new University();

            university.Addstudent(new Student("Chuck Norris", 220, 6));
            university.Addstudent(new Student("Bud Spencer", 73, 2.4f));
            university.Addstudent(new Student("Torrente",54, 1));
            university.Addstudent(new Student("Torrente", 38, 5));
            university.Addstudent(new Student("Torrente", 42, 3.6f));

            university[2].Suspend();

            university.Sort(new NameComparer());

            for (int i = 0; i < university.Count; i++)
            {
                Console.WriteLine(university[i]);
            }
            Console.WriteLine();
            university.Sort(new AverageComparer());

            for (int i = 0; i < university.Count; i++)
            {
                Console.WriteLine(university[i]);
            }

            Console.WriteLine();

            foreach (Student s in university)
            {
                Console.WriteLine(s);
               
            }

            Console.ReadKey();
        }
    }
}
