/*
5.	Happy Numbers
Write a program that:
    •	Reads an integer number N from the console
    •	Generate all 4-digit happy numbers {d1}{d2}{d3}{d4} for given integer N:
    •	A number is happy if d1 + d2 == d3 + d4 == N
    •	Print all happy numbers 

Example Input / Output

Input	Output
3       1203 1212 1221 1230 2103 2112 2121 2130 3003 3012 3021 3030

Input	Output
4	    1304 1313 1322 1331 1340 2204 2213 2222 2231 2240 3104 3113 3122 3131 3140 4004 4013 4022 4031 4040*/

int number = int.Parse(Console.ReadLine());

for (int firstDigit = 1; firstDigit <= 9; firstDigit ++)
{
    for (int secondDigit = 0; secondDigit <= 9; secondDigit ++)
    {
        for (int thirdDigit = 0; thirdDigit <= 9; thirdDigit ++)
        {
            for (int fourthDigit = 0; fourthDigit <= 9; fourthDigit++)
            {
                if (firstDigit + secondDigit == number && thirdDigit + fourthDigit == number)
                {
                    Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                }
            }
        }
    }
}