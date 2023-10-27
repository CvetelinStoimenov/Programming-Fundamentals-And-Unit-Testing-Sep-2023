/*
 2.	Condense Array to Number
Write a program that:
	•	Read a sequence of integer numbers from the console
	•	Condense them by summing adjacent couples of elements until a single integer is obtained

Example: If we have 3 elements {2, 10, 3}. We sum the first two and the second two elements and obtain 
	           {2+10, 10+3} = {12, 13}. Then we sum again all adjacent elements and obtain {12+13} = {25}.

Example Input / Output

Input		Output			Comments
2 10 3		25				2 10 3 -> 2+10 10+3 -> 12 13 -> 12 + 13 -> 25

Input		Output			Comments
5 0 4 1 2	35				5 0 4 1 2 -> 5+0 0+4 4+1 1+2 -> 5 4 5 3 -> 5+4 4+5 5+3 -> 9 9 8 -> 9+9 9+8 -> 18 17 -> 18+17 -> 35

Input		Output			Comments
1			1				1 is already condensed to number*/


List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


while (input.Count > 1)
{
    List<int> output = new List<int>();
    for (int i = 0; i < input.Count - 1; i++)
    {
        int sum = input[i] + input[i + 1];
        output.Add(sum);
    }
    input = output;

}
Console.WriteLine(string.Join(" ", input));
