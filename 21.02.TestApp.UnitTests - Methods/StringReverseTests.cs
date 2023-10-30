using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{

    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo(input));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "abcd";

        //Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo("dcba"));
    }
}
