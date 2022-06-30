using System;
using Figures;

namespace MindboxTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle);

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle);

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle);

            Figure figure = new Circle(10.9);
            Console.WriteLine(figure);

            figure = new Triangle(5.1, 6.7, 7.2);
            Console.WriteLine(figure);

            figure = new Rectangle(4, 6.3);
            Console.WriteLine(figure);
        }
    }
}
