using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsaZoli1
{
    class Human
    {
        public string name;
        public int age;
        public string city;
        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(city);
        }

        public Human(string n, int a, string city)
            {
            name = n;
            age = a;
            this.city = city;
            }
    }
}
