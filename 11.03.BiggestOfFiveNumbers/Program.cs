/*
3.	Biggest of Five Numbers
Write a program to find the biggest among 5 numbers:

•	Reads 5 integer numbers from the console
•	Print the biggest number from the given five

Note: There will not be equal numbers given.

Example Input / Output
Input	Output		Input	Output
1       5           10      50  
2                   20
3                   30
4                   40
5                   50
*/

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
{
    Console.WriteLine(num1);
}
else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
{
    Console.WriteLine(num2);
}
else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
{
    Console.WriteLine(num3);
}
else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
{
    Console.WriteLine(num4);
}
else if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
{
    Console.WriteLine(num5);
}