/*
6.	Math Power
Write a program that:
    •	Reads two integer numbers from the console: base number and power
    •	Create a method, which receives two numbers as parameters:
        o	The first number – the base
        o	The second number – the power
    •	The method should return the base raised to the given power

Example Input / Output

Input	Output		Input	Output		Input	Output
3       81          2       256         4       16
4                   8                   2*/

int MathPower(int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}

int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
int result = MathPower(number, power);

Console.WriteLine(result);