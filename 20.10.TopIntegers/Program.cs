/*
10.	*Top Integers
Write a program that:
    •	Reads sequence of integer numbers from the first line of the console
    •	Find all the top integers in a sequence
    •	Top integer is an integer that is bigger than all the elements to its right

Example Input / Output

Input	                Output
1 4 3 2                 4 3 2

Input	                Output
14 24 3 19 15 17        24 19 17

Input	                Output
27 9 42 2 13 45 48      48*/

List<int> input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();


List<int> output = new List<int>();
int maxNum = int.MinValue;

for (int j = input.Count - 1; j >= 0; j--)
{
        int compNum = input[j];

        if (compNum > maxNum)
        {
            maxNum = compNum;
            output.Add(maxNum);
        }
}

output.Reverse();

Console.WriteLine(string.Join(" ", output));


for (int i = 0; i < input.Count; i++)
{
    bool isTopInteger = true;

    for (int j = i + 1; j < input.Count; j++)
    {
        if (input[i] <= input[j])
        {
            isTopInteger = false;
            break;
        }
    }

    if (isTopInteger)
    {
        Console.Write(input[i] + " ");
    }
}