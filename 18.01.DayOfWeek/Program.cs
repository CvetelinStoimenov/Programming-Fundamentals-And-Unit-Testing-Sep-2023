/*
 1.	Day of Week
Write a program that:
    •	Reads an integer number from the console
    •	If the number is in range [1…7] print:
        o	"Monday" for number 1
        o	"Tuesday" for number 2
        o	"Wednesday" for number 3
        o	"Thursday" for number 4
        o	"Friday" for number 5
        o	"Saturday" for number 6
        o	"Sunday" for number 7
    •	If the number is out of the given range print "Invalid day!"

Example Input / Output

Input	Output		Input	Output		Input	Output		Input	Output
1	    Monday		2	    Tuesday		3	    Wednesday	4   	Thursday

Input	Output		Input	Output		Input	Output		Input	Output
5   	Friday		6	    Saturday	7	    Sunday		9	    Invalid day!*/

string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

int day = int.Parse(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    Console.WriteLine(days[day -1]);
}
else
{
    Console.WriteLine("Invalid day!");
}