/*
1.	Numbers in Range
Write a program that prints numbers in a given range:
    •	Reads two integer numbers from the console
    •	First integer number represents the start of the range
    •	Second integer number represents the end of the range
    •	Print the numbers in the given range (include start and end number), each on the new line

Note: The first given integer will always be bigger than the second given integer.

Example Input / Output

Input	Output		Input	Output		Input	Output
5	    5		    1       1           10      10
10      6           8       2           15      11
        7                   3                   12
        8                   4                   13
        9                   5                   14
        10                  6                   15
                            7
                            8
 
 */

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
    Console.WriteLine(i);
}