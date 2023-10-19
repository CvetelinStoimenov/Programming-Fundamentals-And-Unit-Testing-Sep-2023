/*
6.	Common Elements
Write a program that:
    •	Read two integer arrays with the same length from the console
    •	Prints common elements in two arrays, space-separated

Examples

Input	        Output
20 30 40 50     30 50
30 10 15 50

7 8 9 10        7
1 2 3 7

1 2 3 4 5       1 2 3 4 5
5 4 3 2 1*/

int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int number in firstArray)
{
    if (secondArray.Contains(number))
    {
        Console.Write(number + " ");
    }
}