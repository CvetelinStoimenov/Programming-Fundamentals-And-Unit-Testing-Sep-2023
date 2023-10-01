/*6.Product of Three Numbers
Write a program that calculates the sign of the product of three numbers:

•	Reads 3 real numbers from the console
•	Print the sign of the product of the three given numbers: "positive", "negative" or "zero"

Note: Try to do this without multiplying the numbers.

Example Input / Output
Input	Output		Input	Output		Input	Output
2		negative	-3		positive	0		zero
3					-4					4		
-1					5					5
*/

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 == 0 || num2 == 0 || num3 == 0)
{
    Console.WriteLine("zero");
}
else if ((num1 > 0 && num2 > 0 && num3 > 0)
      || (num1 > 0 && num2 < 0 && num3 < 0)
      || (num1 < 0 && num2 > 0 && num3 < 0)
      || (num1 < 0 && num2 < 0 && num3 > 0))
{
    Console.WriteLine("positive");
}
else if ((num1 < 0 && num2 < 0 && num3 < 0)
      || (num1 < 0 && num2 > 0 && num3 > 0)
      || (num1 > 0 && num2 < 0 && num3 > 0)
      || (num1 > 0 && num2 > 0 && num3 < 0))
{
    Console.WriteLine("negative");
}
