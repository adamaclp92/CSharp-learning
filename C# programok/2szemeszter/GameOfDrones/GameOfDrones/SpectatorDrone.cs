using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDrones
{
    class SpectatorDrone : Drone, ISpectate
    {
        private bool canShootTermal;

        public bool CanShootTermal
        {
            get
            {
                return canShootTermal;
            }
        }

        private ushort[] numberOfPhotos = new ushort[Enum.GetNames(typeof(Spectrum)).Length];

        public ushort this[int index]
        {
            get
            {
                return numberOfPhotos[index];
            }
        }

        // CONSTRUCTOR

        public SpectatorDrone(ushort id, string name, PointF position, bool canShootTermal)
            : base(id, name, position)
        {
            this.canShootTermal = canShootTermal;
        }

        // METHOD

        public override string ToString()
        {
            StringBuilder s = new StringBuilder(string.Format("{0}:", base.ToString()));
            for (int i = 0; i < numberOfPhotos.Length; i++)
            {
                s.Append(string.Format(" {0}={1}", (Spectrum)i, numberOfPhotos[i]));
            }
            return s.ToString();
        }

        public void TakePicture(Spectrum s)
        {
            if (s == Spectrum.Thermal && !canShootTermal)
                throw new PhotoException(s);
            numberOfPhotos[(int)s]++;
        }
    }
}