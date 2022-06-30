using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Triangle : Figure
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
                if (value < 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным.");
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
                if (value < 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным.");
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
                if (value < 0)
                {
                    throw new ArgumentException($"Параметр {nameof(value)} не может быть отрицательным.");
                }
                sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
            {
                throw new ArgumentException($"Параметр {nameof(sideA)} не может быть отрицательным.");
            }
            if (sideB < 0)
            {
                throw new ArgumentException($"Параметр {nameof(sideB)} не может быть отрицательным.");
            }
            if (sideC < 0)
            {
                throw new ArgumentException($"Параметр {nameof(sideC)} не может быть отрицательным.");
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
            return Math.Pow(sides[2], 2) == Math.Sqrt(Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2));
        }
    }
}
