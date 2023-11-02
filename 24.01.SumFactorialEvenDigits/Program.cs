/*Write a program that:
    •	Reads an integer number from the console
    •	Calculate sum of the factorials only on even digits of the given number
    •	Print the calculated sum

Example Input / Output

Input	Output
4532    26

Comments
First digit is 4, it is even so we calculate factorial: 4! = 4 * 3 * 2 * 1 = 24

Second digit is 5, it is odd so we skip it.

Third digit is 3, it is odd so we skip it.

Forth digit is 2, it is even so we calculate factorial: 2! = 2 * 1 = 2

Sum of factorials: 24 + 2 = 26

Input	Output
468    41064

Comments
First digit is 4, it is even so we calculate factorial: 4! = 4 * 3 * 2 * 1 = 24

Second digit is 6, it is even so we calculate factorial: 
6! = 6 * 5 * 4* 3 * 2 * 1 = 720

Third digit is 8, it is even so we calculate factorial: 
8! = 8 * 7 * 6 * 5 * 4* 3 * 2 * 1 = 40320


Sum of factorials: 24 + 720 + 40320 = 41064*/

int result = int.Parse(Console.ReadLine());

int totalResult = 0;

while (result != 0)
{
    int digit = result % 10;

    if (digit % 2 == 0)
    { 
        int resultFactorial = Factorial.CalculateFactorial(digit);
        totalResult += resultFactorial;
    }

    result = result / 10;
}

Console.WriteLine(totalResult);


public class Factorial
{
    public static int CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        if (n == 0)
        {
            return 1;
        }

        return n * CalculateFactorial(n - 1);
    }
}