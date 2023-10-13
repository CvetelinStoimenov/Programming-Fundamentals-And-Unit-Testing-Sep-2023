/*
 Triangle of Stars
Write a program to print a triangle of stars like shown in the examples:
    •	Read the size (integer number) of a triangle from the console
    •	Print a triangle of stars

Example Input / Output

Input	Output
5	    *
        **
        ***
        ****
        *****		

Input	Output
7   	*
        **
        ***
        ****
        *****
        ******
        *******
*/

int numOfTriangle = int.Parse(Console.ReadLine());

for (int col = 1; col <= numOfTriangle; col++)
{
     for (int row = 1; row <= col; row++)
    { 
        Console.Write("*"); 
    }
    Console.WriteLine();
}

Console.WriteLine();

//draw square
for (int col = 1; col <= numOfTriangle; col++)
{
    for (int row = 1; row <= numOfTriangle; row++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

//draw Right Angle Triangle
for (int col = 1; col <= numOfTriangle; col++)
{
    for (int space = 1; space <= numOfTriangle - col; space++)
    {
        Console.Write(" ");
    }
    for (int row = 0; row < col; row++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
Console.WriteLine();

//draw piramid
for (int col = 1; col <= numOfTriangle; col++)
{
    for (int space = 1; space <= numOfTriangle - col; space++)
    {
        Console.Write(" ");
    }
    for (int row = 1; row < col * 2; row++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();