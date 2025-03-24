namespace AreaLibrary;

public static class ShapesAreaCalculator
{
    public class Cube
    {
        public static double CalculateArea(double side)
        {
            if (side < 0) throw new ArgumentException("Side length cannot be negative");
            return 6 * side * side;
        }
    }

    public class Parallelogram
    {
        public static double CalculateArea(double baseLength, double height)
        {
            if (baseLength < 0 || height < 0) throw new ArgumentException("Dimensions cannot be negative");
            return baseLength * height;
        }
    }

    public class Pyramid
    {
        public static double CalculateArea(double baseArea, double lateralArea)
        {
            if (baseArea < 0 || lateralArea < 0) throw new ArgumentException("Areas cannot be negative");
            return baseArea + lateralArea;
        }
    }
}