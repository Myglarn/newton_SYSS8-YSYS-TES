using CalculatorApp;

[TestClass]
public class UnitTestCalculatorDiv
{
    [TestMethod]
    public void TestDivTwoPositive()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 10;
        int b = 2;

        // Act
        int result = calculator.Div(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void TestDivOneNegativeNumber()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 10;
        int b = -2;

        // Act
        int result = calculator.Div(a, b);

        // Assert
        Assert.AreEqual(-5, result);
    }
}