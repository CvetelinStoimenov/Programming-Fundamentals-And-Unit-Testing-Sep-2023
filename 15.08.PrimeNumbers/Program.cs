/*
8.	Prime Numbers
Write a program that:
    •	Reads two integer numbers: start of the range and end of the range
    •	Print all prime numbers in given range
Hint: A prime number is a positive integer greater than 1 that has exactly two distinct positive divisors: 1 and itself.

Example Input / Output
 
Input	Output
5       5 7 11 13 17 19 23 29 31 37 41 43 47
50

Input	Output
20      23 29
30
 */
int rangeStart = int.Parse(Console.ReadLine());
int rangeEnd = int.Parse(Console.ReadLine());
//bool isPrime = false;

for (int number = rangeStart; number <= rangeEnd; number++)
{
    int count = 0;

    for (int checkPrime = number; checkPrime > 0; checkPrime--)
    {
        if (number % checkPrime == 0)
        {
            count++;
        }
    }

    if (count == 2)
    {
        Console.Write($"{number} ");
    }

}