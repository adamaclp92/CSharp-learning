using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDrones
{
    class Drone
    {
        private ushort id;

        public ushort Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (value == 0)
                    throw new Exception("Nem pozitív érték");
                // THROW OWN EXCEPTION OBJECT
                id = value;
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (value.Length < 3)
                    throw new TooShortStringException(value);
                name = value;
            }
        }

        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public void Kill()
        {
            isAlive = false;
        }

        PointF position;

        public PointF Position
        {
            get { return position; }
//            set { position = value; }
        }

        // FLY METHOD

        public void Fly(float x, float y) {
            position.X = x;
            position.Y = y;
        }

        // CONSTRUCTOR

        public Drone(ushort id, string name, PointF position)
        {
            this.Id = id;
            this.Name = name;
            this.position = position;
            this.isAlive = true;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}){2}", id, name, isAlive ? "" : " DEAD");
        }
    }
}
