/*
 3.	Sequence 2k + 1
Write a program to print a sequence of numbers:
    •	The first number is 1
    •	Each next number is 2 times the previous number + 1
    •	Read an integer number n from the console – the max number
    •	Print the elements of the sequence (starting with 1), which are ≤ n

Example Input / Output

Input	Output
8   	1
        3
        7
Input	Output
15	    1
        3
        7
        15

Input	Output
33	    1
        3
        7
        15
        31
*/
int num = int.Parse(Console.ReadLine());
int num1 = 1;
Console.WriteLine(num1);

while (num1 < num)
{
    num1 += num1 + 1;
    if (num1 > num)
    {
        break;
    }
    else
    {
        Console.WriteLine(num1);
    }
}

//Lector code:

//while (num1 <= num)
//{
//    Console.WriteLine(num1);
//    num1 += num1 + 1;
//}