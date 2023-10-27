/*
3.	Merging Lists
Write a program that:
    •	Reads two sequences with integer numbers from the console
    •	Create a result list that contains the numbers from both of the sequences
    •	The first element should be from the first sequence, the second from the second sequence, and so on
    •	If the length of the two sequences is not equal, just add the remaining elements at the end of the sequence

Example Input / Output

Input	                    Output
3 5 2 43 12 3 54 10 23      3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
76 5 34 2 4 12	

Input	                    Output
76 5 34 2 4 12
3 5 2 43 12 3 54 10 23	    76 3 5 5 34 2 2 43 4 12 12 3 54 10 23*/

List<int> input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> output = new List<int>();

//find longer list
int longerCount = Math.Max(input1.Count, input2.Count);

for (int i = 0; i < longerCount; i ++)
{
    if (i < input1.Count)
    {
        output.Add(input1[i]);
    }

    if (i < input2.Count)
    {
        output.Add(input2[i]);
    }
}


Console.WriteLine(string.Join(' ', output));