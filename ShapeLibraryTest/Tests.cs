using ShapeLibrary;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(2.8209479177388, 25.000000000000327)]
        [TestCase(0, 0)]
        public void CircleAreaTest(double radius, double value)
        {
            Assert.That(value, Is.EqualTo(AreaService.GetArea(new Circle(radius))));
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        public void TriangleAreaTest(double sideA, double sideB, double sideC, double value)
        {
            Assert.That(value, Is.EqualTo(AreaService.GetArea(new Triangle(sideA, sideB, sideC))));
        }

        [Test]
        [TestCase(3, 3, 9)]
        [TestCase(123, 3, 1)]
        [TestCase(5, 3, 0)]
        public void TriangleInvalidTest(double sideA, double sideB, double sideC)
        {
            Assert.Catch(typeof(ArgumentException), () => new Triangle(sideA, sideB, sideC));
        }

        [Test]
        [TestCase(3, 4, 5, true)]
        [TestCase(1, 2, 2, false)]
        public void TriangleRightTest(double sideA, double sideB, double sideC, bool isRight)
        {
            Assert.That(new Triangle(sideA, sideB, sideC).IsRightTriangle(), Is.EqualTo(isRight));
        }
    }
}