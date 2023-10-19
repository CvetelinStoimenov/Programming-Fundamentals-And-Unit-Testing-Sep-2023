/*
 3.	Reverse an Array
Write a program that:
    •	Read an integer number N from the console
    •	After that read N integer numbers from the console, each on separate line
    •	Store the numbers in the array of integers
    •	Reverse the numbers in the array
    •	Print elements of the array on a single line, space-separated

Example Input / Output

Input	Output		Input	Output
3       30 20 10    4       40 30 20 10
10                  10
20                  20
30                  30
                    40*/

int countOfDigits = int.Parse(Console.ReadLine());
int[] numbers  = new int[countOfDigits];

for (int i = 0; i < countOfDigits; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = countOfDigits -1; i >=0; i--)
{
    Console.Write(numbers[i] + " ");
}