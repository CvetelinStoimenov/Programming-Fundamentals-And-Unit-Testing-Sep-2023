/*
1.	Decreasing Numbers
Write a program that:
    •	Reads an integer number N
    •	Print the numbers from N down to 1 (inclusively), each on separate line

Note: N will always be bigger than 1.

Example Input / Output

Input	Output
5   	5
        4
        3
        2
        1		

Input	Output
4 	    4
        3
        2
        1

Input	Output
7	    7
        6
        5
        4
        3
        2
        1
*/

int n = int.Parse(Console.ReadLine());

while (n >= 1)
{
    Console.WriteLine(n);
    n--;
}