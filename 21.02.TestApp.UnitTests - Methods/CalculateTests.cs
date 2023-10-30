using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition_WhenParametersArePositive()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Addition_WhenParametersAreNegative()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(-5, -2);

        // Assert
        Assert.AreEqual(-7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Addition_WhenParametersAreNegativeAndPositive()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(-5, 2);

        // Assert
        Assert.AreEqual(-3, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Addition_WhenOneParameterIsZero()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(0, 2);

        // Assert
        Assert.AreEqual(2, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_SAddition_WhenParametersAreZeros()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(0, 0);

        // Assert
        Assert.AreEqual(0, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction_WhenParametersArePositive()
    {
        {
            // Arrange
            Calculate calculator = new();

            // Act
            int actual = calculator.Subtraction(8, 3);

            // Assert
            Assert.AreEqual(5, actual, "Addition did not work properly.");
        }
    }

    [Test]
    public void Test_Subtraction_WhenParametersAreNegative()
    {
        {
            // Arrange
            Calculate calculator = new();

            // Act
            int actual = calculator.Subtraction(-8, -3);

            // Assert
            Assert.AreEqual(-5, actual, "Addition did not work properly.");
        }
    }

    [Test]
    public void Test_Subtraction_WhenParametersAreNegativeAndPositive()
    {
        {
            // Arrange
            Calculate calculator = new();

            // Act
            int actual = calculator.Subtraction(8, -3);

            // Assert
            Assert.AreEqual(11, actual, "Addition did not work properly.");
        }
    }

    [Test]
    public void Test_Subtraction_WhenOneParameterIsZero()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(0, 2);

        // Assert
        Assert.AreEqual(2, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction_WhenParametersAreZeros()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(0, 0);

        // Assert
        Assert.AreEqual(0, actual, "Addition did not work properly.");
    }
}
