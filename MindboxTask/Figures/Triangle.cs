using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным или меньшим нуля.");
                }
                sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным или меньшим нуля.");
                }
                sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным или меньшим нуля.");
                }
                sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException($"Параметр {nameof(sideA)} не может быть отрицательным или меньшим нуля.");
            }
            if (sideB <= 0)
            {
                throw new ArgumentException($"Параметр {nameof(sideB)} не может быть отрицательным или меньшим нуля.");
            }
            if (sideC <= 0)
            {
                throw new ArgumentException($"Параметр {nameof(sideC)} не может быть отрицательным или меньшим нуля.");
            }
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.name = "Треугольник";
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public bool IsRightAngled()
        {
            List<double> sides = new List<double>() { sideA, sideB, sideC };
            sides.Sort();
            return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (IsRightAngled())
                sb.Append($"Прямоугольный {this.name.ToLower()} ");
            else
                sb.Append($"{this.name} ");
            sb.Append($"со сторонами {this.sideA:0.##}, {this.sideB:0.##} и {this.sideC:0.##}.\n");
            sb.Append($"Площадь: {Area():0.##}.\n");
            sb.Append($"Периметр: {Perimeter():0.##}.\n");

            return sb.ToString();
        }
    }
}
