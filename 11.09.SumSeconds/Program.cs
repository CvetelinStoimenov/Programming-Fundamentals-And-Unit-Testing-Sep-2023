/*
9.	Sum Seconds
Three athletes finish in a certain number of seconds (between 1 and 50). 
Write a program that:

•	Read three integers - the athletes' times in seconds, from console
•	 Calculate their total time in the format "minutes:seconds"

Note: The seconds should be displayed with leading zero (2 as "02", 7 as "07", 35 as "35").

Example Input / Output

Input	Output		Input	Output		Input	Output
35	    2:04		22      1:03		50	    2:29
45                  7                   50
44                  34                  49
*/

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int sum = num1 + num2 + num3;
int min = sum / 60;
int sec = sum % 60;


if (sec < 10)
{
    Console.WriteLine($"{min}:0{sec}");
}
else
{
    Console.WriteLine($"{min}:{sec}");
}