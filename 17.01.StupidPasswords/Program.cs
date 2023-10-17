/*
 Write a program that:
    •	Reads an integer number N from the console
    •	Generates all possible passwords consisting of the following 3 parts:
        o	The first part is an even number in the range [2…N]
        o	The second digit is an odd number in the range [1…N]
        o	The third is the product of the first two
    •	The output holds all possible passwords


Input       Output
11          212 236 2510 2714 2918 21122 414 4312 4520 4728 4936 41144 616 6318 6530 6742 6954 61166 818 
            8324 8540 8756 8972 81188 10110 10330 10550 10770 10990 1011110
Input       Output
5	        212 236 2510 414 4312 4520

Input       Output
6	        212 236 2510 414 4312 4520 616 6318 6530
 */
int n = int.Parse(Console.ReadLine());

for (int firstDigit = 2; firstDigit <= n; firstDigit += 2)
{
    for (int secondDigit = 1; secondDigit <= n; secondDigit += 2)
    {
            int thirdDigit = firstDigit * secondDigit;
            Console.Write($"{firstDigit}{secondDigit}{thirdDigit} ");
    }
}