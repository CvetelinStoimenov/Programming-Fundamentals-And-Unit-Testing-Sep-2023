/*
6.	Sequence of Numbers 2k + 1
Write a program that reads a number n, entered by the user and prints all numbers ≤ n from the sequence: 1, 3, 7, 15, 31, …. 
Each subsequent number is calculated by multiplying the previous one by 2 and adding 1.

Example Input/Output

Input	Output		Input	Output		Input	Output		Input	Output
3       1           8       1           17      1           31      1
        3                   3                   3                   3
                            7                   7                   7
                                                15                  15
                                                                    31*/

int count = int.Parse(Console.ReadLine());
int sum = 1;

while (count >= sum)
{
    Console.WriteLine(sum);
    sum = sum * 2 + 1;
}