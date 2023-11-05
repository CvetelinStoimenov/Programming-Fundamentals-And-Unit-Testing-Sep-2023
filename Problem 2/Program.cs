/*
Rotations
Write a program that:
    •	Reads an array with integer numbers (separated with single space) from the first line of the console
    •	Reads an integer number N (count of rotations) from the second line of the console
    •	During each rotation the last element goes at the start of the array (last number becomes first)
    •	Print the resulting sequence separated by comma and a single space (", ")

Example Input / Output

Input	            Output
1 2 3 4 5 6         4, 5, 6, 1, 2, 3
3
10 12 43 56 87      56, 87, 10, 12, 43
2*/

List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    input.Insert(0, input[input.Count - 1]);
    input.RemoveAt(input.Count - 1);
}
Console.WriteLine(string.Join(", ", input));