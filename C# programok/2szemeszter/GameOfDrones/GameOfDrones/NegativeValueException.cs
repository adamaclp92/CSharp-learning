using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfDrones
{
    class NegativeValueException : Exception
    {
        public readonly float value;

        public NegativeValueException(float value)
        {
            // TODO: Complete member initialization
            this.value = value;
        }
    }
}
