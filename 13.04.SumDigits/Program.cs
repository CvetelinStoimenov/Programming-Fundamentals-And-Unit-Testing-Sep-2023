/*
 4.	Sum Digits
Write a program to sum the digits of given number:
	•	Read an integer positive number from the console
	•	Sum its digits and print the sum

Example: The number is 3451. Digits sum is 3 + 4 + 5 + 1 = 15.

Example Input / Output

Input	Output		Input	Output		Input	Output
5634	18			150		6			532		10
*/

int n = int.Parse(Console.ReadLine());

int sum = 0;

while (n > 0)
{
    int digit = n % 10;
	n = n / 10;
	sum += digit;
}
Console.WriteLine(sum);