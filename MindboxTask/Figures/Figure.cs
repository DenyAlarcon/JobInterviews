using System;

namespace Figures
{
    public abstract class Figure
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        abstract public double Area();
        abstract public double Perimeter();
    }
}
