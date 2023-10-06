/*
 1.	Power of Number
Write a program to calculate number raising to a certain power:
    •	Reads a floating-point number n from the console
    •	Reads an integer number p which represents power from the console
    •	Print the result of n to the power of p

Note: Don't use Math.Pow(), use loops

Example Input / Output

Input	Output
2       32
5

Input	Output
3       81
4

Input	Output
2.5     15.625
3
*/

double n = double.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
double sum = n;

for (int i = 2; i <= p; i++)
{
    sum = sum * n;
}
Console.WriteLine(sum);


//while (p -1 != 0)
//{ 
//    sum = sum * n;
//    p--;
//}
//Console.WriteLine(sum);
