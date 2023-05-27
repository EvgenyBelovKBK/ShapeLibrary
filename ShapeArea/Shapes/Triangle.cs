namespace ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            if (!IsValid())
                throw new ArgumentException("Triangle sides are invalid");
        }

        public double GetArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        private bool IsValid()
        {
            var isZeroInput = sideA <= 0 || sideB <= 0 || sideC <= 0; 
            return !isZeroInput && 
                   sideA + sideB > sideC &&
                   sideA + sideC > sideB &&
                   sideB + sideC > sideA;
        }

        public bool IsRightTriangle()
        {
            var squareSideA = sideA * sideA;
            var squareSideB = sideB * sideB;
            var squareSideC = sideC * sideC;
            return squareSideA == squareSideB + squareSideC || 
                   squareSideB == squareSideA + squareSideC ||
                   squareSideC == squareSideA + squareSideB;
        }
    }
}

