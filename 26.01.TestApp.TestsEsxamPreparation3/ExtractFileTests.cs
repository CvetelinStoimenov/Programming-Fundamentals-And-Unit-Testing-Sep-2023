using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = "";

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string input = "C:\\Downloads\\file\\file.exe";
        string expected = "File name: file\nFile extension: exe";

        // Act
        string result = ExtractFile.GetFile(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string input = "C:\\Downloads\\file\\file";
        string expected = "File name: file";

        // Act
        string result = ExtractFile.GetFile(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string input = "C:\\Downloads!@\\file\\file.exe";
        string expected = "File name: file\nFile extension: exe";

        // Act
        string result = ExtractFile.GetFile(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
