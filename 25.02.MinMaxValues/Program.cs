/*
2.	Min / Max Values
Write a program that:
    •	Reads an array of integer numbers from the first line of the console, separated by single space
    •	Read an integer number N from the second line of the console
    •	Find max number in the first N elements in the given array
    •	Find min number in the first N elements in the given array
    •	Print max number and min number, each on separate line

Example Input / Output

Input	                Output	Comments
3 42 61 7 8 9 10 23     61      First 4 numbers in the array are: 3 42 61 7
4                       3       Max number is: 61
                                Min number is: 3



Input	                Output	Comments
12 34 98 42 65 12       98      First 3 numbers in the array are: 12 34 98
3                       12      Max number is: 98
                                Min number is: 12*/

List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int cutList = int.Parse(Console.ReadLine());

List<int> firstNElements = input.Take(cutList).ToList();

int maxNumber = firstNElements.Max(); // Find the maximum number
int minNumber = firstNElements.Min(); // Find the minimum number

Console.WriteLine(maxNumber);
Console.WriteLine(minNumber);
