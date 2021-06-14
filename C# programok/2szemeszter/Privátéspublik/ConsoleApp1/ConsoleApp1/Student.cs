using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
        }

        public byte Age
        {
            get
            {
                return (byte)(DateTime.Today.Year - dateOfBirth.Year);
            }
        }

       /* private byte age;
        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }

        }*/
        
  
        public Student(string initName, DateTime initDoB)
        {
            name = initName;
            dateOfBirth = initDoB;
        }

    }
}
