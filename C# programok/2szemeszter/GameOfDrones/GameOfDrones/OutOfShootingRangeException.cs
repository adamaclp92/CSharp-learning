using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfDrones
{
    class OutOfShootingRangeException : Exception
    {
        public readonly FighterDrone fighterDrone;
        public readonly Drone targetDrone;

        public OutOfShootingRangeException(FighterDrone fighterDrone, Drone d)
        {
            // TODO: Complete member initialization
            this.fighterDrone = fighterDrone;
            this.targetDrone = d;
        }
    }
}
