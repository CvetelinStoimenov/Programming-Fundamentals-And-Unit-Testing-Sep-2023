using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
    }


    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = new int[1] { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] positiveArray = new int[4] { 4, 2, 6, 8 };

        // Act
        double result = Average.CalculateAverage(positiveArray);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] negativeArray = new int[3] { -4, -8, -2 };

        // Act
        double result = Average.CalculateAverage(negativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(-4.666666666666667));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] mixedArray = new int[4] { -4, 2, 6, -8 };

        // Act
        double result = Average.CalculateAverage(mixedArray);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}
