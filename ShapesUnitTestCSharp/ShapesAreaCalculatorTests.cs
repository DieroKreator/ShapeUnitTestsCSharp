using NUnit.Framework;
using static ShapesCSharp.ShapesAreaCalculator;

namespace ShapesUnitTestCSharp;

[TestFixture]
public class ShapesAreaCalculatorTests
{
    [Test]
    public void CalculateArea_ValidSide_ReturnsCorrectArea()
    {
        double side = 3;
        double expected = 54;
        double actual = Cube.CalculateArea(side);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CalculateArea_NegativeSide_ThrowsArgumentException()
    {
        double side = -2;
        Assert.Throws<ArgumentException>(() => Cube.CalculateArea(side));
    }
}