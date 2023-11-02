using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] inputArray = { 1, 2, 1, 3, 4, 10, 12, 15 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        int[] assertArray = { 1, 15, 2, 12, 3, 10, 4 };
        Assert.AreEqual(result, assertArray);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = { };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        int[] assertArray = { };
        Assert.AreEqual(result, assertArray);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] inputArray = { 1 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        int[] assertArray = { 1 };
        Assert.AreEqual(result, assertArray);
    }
}
