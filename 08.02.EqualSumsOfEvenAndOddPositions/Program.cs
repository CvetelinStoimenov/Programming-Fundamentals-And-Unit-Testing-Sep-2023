/*
Write a program that reads two six-digit integers from the console in the range from 100000 to 300000. 
The first entered number will always be smaller than the second one. Print on one line, separated by spaces, 
all numbers that are between the two numbers red from the console and satisfy the following condition:
    •	The sum of the digits at even and odd positions must be equal. If there are no numbers that meet this condition, 
        do not output any result on the console.

Example Input and Output	

Input	    Output	
100000      100001 100012 100023 100034 100045
100050

Comments
The first number we generate is the number 100000. The sum of the digits at even positions (in yellow) is 0+0+0=0. 
The sum of the digits at odd positions (in green) is 0+0+1=1. Since the two sums are different, the number is not printed.

The next number is 100001. The sum of the digits at even positions is 1+0+0=1, and the sum of the digits at odd positions is 0+0+1=1. 
The two sums are equal, and the number is printed.
The next number for checking is 100002. It does not meet the condition and is not printed. 
……
For the number 100045 the sum of the digits at even positions is 5+0+0=5, and the sum of the digits at odd positions is 4+0+1=5. 
The two sums are equal, and the number is printed. And so on.

Input	    Output
123456      123464 123475 123486 123497 123530 123541 123552 123563 123574 123585 123596 123640 123651 123662 123673 123684 
124000      123695 123750 123761 123772 123783 123794 123860 123871 123882 123893 123970 123981 123992

Input       Output
299900      299970 299981 299992
300000

Input       Output
100115      No Output
100120*/

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());



for (int i = firstNum; i <= secondNum; i++)
{
    string currentNum = i.ToString();
    int oddSum = 0;
    int evenSum = 0;

    for (int j = 0; j < currentNum.Length; j++)
    { 
        int currentDigit = int.Parse(currentNum[j].ToString());
        if (j % 2 == 0)
        { 
            evenSum += currentDigit;
        }
        else
        {
            oddSum += currentDigit;
        }
    }
    if (oddSum == evenSum)
    {
        Console.Write(i + " ");
    }
}

//Lector code:

int firstNum1 = int.Parse(Console.ReadLine() ?? "0"); // we start from here
int secondNum1 = int.Parse(Console.ReadLine() ?? "0"); // we finish here

for (int i = firstNum1; i <= secondNum1; i++) // the main cycle, where we will process all numbers
{
    String currentNum1 = i.ToString(); // let's make the current number to String

    int oddSum1 = 0; // we will accummulate the sum of all odd digits here
    int evenSum1 = 0; // we will accummulate the sum of all even numbers here
    for (int j = 0; j < currentNum1.Length; j++) // we will process each character from the string
    {
        Char c = currentNum1[j];
        int currentDigit1 = int.Parse(c.ToString()); // get the current digit from the number, but as `int`

        if (j % 2 == 0) // add to the corresponding sum, depending on if the digit is even or not
            oddSum1 += currentDigit1;
        else
            evenSum1 += currentDigit1;
    }

    if (oddSum1 == evenSum1) // if both sums are equal, let's print the current number
        Console.Write(i + " ");
}