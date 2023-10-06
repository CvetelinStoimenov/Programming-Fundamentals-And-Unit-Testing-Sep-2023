/*
7.	Special Bonus
Write a program to apply a 20% bonus for certain number: 
    •	Reads an integer number from the console: the "stop number"
    •	Keep reading integers until it finds the stop number
    •	When the stop number is found, increase the value of the previous number before it with 20% and print it

Example Input / Output

Input	Output		Input	Output
25      36          14      12
20                  6
30                  10
25                  14*/

int n = int.Parse(Console.ReadLine());
int stop = n;

while (true)
{
    int n1 = n;
    n = int.Parse(Console.ReadLine());
    if (n == stop)
    {
        Console.WriteLine(n1 * 1.2);
        break;
    }
}