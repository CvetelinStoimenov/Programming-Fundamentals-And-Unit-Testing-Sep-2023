/*
8.Multiplication Sign
Write a program that:
    •	Reads three integer numbers (num1, num2 and num3) from the console
    •	 Finds if num1 * num2 * num3 (the product) is negative, positive or zero
    •	Print:
        o negative - if the product is smaller than 0 
        o	positive - if the product is bigger than 0
        o	zero - if the product is equals to 0

Note: Try to do this WITHOUT multiplying the three numbers.

Example Input / Output

Input	Output		Input	Output		Input	Output
2       negative    2       positive    7       zero
3                   3                   0
-1                  1                   1*/

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

PrintSign(num1, num2, num3);

static void PrintSign(int num1, int num2, int num3)
{
    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if ((num1 > 0 && num2 > 0 && num3 > 0)
          || (num1 > 0 && num2 < 0 && num3 < 0)
          || (num1 < 0 && num2 > 0 && num3 < 0)
          || (num1 < 0 && num2 < 0 && num3 > 0))
    {
        Console.WriteLine("positive");
    }
    else if ((num1 < 0 && num2 < 0 && num3 < 0)
          || (num1 < 0 && num2 > 0 && num3 > 0)
          || (num1 > 0 && num2 < 0 && num3 > 0)
          || (num1 > 0 && num2 > 0 && num3 < 0))
    {
        Console.WriteLine("negative");
    }
}