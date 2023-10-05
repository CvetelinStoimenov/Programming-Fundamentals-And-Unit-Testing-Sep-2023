/*
 3.	Sum Numbers
Write a program to sum given N numbers:
    •	Read integer number n – the count of numbers to sum
    •	Read n floating-point numbers and print their sum

Example Input / Output

Input	Output		Input	Output		Input	Output
3	    60		    4 	    7.2		    2       8
10                  2.5                 4.5
20                  3.5                 3.5
30                  0.3
                    0.9
*/

int count = int.Parse(Console.ReadLine());
double num = 0;

double sum = 0;

for (int i = 0; i < count; i++)
{
    num = double.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine(sum);

//int i = 0;
//while (i < count)
//{
//    num = double.Parse(Console.ReadLine());
//    sum += num;
//}
//Console.WriteLine(sum);