/*
 2.	First N Numbers Sum
Write a program, which sums the numbers 1…n:
    •	Reads an integer number n from the console
    •	Sums all numbers from 1 to n
    •	Prints the numbers and the sum on the console as shown below

Example Input / Output

Input	Output		        Input	Output		        Input	Output
5	    1+2+3+4+5=15		6 	    1+2+3+4+5+6=21		3	    1+2+3=6
*/

int num = int.Parse(Console.ReadLine());
int sum = 1;

Console.Write(1);
for (int i = 2; i <= num; i++)
{
    Console.Write($"+{i}");
    sum += i;
}
Console.Write($"={sum}");