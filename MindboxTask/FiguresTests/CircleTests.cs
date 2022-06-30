using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace FiguresTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Constructor_ReceivesNegativeRadius_ThrowsArgumentException()
        {
            double radius = -10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void Constructor_ReceivesZeroRadius_ThrowsArgumentException()
        {
            double radius = 0.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void Constructor_ReceivesPositiveRadius_Passes()
        {
            double radius = 10.00;
            new Circle(radius);
        }

        [TestMethod]
        public void Area_WithCircleRadius10_Returns100PI()
        {
            double radius = 10.00;
            Circle circle = new Circle(radius);
            double area = circle.Area();
            Assert.AreEqual(area, 100.00 * System.Math.PI);
        }

        [TestMethod]
        public void Perimeter_WithCircleRadius10_Returns20PI()
        {
            double radius = 10.00;
            Circle circle = new Circle(radius);
            double perimeter = circle.Perimeter();
            Assert.AreEqual(perimeter, 20.00 * System.Math.PI);
        }
    }
}
