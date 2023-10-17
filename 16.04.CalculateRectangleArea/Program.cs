/*
 4.	Calculate Rectangle Area
Write a program that:
    •	Reads two integer numbers from the console: width and length
    •	Create a method which returns rectangle area with given width and length
Hint: Rectangle area can be calculated when you multiply width and length of the rectangle. 

Example Input / Output

Input   Output  Input	Output  Input	Output
3       12      6       48      5       50
4               8               10

Input   Output  Input	Output  Input	Output
8       56      3       21      2       16
7               7               8*/


static int CalcRectArea(int a, int b)
{
    return a * b;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int area = CalcRectArea(a, b);
Console.WriteLine(area);