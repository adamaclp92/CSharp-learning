using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class University : IEnumerable<Student> //felsorolható, foreachel lesz kompatibilis az osztály, nem kell az indexelő property és a Count metódus, a bejáráshoz
     {
        List<Student> students = new List<Student>();

        public void Addstudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public Student this[int index]
        {
            get
            {
                return students[index];
            }
        }

        public int Count
        {
            get
            {
                return students.Count;
            }
        }
        public void Sort(IComparer<Student> comparer)
        {
            students.Sort(comparer);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new StudentEnumerator(students);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
