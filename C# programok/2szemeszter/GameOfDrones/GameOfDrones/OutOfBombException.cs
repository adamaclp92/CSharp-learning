using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfDrones
{
    class OutOfBombException : Exception
    {
        public readonly FighterDrone fighterDrone;

        public OutOfBombException(FighterDrone fighterDrone)
        {
            // TODO: Complete member initialization
            this.fighterDrone = fighterDrone;
        }

    }
}
