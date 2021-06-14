using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_feladat
{
    class Rectangle
    {
        private double width;
        private double height;
        private double perimeter;
        private double area;
        private bool init = false;

        private void Init()
        {
            if (!init)
            {
                Width = 10;
                Height = 10;
                init = true;
            } 
        }

        private void setPerimeter()
        {
            perimeter = 2 * (width + height);
        }

        private void setArea()
        {
            area = width * height;
        }

        public double Width
        {
            get
            {
                Init();
                return width;
            }
            set
            {
                width = 0 < value ? value : 10;
                setPerimeter();
                setArea();
            }
        }
        public double Height
        {
            get
            {
                Init();
                return height;
            }
            set
            {
                height = 0 < value ? value : 10;
                setPerimeter();
                setArea();
            }
        }
        public double Perimeter
        {
            get
            {
                Init();
                return perimeter;
            }
        }
        public double Area
        {
            get
            {
                Init();
                return area;
            }
        }

    }
}
