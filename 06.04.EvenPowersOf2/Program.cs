/*
 4.	Even powers of 2
Write a console program, that reads an integer input value n, entered from the console, and prints on the console the even powers of 
two -> 2 ≤ 2^n: 2^0, 2^2, 2^4, 2^6, …, 2^n.

Example Input/Output

Input	Output		Input	Output		Input	Output		Input	Output		Input	Output
3       1           4       1           5       1           6       1           7       1
        4                   4                   4                   4                   4
                            16                  16                  16                  16
                                                                    64                  64*/

int n = int.Parse(Console.ReadLine());
int num = 1;

for (int i = 0; i <= n; i++)
{ 
    if(i % 2 == 0)
    {
        Console.WriteLine(num);
        num *= 2 * 2;
    }
}