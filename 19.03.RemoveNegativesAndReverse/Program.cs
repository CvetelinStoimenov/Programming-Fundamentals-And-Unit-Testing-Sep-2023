/*
 3.	Remove Negatives and Reverse
Write a program that:
    •	Read a list of integers, 
    •	Remove all negative numbers from it 
    •	Print the remaining elements in reversed order
    •	If there are no elements left in the list, print "empty"

Example Input / Output

Input	                Output
10 -5 7 9 -33 50        50 9 7 10

Input	                Output
7 -2 -10 1              1 7

Input	                Output
-1 -2 -3                empty
*/

List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

integers.RemoveAll(number => number < 0);

integers.Reverse();
if (integers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", integers));
}