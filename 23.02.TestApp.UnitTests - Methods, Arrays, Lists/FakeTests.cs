using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = { 'a', '1', 'c', '4', 'd', '6', 'g' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        char[] assertResult = { 'a', 'c', 'd', 'g' };
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = { 'a', 'c', 'd', 'g' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        char[] assertResult = { 'a', 'c', 'd', 'g' };
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = { };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        char[] assertResult = {  };
        Assert.AreEqual(result, assertResult);
    }
}
