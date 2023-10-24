/*
 2.	 Element That Equals to the Sum of Others
Write a program that reads n integer numbers entered by the user, and checks whether there is a number among them that is equal 
to the sum of all the others.
    •	If such an element exists, print "Yes" and on a new line "Sum = " + its value
    •	If there is no such element, print "No" and on a new line "Diff = " + the difference between the largest element 
        and the sum of the others (absolute value).

Example Input and Output

Input	Output	        Comments
7       Yes             The first line of the input
3       Sum = 12        (7) indicates the count of 
4                       numbers that will follow.
1                       3 + 4 + 1 + 2 + 1 + 1 = 12
1
2
12
1*/

int n = int.Parse(Console.ReadLine());
int sum = 0;
int maxNum = int.MinValue;
int addNum = 0;

for (int i = 0; i < n; i++)
{
    addNum = int.Parse(Console.ReadLine());
    sum += addNum;
    if (addNum > maxNum)
    {
        maxNum = addNum;
    }
}

sum = sum - maxNum;
if (sum == maxNum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int diff = Math.Abs(maxNum - sum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}