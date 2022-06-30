using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace FiguresTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Constructor_ReceivesNegativeSideA_ThrowsArgumentException()
        {
            double sideA = -10.00;
            double sideB = 10.00;
            double sideC = 10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Constructor_ReceivesZeroSideA_ThrowsArgumentException()
        {
            double sideA = 0.00;
            double sideB = 10.00;
            double sideC = 10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Constructor_ReceivesNegativeSideB_ThrowsArgumentException()
        {
            double sideA = 10.00;
            double sideB = -10.00;
            double sideC = 10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Constructor_ReceivesZeroSideB_ThrowsArgumentException()
        {
            double sideA = 10.00;
            double sideB = 0.00;
            double sideC = 10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Constructor_ReceivesNegativeSideC_ThrowsArgumentException()
        {
            double sideA = 10.00;
            double sideB = 10.00;
            double sideC = -10.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Constructor_ReceivesZeroSideC_ThrowsArgumentException()
        {
            double sideA = 10.00;
            double sideB = 10.00;
            double sideC = 0.00;
            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void Constructor_ReceivesPositiveSideAAndSideBAndSideC_Passes()
        {
            double sideA = 10.00;
            double sideB = 10.00;
            double sideC = 10.00;
            new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        public void Area_WithTriangleSideA3SideB4SideC5_Returns6()
        {
            double sideA = 3.00;
            double sideB = 4.00;
            double sideC = 5.00;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double area = triangle.Area();
            Assert.AreEqual(area, 6.00);
        }

        [TestMethod]
        public void Perimeter_WithTriangleSideA10SideB10SideC10_Returns30()
        {
            double sideA = 10.00;
            double sideB = 10.00;
            double sideC = 10.00;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double perimeter = triangle.Perimeter();
            Assert.AreEqual(perimeter, 30.00);
        }

        [TestMethod]
        public void IsRightAngled_WithTriangleSideA10SideB10SideC10_ReturnsFalse()
        {
            double sideA = 10.00;
            double sideB = 10.00;
            double sideC = 10.00;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRigthTriangle = triangle.IsRightAngled();
            Assert.AreEqual(isRigthTriangle, false);
        }

        [TestMethod]
        public void IsRightAngled_WithTriangleSideA6SideB8SideC10_ReturnsTrue()
        {
            double sideA = 6.00;
            double sideB = 8.00;
            double sideC = 10.00;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRigthTriangle = triangle.IsRightAngled();
            Assert.AreEqual(isRigthTriangle, true);
        }
    }
}
