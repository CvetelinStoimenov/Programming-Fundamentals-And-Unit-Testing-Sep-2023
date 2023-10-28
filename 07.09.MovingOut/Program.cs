/*
 9.	Moving Out
On his eighteenth birthday, Jose decided to move out and rent an apartment. He packed his belongings in boxes and found a suitable 
apartment rental ad. He starts moving his luggage in parts, as he can't move everything at once. There is 
limited free space in his new apartment where he can arrange his belongings, so that the space is suitable for living.
Write a program that calculates the free volume of Jose's apartment after he moves his luggage.

Note: One box has exact dimensions: 1m x 1m x 1m.

Input

The user enters the following data on separate lines
	1.	Width of the free space - an integer in the range [1...1000]
	2.	Length of the free space - an integer in the range [1...1000]
	3.	Height of the free space - an integer in the range [1...1000]
	4.	On the following lines (until receiving the command "Done") - the number of boxes being moved into the apartment - 
	an integer in the range [1...10000]
The program should stop reading data when the command "Done" is entered or when the free space runs out.

Output

Print on the console one of the following lines:
	•	If you reach the "Done" command and there is still available space:
		"{remaining cubic meters} Cubic meters left."
	•	If the available space runs out before the "Done" command is reached:
		"No more free space! You need {needed cubic meters} Cubic meters more."

Example Input and Output

Вход	Изход													
10		No more free space! You need 2 Cubic meters more.
10
2
20
20
20
20
122

Обяснение
10 * 10 * 2 = 200 cubic meters available
20 + 20 + 20 + 20 + 122 = 202 cubic meters
200 - 202 = 2 cubic meters needed


Вход	Изход													
10		10 Cubic meters left.
1
2
4
6
Done

Обяснение
10 * 1 * 2 = 20 cubic meters available
4 + 6 = 10 cubic meters
20 - 10 = 10 cubic meters left*/

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int apartmentSpace = width * length * height;

while (apartmentSpace > 0)
{
    string command = Console.ReadLine();

    if (command == "Done")
    {

        break;
    }
    else
    {
        apartmentSpace -= int.Parse(command);
    }
}

if (apartmentSpace < 0)
{
    Console.WriteLine($"No more free space! You need {-apartmentSpace} Cubic meters more.");
}
else if (apartmentSpace == 0)
{
    Console.WriteLine($"All boxes are moved successfully!");
}
else
{
    Console.WriteLine($"{apartmentSpace} Cubic meters left.");
}
