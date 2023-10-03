/*8.On Time for Exam
A student is required to take an exam at a specific time (e.g., at 9:30 a.m.). 
However, he arrives at the exam room at a given time of arrival (e.g., 9:40 a.m.). 
The student is considered to have arrived on time if he arrives at the exam time or up to half an hour before it. 
If they arrive earlier than 30 minutes, he is considered early. If he arrives after the exam time, he is considered late. 
Write a program that reads the exam time and the time of arrival, and then prints whether the student is on time, 
early, or late, along with the number of hours or minutes he is early or late.

Input

From the console are read 4 integer values (one per line) entered by the user:

    •	The first line contains an exam time – hour - an integer from 0 to 23.
    •	The second line contains an exam time – minute - an integer from 0 to 59.
    •	The third line contains the time of arrival – hour - an integer from 0 to 23.
    •	The fourth line contains the time of arrival – minute - an integer from 0 to 59.

Output

On the first line, print on of the following messages:

    •	"Late" - if the student arrives later than the time of the exam.
    •	"On time" - if the student arrives exactly at the time of the exam or up to 30 minutes in advance.
    •	"Early" - if the student arrives more than 30 minutes before the exam time.

On the second line, print a message, considering the following conditions:

    •	If the student arrives with at least a minute difference from the exam time, print on the next line:
        o For being late under an hour: "{mm} minutes after the start"
        o For a delay of 1 hour or more: "{hh:mm} hours after the start".

            	Always print the minutes with 2 digits, such as "1:03".

Example Input/Output

Input	Output		                    Input	Output		                    Input	Output
9       Late                            9       Late                            10      On time
30      20 minutes after the start		00      1:30 hours after the start		00
9                                       10                                      10
50	                                    30                                      00


9	    On time		                    14      On time                         11      Early
00      30 minutes before the start     00      5 minutes before                30      35 minutes 
8                                       13      the start                       10      before the start
30                                      55                                      55


16	    Early                           11      Early                           11      Late
00      1:00 hours before the start		30      3:18 hours before the start     30      59 minutes after 
15                                      8       the start                       12      the start
00                                      12                                      29*/

int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int arTotalM = arrivalHour * 60 + arrivalMinute;
int exTotalM = examHour * 60 + examMinute;

int dif = exTotalM - arTotalM;

string status = "";
string comparison = "";

if (dif >= 0 && dif <= 30)
{
    status = "On time";
    comparison = "before";
}
else if (dif < 0)
{
    status = "Late";
    comparison = "after";
    dif = -dif;
}
else
{
    status = "Early";
    comparison = "before";
}

int compH = dif / 60;
int compM = dif % 60;

Console.WriteLine(status);
if (compH > 0)
{
    Console.WriteLine($"{compH}:{compM:D2} hours {comparison} the start");
}
else if (compM > 0)
{
    Console.WriteLine($"{compM} minutes {comparison} the start");
}