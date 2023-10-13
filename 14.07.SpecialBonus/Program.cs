/*
7.	Special Bonus
Write a program to apply a 20% bonus for certain number: 
    •	Reads an integer number from the console: the "stop number"
    •	Keep reading integers until it finds the stop number
    •	When the stop number is found, increase the value of the previous number before it with 20% and print it

Example Input / Output

Input	Output		Input	Output
25      36          14      12
20                  6
30                  10
25                  14*/

int n = int.Parse(Console.ReadLine());
int stop = n;

while (true)
{
    int n1 = n;
    n = int.Parse(Console.ReadLine());
    if (n == stop)
    {
        Console.WriteLine(n1 * 1.2);
        break;
    }
}

//Lector code:

int stopNumber = int.Parse(Console.ReadLine()); //число, което ако въведем спираме

//повтаряме: въвеждаме числа -> проверка дали съвпада с stopNumber
int prevNumber = 0; //последно въведено число

while (true)
{
    int number = int.Parse(Console.ReadLine()); //въведено число
    if (number == stopNumber)
    {
        //1. увеличавам предното с 20%
        //2. принтирам
        //prevNumber + 20% = prevNumber + 0.20 * prevNumber = 1.2 * prevNumber
        Console.WriteLine(prevNumber * 1.2);
        break;
    }

    prevNumber = number;
}