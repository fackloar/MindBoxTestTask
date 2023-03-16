namespace MindBoxTests
{
    public class ShapeAreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_Circle_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 2.5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();

            // Act
            double actualArea = calculator.CalculateArea(circle);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 10);
        }

        [Fact]
        public void CalculateArea_Triangle_ReturnsCorrectArea()
        {
            // Arrange
            double a = 7;
            double b = 10;
            double c = 12;
            Triangle triangle = new Triangle(a, b, c);
            double s = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();

            // Act
            double actualArea = calculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 10);
        }

        [Fact]
        public void CalculateArea_RightTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            double expectedArea = (a * b) / 2;
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();

            // Act
            double actualArea = calculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 10);
        }

        [Fact]
        public void CalculateArea_NullShape_ThrowsArgumentNullException()
        {
            // Arrange
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(null));
        }
    }
}
