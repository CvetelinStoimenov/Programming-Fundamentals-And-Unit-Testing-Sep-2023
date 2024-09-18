
# Rotations

## Description

This program performs rotations on an array of integers. Each rotation involves moving the last element of the array to the front. The program reads the array and the number of rotations from the console and prints the resulting array after the specified number of rotations.

## Requirements

-   **Input**:
    
    -   A line with integers separated by a single space, representing the array.
    -   A single integer `N` representing the number of rotations.
-   **Output**:
    
    -   A single line with the rotated array elements separated by a comma and a single space (", ").

## Example

### Example 1

**Input:**



```
1 2 3 4 5 6
3
``` 

**Output:**



```
4, 5, 6, 1, 2, 3
``` 

### Example 2

**Input:**

```
10 12 43 56 87
2
``` 

**Output:**

```

56, 87, 10, 12, 43 
```
## Code


```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            input.Insert(0, input[input.Count - 1]);
            input.RemoveAt(input.Count - 1);
        }
        
        Console.WriteLine(string.Join(", ", input));
    }
}
``` 

## Explanation

1.  **Reading Input:**
    
    -   `List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();`: Reads the array of integers from the console and converts it into a list.
    -   `int rotations = int.Parse(Console.ReadLine());`: Reads the number of rotations from the console.
2.  **Performing Rotations:**
    
    -   A `for` loop iterates over the number of rotations.
    -   `input.Insert(0, input[input.Count - 1]);`: Moves the last element of the list to the front.
    -   `input.RemoveAt(input.Count - 1);`: Removes the last element from the list.
3.  **Outputting Result:**
    
    -   `Console.WriteLine(string.Join(", ", input));`: Prints the resulting list with elements separated by a comma and a single space.
