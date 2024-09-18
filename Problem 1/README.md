
# Calculate Average Grade

## Description

This program calculates the average grade of students based on user input. It reads the number of students and their grades, then computes and prints the average grade formatted to two decimal places.

## Requirements

-   **Input**:
    
    -   An integer `N` representing the number of students.
    -   `N` floating-point numbers representing the grades of the students.
-   **Output**:
    
    -   A floating-point number representing the average grade of the students, formatted to two decimal places.

## Example

### Example 1

**Input:**

Copy code

```
5
4.34
3.40
4.50
3.30
5.90
``` 

**Output:**

```
4.50
```
### Example 2

**Input:**

```
3
4.30
4.40
5.30
``` 

**Output:**
```
4.67 
```
## Code

```csharp
using System;

class Program
{
    static void Main()
    {
        int countOfTheStudents = int.Parse(Console.ReadLine());
        double averageGrade = 0;

        for (int i = 0; i < countOfTheStudents; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            averageGrade += grade;
        }

        averageGrade /= countOfTheStudents;

        Console.WriteLine($"{averageGrade:f2}");
    }
}
``` 

## Explanation

1.  **Reading Input:**
    
    -   `int countOfTheStudents = int.Parse(Console.ReadLine());`: Reads the number of students from the console.
2.  **Processing Grades:**
    
    -   A `for` loop iterates over the number of students.
    -   `double grade = double.Parse(Console.ReadLine());`: Reads each student's grade.
    -   `averageGrade += grade;`: Adds each grade to the total sum.
3.  **Calculating Average:**
    
    -   `averageGrade /= countOfTheStudents;`: Computes the average by dividing the total sum by the number of students.
4.  **Outputting Result:**
    
    -   `Console.WriteLine($"{averageGrade:f2}");`: Prints the average grade formatted to two decimal places.
