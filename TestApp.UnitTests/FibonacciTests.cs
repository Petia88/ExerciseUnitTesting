using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int n = 0;

        // Act  
        int output = Fibonacci.CalculateFibonacci(n);

        //Assert
        Assert.That(output, Is.Zero);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int n = 7;

        // Act  
        int output = Fibonacci.CalculateFibonacci(n);

        //Assert
        Assert.That(output, Is.EqualTo(13));
    }
}