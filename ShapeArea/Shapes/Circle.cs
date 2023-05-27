namespace ShapeLibrary.Shapes
{
    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea() => Math.PI * (radius * radius);
    }
}