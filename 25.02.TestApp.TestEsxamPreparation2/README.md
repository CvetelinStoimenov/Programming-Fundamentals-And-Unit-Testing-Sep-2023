
# LongestIncreasingSubsequenceTests

## Description

The `LongestIncreasingSubsequenceTests` class contains unit tests for the `LongestIncreasingSubsequence.GetLis` method. This method is designed to find and return the longest increasing subsequence from a given array of integers. The tests cover various scenarios, including null arrays, empty arrays, single-element arrays, unsorted arrays, and sorted arrays.

## Test Cases

### 1. Test_GetLis_NullArray_ThrowsArgumentNullException

**Description:** This test verifies that the `LongestIncreasingSubsequence.GetLis` method throws an `ArgumentNullException` when the input array is `null`.

**Code:**

```csharp
[Test]
public void Test_GetLis_NullArray_ThrowsArgumentNullException()
{
    // Arrange
    int[]? nullArr = null;

    // Act & Assert
    Assert.That(() => LongestIncreasingSubsequence.GetLis(nullArr), Throws.ArgumentNullException);
}
``` 

### 2. Test_GetLis_EmptyArray_ReturnsEmptyString

**Description:** This test ensures that the `LongestIncreasingSubsequence.GetLis` method returns an empty string when the input array is empty.

**Code:**

```csharp
[Test]
public void Test_GetLis_EmptyArray_ReturnsEmptyString()
{
    // Arrange
    int[] input = {  };
    string expected = "";

    // Act
    string result = LongestIncreasingSubsequence.GetLis(input);

    // Assert
    Assert.AreEqual(expected, result);
}
``` 

### 3. Test_GetLis_SingleElementArray_ReturnsElement

**Description:** This test checks that the `LongestIncreasingSubsequence.GetLis` method returns the single element as a string when the input array contains only one element.

**Code:**

```csharp
[Test]
public void Test_GetLis_SingleElementArray_ReturnsElement()
{
    // Arrange
    int[] input = { 9 };
    string expected = "9";

    // Act
    string result = LongestIncreasingSubsequence.GetLis(input);

    // Assert
    Assert.AreEqual(expected, result);
}
``` 

### 4. Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence

**Description:** This test verifies that the `LongestIncreasingSubsequence.GetLis` method correctly finds and returns the longest increasing subsequence from an unsorted array of integers.

**Code:**

```csharp
[Test]
public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
{
    // Arrange
    int[] input = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
    string expected = "10 22 33 50 60 80";

    // Act
    string result = LongestIncreasingSubsequence.GetLis(input);

    // Assert
    Assert.AreEqual(expected, result);
}
``` 

### 5. Test_GetLis_SortedArray_ReturnsItself

**Description:** This test ensures that the `LongestIncreasingSubsequence.GetLis` method returns the input array itself when it is already sorted in increasing order.

**Code:**

```csharp
[Test]
public void Test_GetLis_SortedArray_ReturnsItself()
{
    // Arrange
    int[] input = { 9, 10, 21, 22, 33, 41, 50, 60, 80 };
    string expected = "9 10 21 22 33 41 50 60 80";

    // Act
    string result = LongestIncreasingSubsequence.GetLis(input);

    // Assert
    Assert.AreEqual(expected, result);
}
``` 

## Dependencies

-   NUnit: This testing framework is used for writing and running the unit tests. Ensure NUnit is installed and properly configured in your project
