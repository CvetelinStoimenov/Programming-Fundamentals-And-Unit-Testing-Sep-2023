/*
6.	Special Number
Write a program to check if given number is special: 
    •	Special numbers are divisible by all of their digits without remainder
    •	Reads an integer number and check whether it is a special number
    •	If the number IS special print: "{num} is special"
    •	If the number is NOT special print: "{num} is not special"

Note: There will not be numbers with digit 0 in them.

Example Input / Output

Input	Output		            Input	Output
23      23 is not special       212     212 is special*/

int number = int.Parse(Console.ReadLine());
int startNumber = number;

while (startNumber > 0)
{
    double lastDigit = startNumber % 10;
    startNumber = startNumber / 10;
    if (number % lastDigit != 0)
    {
        Console.WriteLine($"{number} is not special");
        break;
    }
    if (startNumber == 0)
    {
        Console.WriteLine($"{number} is special");
        break;
    }

}


//Lector code:

int number1 = int.Parse(Console.ReadLine()); //число, което ще проверявам и модифицирам
int startNumber1 = number; //първоначално въведенто число, което няма да се променя

bool isSpecial = true;
//isSpecial = true -> числото е специално
//isSpecial = false -> числто не е специално

//стоп: нямаме повече цифри -> number <= 0
//продължаваме: имаме налични цифри -> number > 0
while (number > 0)
{
    //1. последна цифра
    int lastDigit = number % 10;
    //2. проверка дали дели числото
    if (startNumber % lastDigit != 0)
    {
        //имаме цифра, която не дели числото -> не е специално
        isSpecial = false;
        break;
    }
    //3. премахвам последната цифра
    number = number / 10; //number /= 10;
}

//1. преминали сме през всички цифри -> всички цифри делят числото -> isSpecial = true
//2. имаме цифра, която не дели числото -> isSpecial = false


//проверка дали е спцеиално
if (isSpecial == true)
{
    //специално
    Console.WriteLine(startNumber + " is special");
}
else  //isSpecial == false
{
    //не е специално
    Console.WriteLine(startNumber + " is not special");
}