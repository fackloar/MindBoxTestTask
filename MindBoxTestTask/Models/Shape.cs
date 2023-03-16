using MindBoxTestTask.Interfaces;

namespace MindBoxTestTask.Models
{
    public abstract class Shape : IAreaCalculator
    {
        public int _area;

        public abstract double CalculateArea();
    }
}
