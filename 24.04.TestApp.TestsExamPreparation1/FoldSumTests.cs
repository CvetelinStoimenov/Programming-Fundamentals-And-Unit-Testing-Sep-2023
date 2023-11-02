using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 2, 2, 2, 2 }, "4 4")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[] { 1, 2, 2, 2, 2 }, "3 4")]
    [TestCase(new int[] { 51, 0, 2, 2, 59, 85, 100, 8 }, "2 53 67 185")]
    [TestCase(new int[] { -2, 2, 2, -2 }, "0 0")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
