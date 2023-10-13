/*
 2.	Even Powers of 2
Write a program that:
    •	Reads an integer number n from the console 
    •	Prints on the console the number two on even powers in the range [0; n] 

2 ≤ 2n: 20, 22, 24, 26, …, 2n.

Example Input / Output

Input	Output		Input	Output		Input	Output		Input	Output		Input	Output
3       1           4       1           5       1           6       1           7       1
        4                   4                   4                   4                   4
                            16                  16                  16                  16
                                                                    64                  64
 */
int power = int.Parse(Console.ReadLine());

for (int i = 0; i <= power; i += 2)
{
    Console.WriteLine($"{(long)Math.Pow(2, i):N0}");
}