// This file contains the implementation of the ShapesAreaCalculator class, which calculates the area of different shapes.
// The ShapesAreaCalculator class contains three static methods: CalculateCubeArea, CalculateParallelogramArea, and CalculatePyramidArea.
namespace ShapesCSharp;

public class ShapesAreaCalculator
{
    public static double CalculateCubeArea(double side)
    {
        if (side < 0) throw new ArgumentException("Side length cannot be negative");
        return 6 * side * side;
    }

    public static double CalculateParallelogramArea(double baseLength, double height)
    {
        if (baseLength < 0 || height < 0) throw new ArgumentException("Dimensions cannot be negative");
        return baseLength * height;
    }

    public static double CalculatePyramidSurfaceArea(double baseArea, double perimeter, double slantHeight)
    {
        if (baseArea < 0 || perimeter < 0 || slantHeight < 0)
            throw new ArgumentException("Values cannot be negative");

        double lateralArea = 0.5 * perimeter * slantHeight;
        return baseArea + lateralArea;
    }

    public static void Main()
    {
        double cubeSide = 3;
        double cubeArea = CalculateCubeArea(cubeSide);
        Console.WriteLine($"Cube area with side {cubeSide} is {cubeArea}");

        double parallelogramBase = 4;
        double parallelogramHeight = 5;
        double parallelogramArea = CalculateParallelogramArea(parallelogramBase, parallelogramHeight);
        Console.WriteLine($"Parallelogram area with base {parallelogramBase} and height {parallelogramHeight} is {parallelogramArea}");

        double pyramidBaseArea = 6;
        double pyramidPerimeter = 12;
        double pyramidSlantHeight = 5;  
        double pyramidSurfaceArea = CalculatePyramidSurfaceArea(pyramidBaseArea, pyramidPerimeter, pyramidSlantHeight);
        Console.WriteLine($"Pyramid surface area with base area {pyramidBaseArea}, perimeter {pyramidPerimeter}, and slant height {pyramidSlantHeight} is {pyramidSurfaceArea}");
    }
}