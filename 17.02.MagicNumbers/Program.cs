/*
1.	Magic Numbers
Write a program that:
    •	Reads an integer number N from the console
    •	Find all 3-digit magic numbers

Note: A magic number is a three-digit number where the product of its digits equals the value of N. 
If you have a three-digit number abc, where a, b and c are its digits, it is considered a magic number of order N, 
if a * b * c = N.

Example Input / Output

Input	Output		Input	Output		        Input	Output
1       111         3       113 131 311         7       117 171 711 
 */

int n = int.Parse(Console.ReadLine());

for (int firstDigit = 1; firstDigit <= 9; firstDigit ++)
{
    for (int secondDigit = 0; secondDigit <= 9; secondDigit ++)
    {
        for (int thirdDigit = 0; thirdDigit <= 9; thirdDigit ++)
        {
            int sum = firstDigit * secondDigit * thirdDigit;
            if (sum == n)
            {
                Console.Write($"{firstDigit}{secondDigit}{thirdDigit} ");
            }
        }
    }
}