/*
 Write a program that reads a whole number n entered by the user and prints a pyramid of numbers as shown in the examples:

Input	Output
7	    1
        2 3
        4 5 6
        7

Input	Output
10	    1
        2 3
        4 5 6
        7 8 9 10

Input	Output
12	    1
        2 3
        4 5 6
        7 8 9 10
        11 12

Input	Output
15	    1
        2 3
        4 5 6
        7 8 9 10
        11 12 13 14 15*/

int pyramidCount = int.Parse(Console.ReadLine());

int current = 1;
bool isBiger = false;

for (int rows = 1; rows <= pyramidCount; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        if (current > pyramidCount)
        { 
            isBiger = true;
            break;
        }
        Console.Write(current + " ");
        current++;
    }
    if (isBiger)
    {
        break;
    }
    Console.WriteLine();
}
