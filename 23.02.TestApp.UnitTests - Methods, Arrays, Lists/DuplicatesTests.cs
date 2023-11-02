using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Array.Empty<int>();

        // Assert
        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 3, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 2, 3, 3, 3, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        int[] assertResult = new[] { 1, 2, 3, 5 };
        Assert.That(result, Is.EqualTo(assertResult));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new[] { 2, 2, 2, 2 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        int[] assertResult = new[] { 2 };
        Assert.That(result, Is.EqualTo(assertResult));
    }
}
