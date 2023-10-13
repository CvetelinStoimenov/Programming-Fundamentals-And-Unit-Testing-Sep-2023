/*5.Number Pyramid
Write a program that:
•	Reads an integer number n from the console 
•	Prints a pyramid of numbers as shown in the examples
Example Input / Output
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
        11 12 13 14 15
*/


int numOfTriangle = int.Parse(Console.ReadLine());
int count = 1;

for (int col = 1; col <= numOfTriangle; col++)
{
    for (int row = 0; row < col; row++)
    {
        if (count > numOfTriangle)
        {
            break;
        }
        Console.Write($"{count} ");
        count++;
    }
    if (count > numOfTriangle)
    {
        break;
    }
    Console.WriteLine();
}