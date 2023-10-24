/*
1.Numbers Up to 1000 Ending in 7
Write a program that prints the numbers in the range from 1 to 1000 that end with the digit 7.
Input	Output
(none)	7
        17
        27
        …
        997*/

for (int i = 7; i < 1000; i += 10)
{
    Console.WriteLine(i);
}