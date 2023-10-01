/*
7.	Working Hours
Write a program that checks if the company's office is open:
•	Reads an hour of the day (integer number) and a day of the week (string)
•	The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive.
	o	Print "open", if the office is open in the given hour and day of the week
	o	Print "closed", if the office is closed in the given hour and day of the week

Example Input / Output

Input	Output		Input	Output		Input	Output
11		open		19		closed		11		closed
Monday				Friday				Sunday
*/

int hours = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (day == "Sunday")
{
    Console.WriteLine("closed");
}
else
{
    if (hours >= 10 && hours <= 18)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
     }
}