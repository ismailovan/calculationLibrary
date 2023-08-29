using CalculationLibrary.Shapes;

using NUnit.Framework;


namespace CalculationLibrary.Tests
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(6);
            double expectedArea = Math.PI * 36;
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            double actualArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle nonRightTriangle = new Triangle(4, 5, 6);
            Assert.IsTrue(rightTriangle.IsRightAngled());
            Assert.IsFalse(nonRightTriangle.IsRightAngled());
        }
    }
}
