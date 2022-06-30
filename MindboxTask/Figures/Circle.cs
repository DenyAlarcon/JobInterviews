using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным.");
                }
                radius = value;
            }
        }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException($"Параметр {nameof(radius)} не может быть отрицательным.");
            }
            this.radius = radius;
            this.name = "Круг";
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
