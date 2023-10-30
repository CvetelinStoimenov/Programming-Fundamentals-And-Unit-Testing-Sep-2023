using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNums = new int[4] { 2, 4, 6, 8 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNums);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddNums = new int[5] { 1, 3, 5, 7, 9 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oddNums);

        // Assert
        Assert.That(result, Is.EqualTo(25));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixedNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        int result = EvenOddSubtraction.FindDifference(mixedNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNegativeNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixNegativeNum = { -1, -2, -3, -4, -5, -6, -7, -8, -9};

        // Act
        int result = EvenOddSubtraction.FindDifference(mixNegativeNum);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyNegativeOoddNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixNegativeNum = { -1, -3, -5, -7, -9 };

        // Act
        int result = EvenOddSubtraction.FindDifference(mixNegativeNum);

        // Assert
        Assert.That(result, Is.EqualTo(25));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyNegativeEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNums = new int [4] { -2, -4, -6, -8 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNums);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasZeroNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNums = new int[5] { -2, -4, -6, -8, 0 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNums);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }
}
