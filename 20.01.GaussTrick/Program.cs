/*
 1.	Gauss' Trick
Write a program that:
    •	Reads a sequence with integer numbers from the console
    •	Sums all numbers in a list in the following order:
first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last – n

Example Input / Output

Input	        Output		Input	    Output
1 2 3 4 5	    6 6 3		1 2 3 4	    5 5*/

List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> output = new List<int>();

for (int i = 0; i < input.Count / 2; i++)
{
    int sum = input[0 + i] + input[input.Count - 1 - i];
    output.Add(sum);
}

if (input.Count % 2 != 0)
{ 
    int num = input[input.Count / 2];
    output.Add(num);
}

Console.WriteLine(string.Join(" ", output));