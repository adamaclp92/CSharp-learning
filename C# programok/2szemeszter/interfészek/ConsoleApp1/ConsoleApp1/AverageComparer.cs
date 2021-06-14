using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AverageComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            //  return -(x.Average.CompareTo(y.Average)); minusszal a legjobb átlagút adja vissza

            int r = x.Name.CompareTo(y.Name);
            if (r != 0) return 0;

            return -(x.Average.CompareTo(y.Average)); //ha a név egyezik, akkor hasonlítja össza az átag alapján

        }
    }
}
