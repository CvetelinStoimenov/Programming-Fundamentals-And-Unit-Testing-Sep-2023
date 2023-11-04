/*
 3.	Sum of Prime and Non-Prime Numbers
Write a program that reads integer numbers from the console until the command "stop" is received. Find the sum of all entered prime numbers and the sum of all entered non-prime numbers. As per mathematical definition, negative numbers cannot be prime. If a negative number is entered, display the message "Number is negative." In this case, ignore the entered number and do not add it to either of the two sums. The program continues its execution, awaiting the input of the next number.
To determine if a number is prime, we can use the following algorithm:


Print the two calculated sums in the following format on two separate lines:
•	"Sum of all prime numbers is: {prime numbers sum}"
•	"Sum of all non prime numbers is: {nonprime numbers sum}"

Example Input and Output	

Input	Output	                                    Comments
3       Sum of all prime numbers is: 29             The first entered number is 3. It is a prime number, so we add it to the sum of prime numbers.
9       Sum of all non prime numbers is: 13         The next number is 9It is not a prime number, so we add it to the sum of non-prime numbers.
0                                                   The number s not a prime number, and we add it to the sum of non-prime numbers. 
7                                                   The sum becomes 9 + 0 = 9.
19                                                  The next two numbers are 7 and 19. Both are prime numbers, 
4                                                   and we add each of them to the sum of prime numbers. 3 + 7 = 
stop                                                10 and 10 + 19 = 29.    
                                                    Next is the number 4, which is not a prime number, so we add it to the corresponding sum: 
                                                    9+4=13.
                                                    We receive the "stop" command. The program terminates its execution, 
                                                    and we print the two calculated sums.

Input	Output
30      Number is negative.
83      Sum of all prime numbers is: 83
33      Sum of all non prime numbers is: 83
-1
20
stop	

Input	Output
0       Number is negative.
-9      Sum of all prime numbers is: 0
0       Sum of all non prime numbers is: 0
stop	*/

int sumOfPrimeNum = 0;
int sumOfNonPrimeNum = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "stop")
    {
        break;
    }

    int number = int.Parse(command);

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else
    {

        int divisors = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) { divisors++; }
        }
        if (divisors == 2)
        {
            sumOfPrimeNum += number;
        }
        else
        {
            sumOfNonPrimeNum += number;
        }

    }
}

Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNum}");
Console.WriteLine($"Sum of all non prime numbers is:  {sumOfNonPrimeNum}");


//Lector code:

//int sumOfPrimes = 0;
//int sumOfNonPrimes = 0;

//while (true)
//{
//    String input = Console.ReadLine(); // get the next input

//    if (input == "stop")
//        break; // we're done

//    int number = int.Parse(input); // the input is a number, make it `int`

//    if (number < 0) // Negative numbers require special treatment!
//    {
//        Console.WriteLine("Number is negative.");
//        continue; // let's continue with our cycle from its beginning
//    }

//    // Now let's determine if "number" is Prime (https://www.techtarget.com/whatis/definition/prime-number)
//    // A prime number is a whole number greater than 1 whose only factors are 1 and itself.
//    // We use the algorithm, which we have been already provided.
//    int divisors = 0;
//    for (int i = 1; i <= number; i++)
//        if (number % i == 0)
//            divisors++;

//    if (divisors == 2)
//        // only two divisors, this is a prime number
//        // add to the sum of prime numbers
//        sumOfPrimes += number;
//    else
//        // more than two divisors, this number is not a prime number
//        // add to the sum of the non-prime numbers
//        sumOfNonPrimes += number;
//}

//Console.WriteLine("Sum of all prime numbers is: " + sumOfPrimes);
//Console.WriteLine("Sum of all non prime numbers is: " + sumOfNonPrimes);