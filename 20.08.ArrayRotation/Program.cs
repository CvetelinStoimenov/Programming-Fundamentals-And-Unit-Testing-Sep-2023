/*
 8.	Array Rotation
Write a program that:
    •	Reads sequence of integer numbers from the first line of the console
    •	Reads an integer number (rotations you have to perform) from the second line of the console
    •	Each rotation is when the first element goes at the end
    •	Print the resulting sequence

Example Input / Output

Input	            Output
51 47 32 61 21      32 61 21 51 47
2

Input	            Output
32 21 61 1          32 21 61 1
4           

Input	            Output
2 4 15 31           4 15 31 2
5*/

List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    input.Add(input[0]);
    input.RemoveAt(0);
}
Console.WriteLine(string.Join(" ", input));