/*
1.	Magic Numbers
Write a program that:
    •	Reads an integer number N from the console, always greater than 1
    •	Print all magic numbers in range [1; N] - separated by single space
    •	The number is magic when:
        o	All of its digits are prime numbers
        o	Sum of all digits is divisible by 2
    •	If the are no such numbers print "no"

Example Input / Output

Input	Output	                            Comments
25      2 22                                We have to check numbers in range [1; 25]
                                            Magic numbers in this range are 2 and 22.

Input	Output
100     2 22 33 35 37 53 55 57 73 75 77*/

//int input = int.Parse(Console.ReadLine());
//int sumOfNums = 0;

//for (int number = 1; number <= input; number++)
//{
//    int numCheck = number;

//    while (numCheck != 0)
//    {
//        int digit = numCheck % 10;

//        sumOfNums += digit;

//        numCheck = numCheck / 10;
//    }

//    if (sumOfNums % 2 == 0)
//    {
//        int count = 0;
//        numCheck = number;
//        int digit = numCheck % 10;

//        for (int checkPrime = digit; checkPrime > 0; checkPrime--)
//        {
//            if (digit % checkPrime == 0)
//            {
//                count++;
//            }
//        }

//        if (count == 2)
//        {

//            Console.Write($"{number} ");
//        }
//        numCheck = numCheck / 10;
//    }

//    sumOfNums = 0;

//}


        int input = int.Parse(Console.ReadLine());

        bool isMagicNumber;

        for (int number = 1; number <= input; number++)
        {
            isMagicNumber = true;
            int sumOfDigits = 0;
            int numCheck = number;

            while (numCheck > 0)
            {
                int digit = numCheck % 10;

                if (!IsPrime(digit))
                {
                    isMagicNumber = false;
                    break;
                }

                sumOfDigits += digit;
                numCheck = numCheck / 10;
            }

            if (isMagicNumber && sumOfDigits % 2 == 0)
            {
                Console.Write($"{number} ");
            }
        }

        if (!HasMagicNumbers(input))
        {
            Console.WriteLine("no");
        }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;

        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static bool HasMagicNumbers(int N)
    {
        for (int number = 1; number <= N; number++)
        {
            int numCheck = number;
            bool isMagicNumber = true;
            int sumOfDigits = 0;

            while (numCheck > 0)
            {
                int digit = numCheck % 10;

                if (!IsPrime(digit))
                {
                    isMagicNumber = false;
                    break;
                }

                sumOfDigits += digit;
                numCheck = numCheck / 10;
            }

            if (isMagicNumber && sumOfDigits % 2 == 0)
            {
                return true;
            }
        }

        return false;
    }

