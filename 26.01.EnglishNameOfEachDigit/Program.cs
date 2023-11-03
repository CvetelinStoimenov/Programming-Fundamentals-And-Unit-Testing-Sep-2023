/*
 Write a program that:
•	Reads an integer positive number from the console
•	Print English name of the each digit of a given number on a separate line, starting from the last to the first digit
o	1 -> "one"
o	2 -> "two"
o	3 -> "three"
o	4 -> "four"
o	5 -> "five"
o	6 -> "six"
o	7 -> "seven"
o	8 -> "eight"
o	9 -> "nine"

Example Input / Output

Input	Output
512     two
        one
        five


Input	Output
121     one
        two
        one




Input	Output
1643    three
        four
        six
        one*/

int input = int.Parse(Console.ReadLine());

while (input != 0)
{
    int digit = input % 10;

    if (digit == 1)
    {
        Console.WriteLine("one");
    }
    else if (digit == 2) 
    {  
        Console.WriteLine("two"); 
    }
    else if (digit == 3) 
    { 
        Console.WriteLine("three"); 
    }
    else if (digit == 4) 
    {  
        Console.WriteLine("four"); 
    }
    else if (digit == 5) 
    { 
        Console.WriteLine("five"); 
    }
    else if (digit == 6) 
    { 
        Console.WriteLine("six"); 
    }
    else if (digit == 7) 
    { 
        Console.WriteLine("seven"); 
    }
    else if (digit == 8) 
    {  
        Console.WriteLine("eight"); 
    }
    else if (digit == 9) 
    { 
        Console.WriteLine("nine"); 
    }

    input = input / 10;
}
