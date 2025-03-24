using System;

class Program
{
    static void Main()
    {
        double side = 3;
        double expected = 54;
        double actual = AreaLibrary.ShapesAreaCalculator.Cube.CalculateArea(side);
        Console.WriteLine(expected == actual ? "Test passed" : "Test failed");

        side = -2;
        try
        {
            AreaLibrary.ShapesAreaCalculator.Cube.CalculateArea(side);
            Console.WriteLine("Test failed");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Test passed");
        }
    }
}