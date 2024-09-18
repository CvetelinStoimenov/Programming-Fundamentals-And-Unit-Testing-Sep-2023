
# DrumSetTests

## Description

The `DrumSetTests` class contains unit tests for the `DrumSet` class, which presumably simulates a drum set where the quality of drums is affected by commands and monetary balance. The tests ensure that the `DrumSet.Drum` method handles different scenarios correctly, including invalid input, balance handling, and output formatting.

## Test Cases

### 1. Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException

**Description:** This test verifies that the `DrumSet.Drum` method throws an `ArgumentException` when the commands list is empty, indicating that the termination command is missing.

**Code:**

```csharp
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
``` 

### 2. Test_Drum_StringGivenAsCommand_ThrowsArgumentException

**Description:** This test ensures that the `DrumSet.Drum` method throws an `ArgumentException` if any command in the list is not a valid integer or termination command.

**Code:**

```csharp
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
``` 

### 3. Test_Drum_ReturnsCorrectQualityAndAmount

**Description:** This test checks that the `DrumSet.Drum` method correctly updates the quality of the drums and the remaining balance after processing a sequence of valid commands.

**Code:**

```csharp
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
``` 

### 4. Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount

**Description:** This test verifies that when the balance is zero and only one drum is left, the `DrumSet.Drum` method provides the correct output with the remaining drum quality and balance.

**Code:**

```csharp
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
``` 

### 5. Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount

**Description:** This test checks that if the balance is insufficient to process all commands, the `DrumSet.Drum` method correctly removes all drums and returns the remaining balance.

**Code:**

```csharp
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
``` 

## Dependencies

-   NUnit: This testing framework is used for writing and running the unit tests. Make sure to have NUnit installed and properly configured in your project.
