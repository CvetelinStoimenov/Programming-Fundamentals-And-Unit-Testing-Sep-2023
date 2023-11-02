using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 50;
        List<int> initialQuality = new List<int>() { 10, 13, 13 };
        List<string> commands = new List<string>();

        // Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 50;
        List<int> initialQuality = new List<int>() { 10, 5, 8 };
        List<string> commands = new List<string>() { "Command", "Hit it again, Gabsy!" };

        // Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 50;
        List<int> initialQuality = new List<int>() { 10, 13, 13 };
        List<string> commands = new List<string>() { "5", "2", "3", "1", "Hit it again, Gabsy!" };
        string expected = "9 2 2\nGabsy has 20.00lv.";

        // Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 0;
        List<int> initialQuality = new List<int>() { 10, 13, 13 };
        List<string> commands = new List<string>() { "5", "2", "3", "1", "Hit it again, Gabsy!" };
        string expected = "2 2\nGabsy has 0.00lv.";

        // Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 50;
        List<int> initialQuality = new List<int>() { 10, 13, 13 };
        List<string> commands = new List<string>() { "5", "2", "3", "1", "2", "7", "Hit it again, Gabsy!" };
        string expected = "\nGabsy has 20.00lv.";

        // Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
