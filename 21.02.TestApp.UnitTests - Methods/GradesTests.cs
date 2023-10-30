using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.0, "Fail")]
    [TestCase(3.0, "Average")]
    [TestCase(3.5, "Good")]
    [TestCase(4.0, "Very Good")]
    [TestCase(4.5, "Excellent")]
    [TestCase(6.0, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert

        Assert.AreEqual(expected, actual);
    }

    [TestCase(1.99, "Invalid!")]
    [TestCase(2.0, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.0, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.5, "Good")]
    [TestCase(3.99, "Good")]
    [TestCase(4.0, "Very Good")]
    [TestCase(4.49, "Very Good")]
    [TestCase(4.5, "Excellent")]
    [TestCase(5.0, "Excellent")]
    [TestCase(6.0, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
