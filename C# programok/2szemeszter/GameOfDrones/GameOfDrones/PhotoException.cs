using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfDrones
{
    class PhotoException : Exception
    {
        public readonly Spectrum s;
        public readonly FighterDrone fighterDrone;

        public PhotoException(Spectrum s)
        {
            // TODO: Complete member initialization
            this.s = s;
        }

        public PhotoException(FighterDrone fighterDrone, Spectrum s)
        {
            // TODO: Complete member initialization
            this.fighterDrone = fighterDrone;
            this.s = s;
        }
    }
}
