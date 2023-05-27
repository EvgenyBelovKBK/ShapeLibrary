using ShapeLibrary;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(2.8209479177388, 25.000000000000327)]
        [TestCase(-2.8209479177388, 25.000000000000327)]
        [TestCase(0, 0)]
        public void CircleGetAreaTest(double radius, double area)
        {
            var circle = new Circle(radius);
            var circleArea = AreaService.GetArea(circle);
            Assert.That(area, Is.EqualTo(circleArea));
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        public void TriangleGetAreaTest(double sideA, double sideB, double sideC, double area)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var triangleArea = AreaService.GetArea(triangle);
            Assert.That(area, Is.EqualTo(triangleArea));
        }

        [Test]
        [TestCase(3, 3, 9)]
        [TestCase(5, 3, 0)]
        public void TriangleInvalidCreationTest(double sideA, double sideB, double sideC)
        {
            var invalidTriangleCreation = () => new Triangle(sideA, sideB, sideC);
            Assert.Catch(typeof(ArgumentException), () => invalidTriangleCreation.Invoke());
        }

        [Test]
        [TestCase(3, 4, 5, true)]
        [TestCase(1, 2, 2, false)]
        public void IsRightTriangleTest(double sideA, double sideB, double sideC, bool isRight)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var isRightTriangle = triangle.IsRightTriangle();
            Assert.That(isRightTriangle, Is.EqualTo(isRight));
        }
    }
}