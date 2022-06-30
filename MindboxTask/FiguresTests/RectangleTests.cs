using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace FiguresTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Constructor_ReceivesNegativeWidth_ThrowsArgumentException()
        {
            double width = -10.00;
            double height = 10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Rectangle(width, height));
        }

        [TestMethod]
        public void Constructor_ReceivesZeroWidth_ThrowsArgumentException()
        {
            double width = 0.00;
            double height = 10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Rectangle(width, height));
        }

        [TestMethod]
        public void Constructor_ReceivesNegativeHeight_ThrowsArgumentException()
        {
            double width = 10.00;
            double height = -10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Rectangle(width, height));
        }

        [TestMethod]
        public void Constructor_ReceivesZeroHeight_ThrowsArgumentException()
        {
            double width = 10.00;
            double height = 0.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Rectangle(width, height));
        }

        [TestMethod]
        public void Constructor_ReceivesPositiveWidthAndHeight_Passes()
        {
            double width = 10.00;
            double height = 10.00;
            new Rectangle(width, height);
        }

        [TestMethod]
        public void Area_WithRectangleWidth10Height10_Returns100()
        {
            double width = 10.00;
            double height = 10.00;
            Rectangle rectangle = new Rectangle(width, height);
            double area = rectangle.Area();
            Assert.AreEqual(area, 100.00);
        }

        [TestMethod]
        public void Perimeter_WithRectangleWidth10Height10_Returns40()
        {
            double width = 10.00;
            double height = 10.00;
            Rectangle rectangle = new Rectangle(width, height);
            double perimeter = rectangle.Perimeter();
            Assert.AreEqual(perimeter, 40.00);
        }
    }
}
