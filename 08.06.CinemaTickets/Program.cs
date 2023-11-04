/*
6.	Cinema Tickets
Your task is to write a program that calculates statistics about movies screened at a cinema. 
You need to find the percentage of tickets sold for different ticket types: "student", "standard", and "kid". 
You also need to calculate the percentage of seats occupied for each movie.

Input

The input includes a sequence of integers and text:
	•	On the first line - the name of the movie - string
	•	On the second line - the available seats in the cinema for the specific movie - an integer in the range [1 … 100]
	•	Next, types of tickets are read from the console on separate lines, until we have received all ticket types or the "End" command is received:
		o	The type of ticket - text ("student", "standard", "kid")
	•	After the "End" command is received, it might be received information for another movie or "Finish" command, 
	that will end the program and should return summary for the tickets sold.

Output

The following lines should be printed on the console:

	•	After each movie, print what percentage of the cinema is full:
		"{movie name} - {percentage}% full."
	•	When the command "Finish" is received, print four lines:
		o	"Total tickets: {total number of purchased tickets for all movies}"
		o	"{percentage of student tickets} % student tickets."
		o	"{percentage of standard tickets} % standard tickets."
		o	"{percentage of kids tickets} % kids tickets."

Example Input and Output

Input		Output
Taxi		Taxi - 60.00% full.
10			Scary Movie - 100.00% full.
standard	Total tickets: 12
kid			66.67% student tickets.
student		25.00% standard tickets.
student		8.33% kids tickets.
standard
standard
End
Scary Movie
6
student
student
student
student
student
student
Finish

Comments
First movie – Taxi, there are 10 seats
3 standard tickets, 2 student tickets, 1 child ticket and the command End is received.
Total of 6 tickets out of 10 seats -> 60% of the hall is occupied.
Second movie – Scary Movie, there are 6 seats.
6 student tickets are bought and the seats are finished.
Total of 6 tickets out of 6 seats -> 100% 100% of the hall is occupied.
The command Finish is received.
Total purchased tickets for all movies are 12.
For all movies, the purchased tickets are as follows:
8 student tickets. 8 tickets out of 12 is 66.67%.
3 standard tickets. 3 tickets out of 12 is 25%.
1 kid ticket. 1 ticket out of 12 is 8.33%.

Input				Output
The Matrix			The Matrix - 40.00% full.
20					The Green Mile - 35.29% full.
student				Amadeus - 100.00% full.
standard			Total tickets: 17
kid					41.18% student tickets.
kid					47.06% standard tickets.
student				11.76% kids tickets.
student
standard
student
End
The Green Mile
17
student
standard
standard
student
standard
student
End
Amadeus
3
standard
standard
standard
Finish

Comments
First movie - The Matrix, there are 20 seats.
2 standard, 4 student, and 2 kid tickets are purchased, and then the End command is received.
Total of 8 tickets out of 20 seats -> 41.18% of the hall is occupied.
Second movie - The Green Mile, there are 17 seats.
3 standard and 3 student tickets are purchased, and then the End command is received.
Total of 6 tickets out of 17 seats -> 47.06% of the hall is occupied.
Third movie - Amadeus, there are 3 seats.
3 standard tickets are purchased, and all seats are filled.
Total of 3 tickets out of 3 seats -> 100% of the hall is occupied.
The command Finish is received.
Total purchased tickets for all movies are 17.
For all movies, the purchased tickets are as follows:
7 student tickets. 7 tickets out of 17 is 41.18%.
8 standard tickets. 8 tickets out of 17 is 47.06%.
2 kid tickets. 2 tickets out of 17 is 11.76%.*/

int standard = 0;
int  kid = 0;
int student = 0;
double percentage = 0;
double totalTicket = 0;
double alllTicket = 0;

while (true)
{
	string movieName = Console.ReadLine();
    int seats = int.Parse(Console.ReadLine());

	while (true)
	{
        string ticketType = Console.ReadLine();

		if (ticketType == "student")
		{
            student++;
        }
		else if (ticketType == "standard")
		{
            standard++;
        }
        else if (ticketType == "kid")
        {
            kid++;
        }
        else if (ticketType == "End")
        {
            break;
        }
        else if (ticketType == "Finish")
        {
            alllTicket += totalTicket;
            percentage = (totalTicket / seats) * 100;
            Console.WriteLine($"{movieName} - {percentage:f2}% full.");
            Console.WriteLine($"Total tickets: {alllTicket}");
            Console.WriteLine($"{(student / alllTicket) * 100:f2} % student tickets.");
            Console.WriteLine($"{(standard / alllTicket) * 100:f2} % standard tickets.");
            Console.WriteLine($"{(kid / alllTicket) * 100:f2} % kids tickets.");
            return;
        }
        totalTicket++;
    }
	alllTicket += totalTicket;
    percentage = (totalTicket / seats) * 100 ;
    Console.WriteLine($"{movieName} - {percentage:f2}% full.");
    totalTicket = 0;
}

