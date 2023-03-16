using MindBoxTestTask.Interfaces;

namespace MindBoxTestTask.Models
{
    public class ShapeAreaCalculator
    {
        public double CalculateArea(IAreaCalculator shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape));
            }
            return shape.CalculateArea();
        }
    }
}
