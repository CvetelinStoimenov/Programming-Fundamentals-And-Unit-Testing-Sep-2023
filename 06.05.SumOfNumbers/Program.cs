/*
 5.	Sum of Numbers
Write a program that reads an integer from the console and on each next line reads integers until their sum becomes 
greater than or equal to the initial number. After finishing, print the sum of the entered numbers.

Example Input/Output

Input	Output	    Input	Output
100     100         20      21
10                  1
20                  2
30                  3
40                  4
                    5
                    6*/

int targetSum  = int.Parse(Console.ReadLine());
int sum = 0;

while (sum < targetSum)
{
   int num = int.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine(sum);