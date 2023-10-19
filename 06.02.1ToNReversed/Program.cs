/*
 Write a Console program, that reads an integer value from the Console:
    •	Assigns the value to a variable - n. 
    •	Prints the numbers from n to 1 on the Console, in reversed order.

Example Input/Output

Input	Output
2       2
        1

4       4
        3
        2
        1*/
int num = int.Parse(Console.ReadLine());

for (int i = num; i > 0; i--)
{
    Console.WriteLine(i);
}