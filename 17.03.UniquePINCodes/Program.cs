/*
 3.	Unique PIN Codes
Write a program to generate PIN codes following certain rules:
    •	Read 3 integer digits: max1, max2, max3 (each is an upper limit)
    •	Generate unique 3-digit PIN codes, matching the following:
        o	Each digit is within the following range: 
            	First digit: [1 … max1]
            	Second digit: [1 … max2]
            	Third digit: [1 … max3]
        o	The first and the third digit must be even
        o	The second digit must be a prime number in the range [2…7]
    •	Print the PIN codes, each on separate line

Example Input / Output

Input   Output
3       222
5       224
5       232
        234
        252
        254

Input   Output
4       222
4       224
6       226
        232
        234
        236
        422
        424
        426
        432
        434
        436

Input   Output
3       222
3       224
5       232
        234
*/

int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int firstDigit = 2; firstDigit <= max1; firstDigit += 2)
{
    for (int secondDigit = 1; secondDigit <= max2; secondDigit++)
    {
        for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit += 2)
        {

            if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7 )
            {
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit} ");
            }
        }
    }
}