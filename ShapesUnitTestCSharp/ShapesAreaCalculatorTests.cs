using ShapesCSharp;

namespace ShapesUnitTestCSharp;

[TestFixture]
public class ShapesAreaCalculatorTests
{
    // Function to read data from a csv file
    public static IEnumerable<TestCaseData> lerDadosDeTeste(string operacao)
    {
        String caminhoMassa = "/Users/dierokreator/Programming/Interasys/ShapeUnitTestsCSharp/ShapesUnitTestCSharp/fixtures/"; // Caminho do arquivo csv

        switch (operacao)
        {
            case "1":
                caminhoMassa += "massaAreaPyramid.csv";
                break;
            case "2":
                caminhoMassa += "massaAreaParallelogram.csv";
                break;
        }

        using (var reader = new StreamReader(caminhoMassa))
        {
            // pular a primeira linha - cabeçalho
            reader.ReadLine();

            // repetir as acoes ate a condicao se realizar
            // no caso, seria ate o arquivo CSV terminar
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                // double baseLength = double.Parse(values[0]);
                // double perimeter = double.Parse(values[1]);
                // double slantHeight = double.Parse(values[2]);
                // double expectedResult = double.Parse(values[3]);

                yield return new TestCaseData(double.Parse(values[0]), double.Parse(values[1]), 
                                              double.Parse(values[2]), double.Parse(values[3]));
            }
        }
    }

    [Test]
    public void CalculateArea_ValidSide_ReturnsCorrectArea()
    {
        double side = 3;
        double expected = 54;
        double actual = ShapesAreaCalculator.CalculateCubeArea(side);
        Assert.That(actual, Is.EqualTo(expected));
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

    // Teste Data Driven
    [Test, TestCaseSource(nameof(lerDadosDeTeste), new object[] { "1" })]
    public void testCalculatePyramidSurfaceAreaDDT(double baseLength, double perimeter, double slantHeight, double expectedResult)
    {
        Assert.That(ShapesAreaCalculator.CalculatePyramidSurfaceArea(baseLength, perimeter, slantHeight), Is.EqualTo(expectedResult));
    }
}