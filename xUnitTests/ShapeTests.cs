namespace MindBoxTests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            // Arrange
            Circle circle = new Circle(5);
            double expectedArea = 78.53981633974483;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CircleArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 2.5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 10);
        }

        [Fact]
        public void TriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double a = 7;
            double b = 10;
            double c = 12;
            Triangle triangle = new Triangle(a, b, c);
            double s = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 10);
        }

        [Fact]
        public void RightTriangleAreaTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void NonRightTriangleAreaTest()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 7);
            double expectedArea = 14.696938456699069;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
            Assert.False(triangle.IsRightTriangle());
        }
    }
}