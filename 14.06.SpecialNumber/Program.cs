/*
6.	Special Number
Write a program to check if given number is special: 
    •	Special numbers are divisible by all of their digits without remainder
    •	Reads an integer number and check whether it is a special number
    •	If the number IS special print: "{num} is special"
    •	If the number is NOT special print: "{num} is not special"

Note: There will not be numbers with digit 0 in them.

Example Input / Output

Input	Output		            Input	Output
23      23 is not special       212     212 is special*/

int n = int.Parse(Console.ReadLine());
int n1 = n;

while (n1 > 0)
{
    double digit = n1 % 10;
    n1 = n1 / 10;
    if (n % digit != 0)
    {
        Console.WriteLine($"{n} is not special");
        break;
    }
    if (n1 == 0)
    {
        Console.WriteLine($"{n} is special");
        break;
    }

}
