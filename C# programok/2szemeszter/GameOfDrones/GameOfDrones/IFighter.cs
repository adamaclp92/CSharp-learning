using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDrones
{
    interface IFighter
    {
        void Bomb();
        void Shoot(Drone d);
    }
}
