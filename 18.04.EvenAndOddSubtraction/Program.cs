/*
4.Even and Odd Subtraction
Write a program that:
    •	Read an array of integers (from a single line separated with a space)
    •	Calculates the difference between the sum of the even and the sum of the odd numbers in an array
    •	Print the difference

Example Input / Output

Input	            Output	    Comments
1 2 3 4 5 6	        3           Sum even: 2 + 4 + 6 = 12
                                Sum odd: 1 + 3 + 5 = 9
                                Difference: 12 – 9 = 3

3 5 7 9	            -24         Sum even: 0
                                Sum odd: 3 + 5 + 7 + 9 = 24
                                Difference: 0 – 24 = –24

2 4 6 8 10	        30          Sum even: 2 + 4 + 6 + 8 + 10 = 30
                                Sum odd: 0
                                Difference: 30 – 0 = 30*/

int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sumOds = 0;
int sumEven = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        sumEven += nums[i];
    }
    else
    {
        sumOds += nums[i];
    }
}
Console.WriteLine(sumEven - sumOds);