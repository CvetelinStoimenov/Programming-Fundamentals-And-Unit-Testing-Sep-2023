using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElementList = new List<int>() { 5 };

        // Act
        int result = MaxNumber.FindMax(oneElementList);

        // Assert
        Assert.That(result, Is.EqualTo(5));

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveList = new List<int>() { 1, 5, 8, 2, 4, 11, 50 };

        // Act
        int result = MaxNumber.FindMax(positiveList);

        // Assert
        Assert.That(result, Is.EqualTo(50));

    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeNumsList = new List<int>() { -1, -5, -8, -2, -4, -11, -50 };

        // Act
        int result = MaxNumber.FindMax(negativeNumsList);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedNumsList = new List<int>() { -1, 5, -8, -2, 4, -11, -50 };

        // Act
        int result = MaxNumber.FindMax(mixedNumsList);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> DublicateMaxNumList = new List<int>() { 1, 5, 8, 2, 4, 11, 50, 60, 80, 3, 7, 80 };

        // Act
        int result = MaxNumber.FindMax(DublicateMaxNumList);

        // Assert
        Assert.That(result, Is.EqualTo(80));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateNumsValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> DublicateMaxNumList = new List<int>() { 11, 4, 8, 2, 4, 11, 50, 60, 80, 3, 7, 80 };

        // Act
        int result = MaxNumber.FindMax(DublicateMaxNumList);

        // Assert
        Assert.That(result, Is.EqualTo(80));
    }
}
