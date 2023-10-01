/*
2.	ATM
Write a program to simulate an ATM withdrawal:

•	Reads 3 integer numbers which represents the following values: balance, withdraw and limit
•	Based on the given input parameters:
o	Print "The withdraw was successful.", if the balance is enough
o	Print "The limit was exceeded.", if the limit is exceeded
o	Print "Insufficient availability.", if the balance isn't enough

Example Input / Output

Input	Output		                                Input	Output
420	    The withdraw was successful.                10      The limit was exceeded.
20                                                  50
25                                                  20

Input	Output		                                Input	Output
10      Insufficient availability.		            560     The withdraw was successful.
20                                                  10
30                                                  35
*/

int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (balance >= withdraw && withdraw <= limit)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (withdraw >= limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else
{
    Console.WriteLine("Insufficient availability.");
}
