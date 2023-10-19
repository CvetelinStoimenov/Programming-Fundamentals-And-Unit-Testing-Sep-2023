/*
2.	Sum an Array
Write a program that:
    •	Read an array of integers (from a single line separated with a space)
    •	Print the sum of all elements in the given array

Example Input / Output

Input		Output		Input		Output		Input   	Output
5 3 6 3 4	21			20 30 -5	45	    	25 45 -3	67*/

int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0;

for (int i = 0; i < nums.Length; i++)
{ 
    sum += nums[i];
}
Console.WriteLine(sum);