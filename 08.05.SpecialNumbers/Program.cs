﻿/*
5.	Special Numbers
Write a program that reads an integer N from the user and generates all possible "special" numbers from 1111 to 9999. 
For a number to be "special", it must satisfy the following condition:
    •	N should be divisible by each of its digits without a remainder.

Example: For N = 16, 2418 is a special number:
    •	16 / 2 = 8 without remainder
    •	16 / 4 = 4 without remainder
    •	16 / 1 = 16 without remainder
    •	16 / 8 = 2 without remainder

HINT: If a number contains zero as any of its digits, it’s never a special number.
Input
The input is read from the console and consists of a single integer in the range [1…600000]
Output
Print all "special" numbers on the console, separated by spaces

Example Input and Output

Input	Output
3       1111 1113 1131 1133 1311 1313 1331 1333 3111 3113 3131 3133 3311 3313 3331 3333
Comments
3 / 1 = 3 without remainder
3 / 3 = 1 without remainder
3 / 3 = 1 without remainder
3 / 3 = 1 without remainder

Input	Output
11      1111

Input	Output
16      1111 1112 1114 1118 1121 1122 1124 1128 1141 1142 1144 1148 1181 1182 1184 1188 1211 1212 1214 1218 1221 1222 1224 1228 1241 1242 1244 
        1248 1281 1282 1284 1288 1411 1412 1414 1418 1421 1422 1424 1428 1441 1442 1444 1448 1481 1482 1484 1488 1811 1812 1814 1818 1821 1822 
        1824 1828 1841 1842 1844 1848 1881 1882 1884 1888 2111 2112 2114 2118 2121 2122 2124 2128 2141 2142 2144 2148 2181 2182 2184 2188 2211 
        2212 2214 2218 2221 2222 2224 2228 2241 2242 2244 2248 2281 2282 2284 2288 2411 2412 2414 2418 2421 2422 2424 2428 2441 2442 2444 2448 
        2481 2482 2484 2488 2811 2812 2814 2818 2821 2822 2824 2828 2841 2842 2844 2848 2881 2882 2884 2888 4111 4112 4114 4118 4121 4122 4124 
        4128 4141 4142 4144 4148 4181 4182 4184 4188 4211 4212 4214 4218 4221 4222 4224 4228 4241 4242 4244 4248 4281 4282 4284 4288 4411 4412 
        4414 4418 4421 4422 4424 4428 4441 4442 4444 4448 4481 4482 4484 4488 4811 4812 4814 4818 4821 4822 4824 4828 4841 4842 4844 4848 4881 
        4882 4884 4888 8111 8112 8114 8118 8121 8122 8124 8128 8141 8142 8144 8148 8181 8182 8184 8188 8211 8212 8214 8218 8221 8222 8224 8228 
        8241 8242 8244 8248 8281 8282 8284 8288 8411 8412 8414 8418 8421 8422 8424 8428 8441 8442 8444 8448 8481 8482 8484 8488 8811 8812 8814 
        8818 8821 8822 8824 8828 8841 8842 8844 8848 8881 8882 8884 8888*/

int n = int.Parse(Console.ReadLine());


for (int i = 1111; i <= 9999; i++)
{
    int num = i;
    int count = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;


        if (digit == 0)
        {
            continue;
        }
        else if (n % digit == 0)
        {
            count++;
        }
    }
    if (count == 4)
    {
        Console.Write(i + " ");
    }
}


//Lector code:

int number = int.Parse(Console.ReadLine() ?? "1");

// now, let's iterate through all numbers and print only the special ones
for (int cn = 1111; cn <= 9999; cn++)
{
    // let's verify if `cn` is "special"

    String cnDigits = cn.ToString();

    bool isSpecial = true; // we accept that `cn` is special, unless proven otherwise

    for (int curDigit = 0; curDigit < cnDigits.Length; curDigit++)
    {
        int curDigitNumber = int.Parse(cnDigits[curDigit].ToString()); // make an `int` from the current digit

        if (curDigitNumber == 0 || number % curDigitNumber != 0)
        // ah, it contains zero, or there's a reminder from the integer division:
        // it's not special: indicate that and break the inner cycle
        {
            isSpecial = false;
            break; // break the curDigit cycle - no need to process more
        }
    }

    if (isSpecial)
        Console.Write(cn + " ");
}

//Lector code:

int n1 = int.Parse(Console.ReadLine());

for (int digit = 1111; digit <= 9999; digit++)
{

    String digits = digit.ToString();

    bool isSpecial = true;
    for (int curDigitIdx = 0; curDigitIdx < digits.Length; curDigitIdx++)
    {
        int curDigit = int.Parse(digits[curDigitIdx].ToString());

        if (curDigit == 0)
        {
            isSpecial = false;
            break;
        }

        if (n1 % curDigit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
        Console.Write(digit + " ");
}

Console.WriteLine();