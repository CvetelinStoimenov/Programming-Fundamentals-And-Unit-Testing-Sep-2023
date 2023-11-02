using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class PascalTriangleTests
{
    [TestCase(8, "1 \n1 1 \n1 2 1 \n1 3 3 1 \n1 4 6 4 1 \n1 5 10 10 5 1 \n1 6 15 20 15 6 1 \n1 7 21 35 35 21 7 1 \n")]
    [TestCase(0, "")]
    [TestCase(-5, "")]
    [TestCase(1, "1 \n")]
    [TestCase(2, "1 \n1 1 \n")]

    public void Test_PrintTriangle_ShouldReturnCorrectString(int n, string expected)
    {
        // Act
        string result = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
