using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /// <summary>
    /// 
    /// </summary>
    class StudentEnumerator : IEnumerable<Student>
    {
        List<Student> students;
        int index = -1;

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
                throw new Exception("Nem létező hallgató");
            }
        }

        public bool MoveNext()
        {
            do
            {
                index++;

            } while (index < students.Count && students[index].Suspended);
            return index < students.Count;
        }

        

        public void Dispose() //kitakarítja
        {
        }

        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class NameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            int r = x.Name.CompareTo(y.Name);
            if (r != 0) return r;

            else return x.Average.CompareTo(y.Average);  //ha megegyezik a név, akkor átlag szerint rendezi sorba
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class AverageComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return -x.Average.CompareTo(y.Average);  // - előjellel meg lehet fordítani a sorbarendezést
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class Student : IComparable
    {
        string name;
        public string Name
        {
            get { return name; }
        }
        byte age;
        public byte Age
        {
            get { return age; }
        }
        float average;
        public float Average
        {
            get { return average; }
        }
        bool suspended;
        public bool Suspended //fel vane függesztve?
        {
            get
            {
                return suspended;
            }
        }

        public void Suspend()
        {
            suspended = true;
        }

        public Student(string name, byte age, float average)
        {
            this.name = name;
            this.age = age;
            this.average = average;
            this.suspended = false;
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} years old with average: {2}", name, age, average);
        }

        public int CompareTo(object obj)
        {
            //this-t kell összehasonlítani az obj paraméterrel
            Student s = obj as Student;

            //if(this.age > s.age) return 1;  // ha a this megelőzi az obj-t, akkor pozitív, ha nem előzi meg, akkor negatív, ez így növekvő
            //if(this.age < s.age) return -1; 
            //return 0;  //egyébként 0
            //A fentivel életkor alapján hasonlít össze

            return this.name.CompareTo(s.name); //név abc sorrend alapján
        }

    }

    /// <summary>
    /// 
    /// </summary>
    class University : IEnumerator<Student>
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public int Count
        {
            get
            {
                return students.Count;
            }
        }

        public Student Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public Student this[int index]
        {
            get
            {
                return students[index];
            }
        }

        public void Sort(IComparer<Student> comparer)
        {
            students.Sort(comparer);
        }

        public IEnumerable<Student> GetEnumerator()
        {
            return new StudentEnumerator(students);
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            university.AddStudent(new Student("Chuck Norris", 220, 6));
            university.AddStudent(new Student("Bud Spencer", 73, 2.4f));
            university.AddStudent(new Student("Torrente", 54, 1));
            university.AddStudent(new Student("Bud Spencer", 73, 2.2f));
            university.AddStudent(new Student("Torrente", 54, 4));
            university.AddStudent(new Student("Torrente", 54, 3));

            university[3].Suspend();
            university.Sort(new NameComparer());


            for (int i = 0; i < university.Count; i++)
            {
                Console.WriteLine(university[i]);
            }
            Console.WriteLine();

            Console.ReadKey();



        }
    }
}
