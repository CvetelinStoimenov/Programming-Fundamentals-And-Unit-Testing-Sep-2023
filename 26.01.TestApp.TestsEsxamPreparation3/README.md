
# ExtractFileTests

## Description

The `ExtractFileTests` class contains unit tests for the `ExtractFile.GetFile` method. This method is designed to extract the file name and extension from a given file path. The tests cover various scenarios to ensure the method handles different types of input correctly, including null paths, empty paths, valid paths, paths without extensions, and paths with special characters.

## Test Cases

### 1. Test_GetFile_NullPath_ThrowsArgumentNullException

**Description:** This test verifies that the `ExtractFile.GetFile` method throws an `ArgumentNullException` when the input path is `null`.

**Code:**

```csharp
[Test]
public void Test_GetFile_NullPath_ThrowsArgumentNullException()
{
    // Arrange
    string path = null;

    // Act & Assert
    Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
}
``` 

### 2. Test_GetFile_EmptyPath_ThrowsArgumentNullException

**Description:** This test ensures that the `ExtractFile.GetFile` method throws an `ArgumentNullException` when the input path is an empty string.

**Code:**

```csharp
[Test]
public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
{
    // Arrange
    string path = "";

    // Act & Assert
    Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
}
``` 

### 3. Test_GetFile_ValidPath_ReturnsFileNameAndExtension

**Description:** This test checks that the `ExtractFile.GetFile` method correctly extracts and returns the file name and extension from a valid file path.

**Code:**

```csharp
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
``` 

### 4. Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly

**Description:** This test verifies that the `ExtractFile.GetFile` method returns only the file name when the path does not include a file extension.

**Code:**

```csharp
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
``` 

### 5. Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension

**Description:** This test ensures that the `ExtractFile.GetFile` method correctly handles file paths containing special characters and returns the appropriate file name and extension.

**Code:**

```csharp
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
``` 

## Dependencies

-   NUnit: This testing framework is used for writing and running the unit tests. Ensure NUnit is installed and properly configured in your project.
