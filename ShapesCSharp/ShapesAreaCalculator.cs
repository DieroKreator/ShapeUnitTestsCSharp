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

    public static double CalculatePyramidArea(double baseArea, double lateralArea)
    {
        if (baseArea < 0 || lateralArea < 0) throw new ArgumentException("Areas cannot be negative");
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

        double pyramidBaseArea = 10;
        double pyramidLateralArea = 20;
        double pyramidArea = CalculatePyramidArea(pyramidBaseArea, pyramidLateralArea);
        Console.WriteLine($"Pyramid area with base area {pyramidBaseArea} and lateral area {pyramidLateralArea} is {pyramidArea}");
    }
}