/*
3.	Printing Triangle
Write a program that:
    •	Reads an integer number N from the console
    •	Create a method for printing triangle depending on value of the number N
Example Input / Output

Input	Output
3	    1
        1 2
        1 2 3 
        1 2 
        1
*/

static void PrintingTriangle(int n)
{
    top(n);
    bottom(n);
}

static void top(int n)
{
    for (int col = n; col >= 0; col--)
    {
        for (int row = 1; row <= n - col; row++)
        {
            Console.Write($"{row} ");
        }
        Console.WriteLine();
    }
}

static void bottom(int n)
{
    for (int col = 1; col <= n; col++)
    {
        for (int row = 1; row <= n - col; row++)
        {
            Console.Write($"{row} ");
        }
        Console.WriteLine();
    }
}

//Lector code:
static void PrintTriangle(int n)
{
    for (int line = 1; line <= n; line++)
        PrintLine(1, line);

    for (int line = n - 1; line >= 1; line--)
        PrintLine(1, line);
}

static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}


int n = int.Parse(Console.ReadLine());
PrintingTriangle(n);