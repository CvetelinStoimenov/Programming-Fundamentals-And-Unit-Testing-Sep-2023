/*
1.	Sign of Integer Number
Write a program that:
    •	Reads an integer number N from the console
    •	Create a method that prints the sign of an entered number N:
    •	Print:
        o	If the number is positive (N > 0): "The number {number} is positive." 
        o	If the number is negative (N < 0): "The number {number} is negative." 
        o	If the number is zero (N = 0): "The number {number} is zero." 

Example Input / Output

Input	Output
2	    The number 2 is positive.

Input	Output
-5	The number -5 is negative.

Input	Output
0	The number 0 is zero.*/

int n = int.Parse(Console.ReadLine());
SignOfNumber(n);

static void SignOfNumber(int n)
{
    if (n == 0)
    {
        Console.WriteLine($"The number {n} is zero.");
    }
    else if (n < 0) 
    {
        Console.WriteLine($"The number {n} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {n} is positive.")
    }
}