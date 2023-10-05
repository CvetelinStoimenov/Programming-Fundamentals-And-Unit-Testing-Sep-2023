/*
 2.	Odd Number
Write a program to enter an odd number:
    •	Read numbers from the console until an odd number is entered
    •	Print the odd number as output

Example Input / Output

Input	Output
2       3
4
8
3

Input	Output
5 	    5

Input	Output
4       23
8
10
23
*/

int  n = 0;

while (true)
{ 
    n = int.Parse(Console.ReadLine());

    if (n % 2 != 0)
    {
        Console.WriteLine(n);
        break;
    }
}

//Lector code:
//int num = int.Parse(Console.ReadLine());

//while (num % 2 == 0)
//{
//    // The number is not odd → read a new one
//    num = int.Parse(Console.ReadLine());
//}
//Console.WriteLine(num);