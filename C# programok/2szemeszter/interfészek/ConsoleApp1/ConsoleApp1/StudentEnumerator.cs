using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StudentEnumerator : IEnumerator<Student>
    {
        List<Student> students;
        int index = -1; //hanyadik elemnél járok kezdetben

        public StudentEnumerator(List<Student> students)
        {
            this.students = students;
        }

        public Student Current
        {
            get
            {
                if (index >= 0 && index < students.Count)
                    return students[index];
                throw new Exception("Nem létező hallgató!");
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() //ha felhasználtuk a példányt, akkor ki kell takarítani ezzel a metódussal. Ha üresen hagyjuk akkor a garbage collector elvégzi
        {
        }

        public bool MoveNext()
        {
            do
            {
                index++;
            } while (index < students.Count && students[index].Suspended);
            return index < students.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
