namespace CalculatorApp.Tests;

[TestClass]
public class UnitTestCalculatorMulti
{
    [TestMethod]
    public void TestMultiTwoPositive()
    {
        // Arange
        var calculator = new Calculator();
        int a = 5;
        int b = 5;

        // Act 
        int result = calculator.Multi(a, b);

        // Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestMultiOneNegative()
    {
        // Arange
        var calculator = new Calculator();
        int a = -5;
        int b = 5;

        // Act
        int result = calculator.Multi(a, b);

        // Assert
        Assert.AreEqual(-25, result);
    }
}