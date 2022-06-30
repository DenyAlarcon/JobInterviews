using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle : Figure
    {
        private double width;
        private double heigth;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным.");
                }
                width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным.");
                }
                heigth = value;
            }
        }

        public Rectangle(double width, double height)
        {
            if (width < 0)
            {
                throw new ArgumentException($"Параметр {nameof(width)} не может быть отрицательным.");
            }
            if (height < 0)
            {
                throw new ArgumentException($"Параметр {nameof(height)} не может быть отрицательным.");
            }
            this.width = width;
            this.heigth = height;
            this.name = "Прямоугольник";
        }

        public override double Area()
        {
            return width * heigth;
        }

        public override double Perimeter()
        {
            return 2 * width + 2 * heigth;
        }
    }
}
