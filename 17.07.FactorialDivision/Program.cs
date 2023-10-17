/*
 7.	Factorial Division
Write a program that:
    •	Read two integers numbers from the console in range [1…10]
    •	Calculate the factorial of each number
    •	Divide the first calculated factorial by the second calculated factorial (integer division)
    •	Print the result of the division

Example Input / Output

Input	Output		Input	Output
5       60          6       360
2                   2*/
//static int GetFactoriel1(int number1, int factorielNum1)
//{
//    for (int i = number1; i > 0; i--)
//    {
//        factorielNum1 *= i;
//    }

//    return factorielNum1;
//}

//static int GetFactoriel2(int number2, int factorielNum2)
//{
//    for (int i = number2; i > 0; i--)
//    {
//        factorielNum2 *= i;
//    }

//    return factorielNum2;
//}

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
//int factorielNum1 = 1;
//int factorielNum2 = 1;

//factorielNum1 = GetFactoriel1(number1, factorielNum1);
////factorielNum2 = GetFactoriel2(number2, factorielNum2);


//Console.WriteLine(factorielNum1 / factorielNum2);

//Lector code:
static int CalculateFactorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }
    return fact;
}

int factFirstNumber = CalculateFactorial(number1);
int factSecoundNumber = CalculateFactorial(number2);
Console.WriteLine(factFirstNumber / factSecoundNumber);