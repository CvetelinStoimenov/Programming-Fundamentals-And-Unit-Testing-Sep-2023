# BalancedBrackets

## Description

This program checks if a sequence of brackets is balanced. The `BalancedBrackets` class contains a static method `IsBalanced` that determines whether the brackets in a given array are balanced. The method considers the following rules:

-   For every opening bracket `(`, there must be a corresponding closing bracket `)`.
-   The sequence of brackets must be correctly nested.

## Requirements

-   **Input**:
    
    -   An array of strings where each string is either an opening bracket `(` or a closing bracket `)`.
-   **Output**:
    
    -   A boolean value indicating whether the sequence of brackets is balanced.

## Example

### Example 1

**Input:**

```csharp
BalancedBrackets.IsBalanced(new string[] { "(", ")", "(", ")" });
``` 

**Output:**

```arduino
true
``` 

### Example 2

**Input:**

```csharp
BalancedBrackets.IsBalanced(new string[] { "(", "(", ")", ")" });
``` 

**Output:**

```arduino
true
``` 

### Example 3

**Input:**

```csharp
BalancedBrackets.IsBalanced(new string[] { "(", ")" });
``` 

**Output:**

```arduino
true
``` 

### Example 4

**Input:**

```csharp
BalancedBrackets.IsBalanced(new string[] { "(", ")" });
``` 

**Output:**

```arduino
true
``` 

### Example 5

**Input:**

```csharp
BalancedBrackets.IsBalanced(new string[] { "(", ")" });
``` 

**Output:**

```arduino
true
``` 

## Code

```csharp
using System;

class Program
{
    static void Main()
    {
        bool result = BalancedBrackets.IsBalanced(new string[] { });
        Console.WriteLine(result);
    }
}

class BalancedBrackets
{
    public static bool IsBalanced(string[] input)
    {
        int balance = 0;

        foreach (string symbol in input)
        {
            if (symbol == "(")
            {
                balance++;
            }
            else if (symbol == ")")
            {
                balance--;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        return balance == 0;
    }
}
``` 

## Explanation

1.  **Balance Calculation:**
    
    -   `int balance = 0;`: Initializes the balance counter.
    -   For each `symbol` in the input array:
        -   If the `symbol` is `(`, increment the `balance`.
        -   If the `symbol` is `)`, decrement the `balance`.
        -   If `balance` becomes negative, return `false` as this indicates an excess of closing brackets.
2.  **Final Check:**
    
    -   Return `true` if the `balance` is zero after processing all symbols, indicating that every opening bracket has a matching closing bracket and the sequence is balanced.

## Unit Tests

### Test Cases

```csharp
[Test]
public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
{
    // Arrange
    string[] input = { };
    bool expected = true;

    // Act
    bool result = BalancedBrackets.IsBalanced(input);

    // Assert
    Assert.AreEqual(expected, result);
}

[Test]
public void IsBalanced_WithOpeningAndClosingBrackets_ReturnsTrue()
{
    // Arrange
    string[] input = { "(", ")" };
    bool expected = true;

    // Act
    bool result = BalancedBrackets.IsBalanced(input);

    // Assert
    Assert.AreEqual(expected, result);
}
``` 

-   **Test_IsBalanced_EmptyInput_ShouldReturnTrue**: Verifies that an empty input array returns `true`, as no brackets are unbalanced.
-   **IsBalanced_WithOpeningAndClosingBrackets_ReturnsTrue**: Verifies that a balanced sequence with one pair of brackets returns `true`.
