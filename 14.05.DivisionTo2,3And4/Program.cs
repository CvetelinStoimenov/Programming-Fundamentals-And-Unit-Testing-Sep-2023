/*
5.Division to 2, 3 and 4
Write a program to find statistics about division to 2, 3 and 4:
    •	Read an integer number N and N integers from the console
    •	Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4
    •	Print the percentages, formatted to the second decimal digit:
        o On the first line print percent of the numbers that are divisible by 2
        o	On the first line print percent of the numbers that are divisible by 3
        o	On the first line print percent of the numbers that are divisible by 4

Example Input / Output

Input	Output
3	    33.33%
3       100.00%
6       0.00%
9

Input   Output
3       66.67%
4       66.67%
6       33.33%
3*/

int numOfDig = int.Parse(Console.ReadLine());
double diviBy2 = 0;
double diviBy3 = 0;
double   diviBy4 = 0;

for (int i = 0; i < numOfDig; i++)
{
    int input = int.Parse((Console.ReadLine()));
    if (input % 2 == 0)
    {
        diviBy2++;
    }
    if (input % 3 == 0)
    {
        diviBy3++;
    }
    if (input % 4 == 0)
    {
        diviBy4++;
    }
}

Console.WriteLine($"{(diviBy2 / numOfDig) * 100:f2}%");
Console.WriteLine($"{(diviBy3 / numOfDig) * 100:f2}%");
Console.WriteLine($"{(diviBy4 / numOfDig) * 100:f2}%");