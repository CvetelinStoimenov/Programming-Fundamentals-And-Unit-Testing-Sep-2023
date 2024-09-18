# CharacterRange

## Description

This program demonstrates how to generate a range of characters between two given characters. The program defines a `CharacterRange` class with a static method `GetRange` that returns a string containing all characters between two specified characters, excluding the boundary characters.

## Requirements

-   **Input**:
    
    -   Two characters, `a` and `b`, specifying the range.
-   **Output**:
    
    -   A single string containing the characters between `a` and `b`, separated by spaces.

## Example

**Input:**

```csharp
CharacterRange.GetRange('a', 'd');
``` 

**Output:**

```css
b c
``` 

## Code

```csharp
using System;

class Program
{
    static void Main()
    {
        string result = CharacterRange.GetRange('a', 'b');
        Console.WriteLine(result);
    }
}

class CharacterRange
{
    public static string GetRange(char a, char b)
    {
        int chOne = Math.Min(a, b);
        int chTwo = Math.Max(a, b);

        string result = string.Empty;
        for (int i = chOne + 1; i < chTwo; i++)
        {
            result += $"{(char)i} ";
        }

        return result.Trim();
    }
}
``` 

## Explanation

1.  **Getting the Range:**
    
    -   `int chOne = Math.Min(a, b);`: Determines the smaller of the two characters.
    -   `int chTwo = Math.Max(a, b);`: Determines the larger of the two characters.
2.  **Generating the Characters:**
    
    -   A `for` loop iterates from the character after `chOne` to one character before `chTwo`.
    -   `result += $"{(char)i} ";`: Adds each character to the result string with a trailing space.
3.  **Outputting Result:**
    
    -   `result.Trim()`: Removes any trailing space from the result string.
    -   The `GetRange` method returns the formatted string of characters.
4.  **Program Execution:**
    
    -   The `Main` method calls `GetRange` with the characters 'a' and 'b', and prints the result.
