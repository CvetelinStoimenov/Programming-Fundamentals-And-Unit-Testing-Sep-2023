/*
3.	Numbers From 1 To N Step 3
Write a Console program, that reads an integer value from the Console:
    •	Assigns the value to a variable - n. 
    •	Prints the correct numbers on the Console. The iterator of the for loop is increased by 3 with each iteration.

Example Input/Output

Input	Output
10      1
        4
        7
        10

15      1
        4
        7
        10
        13*/

int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i += 3)
{
    Console.WriteLine(i);
}