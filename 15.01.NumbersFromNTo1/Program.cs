/*
1.Numbers From N to 1
Write a program that:
    •	Reads an integer number N from the console
    •	Prints the numbers from N to 1, each on separate line

Example Input / Output

Input	Output		Input	Output
2       2           4       4
        1                   3
                            2
                            1
*/
int number = int.Parse(Console.ReadLine());

for (int i = number; i >= 1; i--)
{
    Console.WriteLine(i);
}