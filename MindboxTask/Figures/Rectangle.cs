using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным или меньшим нуля.");
                }
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным или меньшим нуля.");
                }
                height = value;
            }
        }

        public Rectangle(double width, double height)
        {
            if (width <= 0)
            {
                throw new ArgumentException($"Параметр {nameof(width)} не может быть отрицательным или меньшим нуля.");
            }
            if (height <= 0)
            {
                throw new ArgumentException($"Параметр {nameof(height)} не может быть отрицательным или меньшим нуля.");
            }
            this.width = width;
            this.height = height;
            this.name = "Прямоугольник";
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * width + 2 * height;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.name} с шириной {this.width:0.##} и высотой {this.height:0.##}.\n");
            sb.Append($"Площадь: {Area():0.##}.\n");
            sb.Append($"Периметр: {Perimeter():0.##}.\n");

            return sb.ToString();
        }
    }
}
