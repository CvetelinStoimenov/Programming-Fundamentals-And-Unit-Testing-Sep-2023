using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 0;
        double y1 = 0;
        double x2 = 5;
        double y2 = 5;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo("(0, 0)"));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 1;
        double x2 = 0;
        double y2 = 0;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo("(0, 0)"));
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 1;
        double x2 = 1;
        double y2 = 1;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo("(1, 1)"));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = -5;
        double y1 = -5;
        double x2 = 5;
        double y2 = 5;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo("(-5, -5)"));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 5;
        double y1 = 5;
        double x2 = -5;
        double y2 = -5;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo("(-5, -5)"));
    }
}
