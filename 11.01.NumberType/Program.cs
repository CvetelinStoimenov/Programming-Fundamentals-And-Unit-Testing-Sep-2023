/*
1.	Number Type
Write a program that:

•	Reads an integer number from the console
•	Based on the given number:
    o	Print "negative", if the number is lower than zero
    o	Print "positive ", if the number is bigger than zero
    o	Print "zero ", if the number is equals to zero

Example Input / Output

Input	Output		    Input	Output		    Input	Output
2	    positive		-1      negative		0	    zero
*/
int num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("zero");
}
else if (num < 0)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("positive");
}