using ShapesCSharp;

namespace ShapesUnitTestCSharp;

[TestFixture]
public class ShapesAreaCalculatorTests
{
    [Test]
    public void CalculateArea_ValidSide_ReturnsCorrectArea()
    {
        double side = 3;
        double expected = 54;
        double actual = ShapesAreaCalculator.CalculateCubeArea(side);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CalculateArea_NegativeSide_ThrowsArgumentException()
    {
        double side = -2;
        Assert.Throws<ArgumentException>(() => ShapesAreaCalculator.CalculateCubeArea(side));
    }

    [TestCase(4, 5, 20)]
    [TestCase(6, 7, 40)]
    [TestCase(8, 9, 55)]
    public void testCalculateParalelogramAreaTC(double baseLength, double height, double expectedResult)
    {
        // double actual = ShapesAreaCalculator.CalculateParallelogramArea(baseLength, height);
        // Assert.AreEqual(expectedResult, actual);

        Assert.That(ShapesAreaCalculator.CalculateParallelogramArea(baseLength, height), Is.EqualTo(expectedResult));
    }
}