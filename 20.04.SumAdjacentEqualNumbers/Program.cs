/*
 4.	*Sum Adjacent Equal Numbers
 Write a program that:
    •	Reads a sequence of integer numbers from the console
    •	Sum all adjacent equal numbers in a list of decimal numbers, starting from left to right
        o	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well
        o	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)

Example Input / Output

Input	        Output	            Explanation
3 3 6 1         12  1               3 3 6 1 -> 6 6 1 -> 12 1

Input	        Output	            Explanation
8 2 2 4 8 16    16 8 16             8 2 2 4 8 16 -> 8 4 4 8 16 -> 8 8 8 16 -> 16 8 16

Input	        Output	            Explanation
5 4 2 1 1 4     5 8 4               5 4 2 1 1 4 -> 5 4 2 2 4 -> 5 4 4 4 -> 5 8 4*/

List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    for (int i = 0; i < input.Count - 1; i++)
    {

        if (input[i] == input[i + 1])
        {
            input[i] = input[i] + input[i + 1];
            input.RemoveAt(i + 1);
            i =- 1;
        }
    }

Console.WriteLine(string.Join(" ", input));