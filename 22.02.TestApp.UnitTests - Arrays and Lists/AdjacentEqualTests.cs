using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noAdjacentEqualNum = new List<int>() { 1, 2, 3, 4, 5};

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noAdjacentEqualNum = new List<int>() { 5, 1, 1, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("5 2 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> noAdjacentEqualNum = new List<int>() { 1, 1, 2, 4, 8, 16 };

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("32"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noAdjacentEqualNum = new List<int>() { 1, 1, 5, 4, 8, 16 };

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("2 5 4 8 16"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noAdjacentEqualNum = new List<int>() { 5, 1, 5, 4, 8, 16, 16 };

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("5 1 5 4 8 32"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noAdjacentEqualNum = new List<int>() { 5, 1, 5, 5, 8, 16, };

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("5 1 10 8 16"));
    }
}
