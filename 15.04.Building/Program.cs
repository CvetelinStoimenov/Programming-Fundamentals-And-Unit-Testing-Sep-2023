/*
 4.	Building
Write a program to print a table, representing a building:
    •	Reads two integer numbers from the console: floors count and estates count per floor
    •	Identifiers consist of: {type}{floor}{number}, e.g. L65, A12, O24
    •	Odd floors hold apartments (type A), e.g. A10, A11, A12, …
    •	Even floors hold offices (type O), e.g. O20, O21, O22, …
    •	The last floor holds large apartments (type L), e.g. L60, L61, L62

Example Input / Output

Input	Output
6       L60 L61 L62 L63
4       A50 A51 A52 A53	
        O40 O41 O42 O43
        A30 A31 A32 A33
        O20 O21 O22 O23
        A10 A11 A12 A13

Input	Output
5       L50 L51 L52
3	    O40 O41 O42
        A30 A31 A32
        O20 O21 O22
        A10 A11 A12
*/

int floors = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());

for (int col = floors; col >= 1; col--)
{
    for (int row = 0; row < estates; row++)
    {
        string type = "";
        if (col % 2 == 0)
        {
            type = "O";
        }
        if (col % 2 == 1)
        {
            type = "A";
        }
        if (col == floors)
        { 
            type = "L";
        }
        Console.Write($"{type}{col}{row} ");
    }
    Console.WriteLine();
}