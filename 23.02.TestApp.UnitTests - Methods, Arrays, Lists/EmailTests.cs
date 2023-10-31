using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.AreEqual(true, isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string validEmail = "test.example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.AreEqual(false, isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string? validEmail = null;

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.AreEqual(false, isValidEmail);
    }
}
