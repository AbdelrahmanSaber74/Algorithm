using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Circle area: " + ShapeCalculator.CalculateCircleArea(1));
                Console.WriteLine("Triangle area: " + ShapeCalculator.CalculateTriangleArea(4, 2));
                Console.WriteLine("Trapezoid area: " + ShapeCalculator.CalculateTrapezoidArea(4, 2, 3));
                Console.WriteLine("Rectangle area: " + ShapeCalculator.CalculateRectangleArea(4, 5));
                Console.WriteLine("Square area: " + ShapeCalculator.CalculateSquareArea(4));
                Console.WriteLine("Rhombus area: " + ShapeCalculator.CalculateRhombusArea(4, 5));
                Console.WriteLine("Parallelogram area: " + ShapeCalculator.CalculateParallelogramArea(4, 5));
                Console.WriteLine("Kite area: " + ShapeCalculator.CalculateKiteArea(4, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public static class ShapeCalculator
    {
        public static float CalculateCircleArea(float radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive.");

            // Area of a circle: πr²
            float area = (float)(Math.PI * Math.Pow(radius, 2));
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateTriangleArea(float baseLength, float height)
        {
            if (baseLength <= 0 || height <= 0)
                throw new ArgumentException("Base and height must be positive.");

            // Area of a triangle: 0.5 * base * height
            float area = 0.5f * baseLength * height;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateTrapezoidArea(float base1, float base2, float height)
        {
            if (base1 <= 0 || base2 <= 0 || height <= 0)
                throw new ArgumentException("Base lengths and height must be positive.");

            // Area of a trapezoid: 0.5 * (base1 + base2) * height
            float area = 0.5f * (base1 + base2) * height;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateRectangleArea(float length, float width)
        {
            if (length <= 0 || width <= 0)
                throw new ArgumentException("Length and width must be positive.");

            // Area of a rectangle: length * width
            float area = length * width;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateSquareArea(float side)
        {
            if (side <= 0)
                throw new ArgumentException("Side must be positive.");

            // Area of a square: side * side
            float area = side * side;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateRhombusArea(float diagonal1, float diagonal2)
        {
            if (diagonal1 <= 0 || diagonal2 <= 0)
                throw new ArgumentException("Diagonals must be positive.");

            // Area of a rhombus: 0.5 * diagonal1 * diagonal2
            float area = 0.5f * diagonal1 * diagonal2;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateParallelogramArea(float baseLength, float height)
        {
            if (baseLength <= 0 || height <= 0)
                throw new ArgumentException("Base and height must be positive.");

            // Area of a parallelogram: base * height
            float area = baseLength * height;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }

        public static float CalculateKiteArea(float diagonal1, float diagonal2)
        {
            if (diagonal1 <= 0 || diagonal2 <= 0)
                throw new ArgumentException("Diagonals must be positive.");

            // Area of a kite: 0.5 * diagonal1 * diagonal2
            float area = 0.5f * diagonal1 * diagonal2;
            return (float)Math.Round(area, 4); // Round to 4 decimal places
        }
    }
}