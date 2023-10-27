/*
9.	*Max Sequence of Equal Elements
Write a program that:
    •	Reads sequence of integer numbers from the first line of the console
    •	Find the longest sequence of equal elements in a sequence of integers

Note: If several longest sequences exist, print the leftmost one.

Example Input / Output

Input	                Output
2 1 1 2 3 3 2 2 2 1     2 2 2

Input	                Output
1 1 1 2 3 1 3 3         1 1 1

Input	                Output
4 4 4 4                 4 4 4 4 

Input	                Output
0 1 1 5 2 2 6 3 3       1 1*/

//With array:
//int[] input = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToArray();

//int longestSequence = 1;
//int currentSequence = 1;
//int mostFrequentNumber = input[0];

//for (int i = 1; i < input.Length; i++)
//{
//    if (input[i] == input[i - 1])
//    {
//        currentSequence++;
//        if (currentSequence > longestSequence)
//        {
//            longestSequence = currentSequence;
//            mostFrequentNumber = input[i];
//        }
//    }
//    else
//    {
//        currentSequence = 1;
//    }
//}

//int[] result = new int[longestSequence];
//for (int i = 0; i < longestSequence; i++)
//{
//    result[i] = mostFrequentNumber;
//}

//Console.WriteLine(string.Join(" ", result));

//With a list:
List<int> input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> longestSequence = new List<int>();
List<int> currentSequence = new List<int> { input[0] };

for (int i = 1; i < input.Count; i++)
{
    if (input[i] == input[i - 1])
    {
        currentSequence.Add(input[i]);
    }
    else
    {
        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence = new List<int>(currentSequence);
        }
        currentSequence = new List<int> { input[i] };
    }
}

if (currentSequence.Count > longestSequence.Count)
{
    longestSequence = new List<int>(currentSequence);
}

Console.WriteLine(string.Join(" ", longestSequence));