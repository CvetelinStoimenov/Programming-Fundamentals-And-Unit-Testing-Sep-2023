using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? nullArr = null;

        // Act & Assert
        Assert.That(() => LongestIncreasingSubsequence.GetLis(nullArr), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] input = {  };
        string expected = "";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] input = { 9 };
        string expected = "9";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] input = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
        string expected = "10 22 33 50 60 80";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] input = { 9, 10, 21, 22, 33, 41, 50, 60, 80 };
        string expected = "9 10 21 22 33 41 50 60 80";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
