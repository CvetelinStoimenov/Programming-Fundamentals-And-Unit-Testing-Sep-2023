/*
 5.	Number In Range
Write a program to read a number in the range [1 … 100]:
    •	Read an integer number from the console
    •	Check if the number is in the range [1 … 100]
        o	No (number is NOT in the range)  read a new number
        o	Yes (number is IN the range)  print the number and the program stops

Example Input / Output

Input	Output
-10     50
101
50

Input	Output
150     12
-45
12

Input	Output
330     89
450
89
*/

//int n = int.Parse(Console.ReadLine());

//while (true)
//{
//    if (n >= 1 && n <= 100)
//    {
//        break;
//    }
//    else
//    {
//        n = int.Parse(Console.ReadLine());
//    }
//}
//Console.WriteLine(n);

//Lector Code 1:

//int num = int.Parse(Console.ReadLine());

//bool inRange = num >= 1 &&  num <= 100;

//while (!inRange)
//{
//    num = int.Parse(Console.ReadLine());
//    inRange = num >= 1 && num <= 100;
//}
//Console.WriteLine(num);

//Lector Code 2:

//int num = 0;

//while (true)
//{
//    num = int.Parse(Console.ReadLine());
//    if (num >= 1 && num <= 100)
//    {
//        break;
//    }
//}
//Console.WriteLine(num);

//Lector Code 3:

int num = int.Parse(Console.ReadLine());

while (num < 1 || num > 100)
{
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine(num);