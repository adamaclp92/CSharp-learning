using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:IComparable
    {
        string name;
        byte age;
        float average;
        bool suspended;


        public string Name
        {
            get
            {
                return name;
            }
        }

        public float Average
        {
            get
            {
                return average;
            }
        }

        public bool Suspended
        {
            get
            {
                return suspended;
            }
        }

        public void Suspend() //inaktív?
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
            return string.Format("{0} is {1} years old, with average: {2}", name, age, average);
        }

        public int CompareTo(object obj)
        {
            //THIS-t kell összehasonlítani az obj-val
            Student s = obj as Student;

            /* if (this.age > s.age) return 1; életkor szerinti összehasonlítás
             if (this.age < s.age) return -1;
             return 0;*/

            return this.name.CompareTo(s.name); //név alapján sorbarendezés (stringeket így lehet)
            
        }
    }
}
