using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDrones
{
    class FighterDrone: Drone, ISpectate,IFighter
    {
        ushort numberOfPhotos = 0;
        public ushort NumberOfPhotos
        {
            get
            {
                return numberOfPhotos;
            }
        }

        byte numberOfBombs;
        public byte NumberOfBombs
        {
            get
            {
                return numberOfBombs;
            }
            private set
            {
                numberOfBombs = value;
            }
        }

        float shootingRange;
        public float ShootingRange
        {
            get
            {
                return shootingRange;
            }
            set
            {
                if (value < 0)
                    throw new NegativeValueException(value);
                shootingRange = value;
            }
        }

        // CONSTRUCTOR

        public FighterDrone(ushort id, string name, PointF position, byte numberOfBombs, float shootingRange):
            base(id, name, position)
        {
            this.NumberOfBombs = numberOfBombs;
            this.ShootingRange = shootingRange;
        }

        // METHODS

        public override string ToString()
        {
            return string.Format("{0}: {1}={2} bombs={3} range={4}", base.ToString(), Spectrum.Thermal, numberOfPhotos, numberOfBombs, shootingRange);
        }

        public void Bomb()
        {
            if (numberOfBombs==0)
            {
                throw new OutOfBombException(this);
            }
            numberOfBombs--;
        }

        public void Shoot(Drone d)
        {
            if (Math.Pow(d.Position.X - this.Position.X, 2)
                + Math.Pow(d.Position.Y - this.Position.Y, 2)
                <= Math.Pow(shootingRange, 2))
                d.Kill();
            else
                throw new OutOfShootingRangeException(this, d);
        }

        public void TakePicture(Spectrum s)
        {
            if (s != Spectrum.Thermal)
                throw new PhotoException(this, s);
            numberOfPhotos++;
        }
    }
}
