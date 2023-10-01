/*8.Invalid Number
A given number is valid if it is in the range [100...200] or it is equals to 0. 
Write a program that:

•	Reads an integer from the console
•	 Prints "invalid" if the entered number is NOT valid

Example Input / Output

Input	Output		Input	Output			Input	Output
75	    invalid		150     (няма изход)	0       (няма изход)
*/
int num = int.Parse(Console.ReadLine());

if (num == 0 || (num >= 100 && num <= 200))
{
    
}
else
{
    Console.WriteLine("invalid");
}