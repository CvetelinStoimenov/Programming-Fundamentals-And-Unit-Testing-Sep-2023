using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;

        // Act
        int factorial = Factorial.CalculateFactorial(input);

        // Assert
        Assert.That(factorial, Is.EqualTo(1));
        
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 8;

        // Act
        int factorial = Factorial.CalculateFactorial(input);

        // Assert
        Assert.That(factorial, Is.EqualTo(40320));
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int input = -5;

        // Act + Assert

        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
