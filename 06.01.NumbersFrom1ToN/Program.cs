/*
 1.	Numbers From 1 To N
Write a Console program, that reads an integer value from the Console:
    •	Assigns the value to a variable - n.
    •	Prints the numbers from 1 to n on the console, each on a new line.

Example Input/Output

Input	Output
2       1
        2

4       1
        2
        3
        4*/

int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(i);
}