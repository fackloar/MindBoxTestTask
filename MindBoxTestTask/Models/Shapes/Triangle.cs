namespace MindBoxTestTask.Models.Shapes
{
    public class Triangle : Shape
    {
        private double _side1, _side2, _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public bool IsRightTriangle()
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public override double CalculateArea()
        {
            if (IsRightTriangle())
            {
                double[] sides = { _side1, _side2, _side3 };
                Array.Sort(sides);
                double legsProduct = sides[0] * sides[1];

                return 0.5 * legsProduct;
            }
            else
            {
                double s = (_side1 + _side2 + _side3) / 2;
                return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
            }
        }
    }
}
