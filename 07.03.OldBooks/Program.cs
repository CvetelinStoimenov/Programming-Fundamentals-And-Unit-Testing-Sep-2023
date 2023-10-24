/*
 3.	The Old Library 
Annie returns to her hometown after a very long period abroad. Upon returning home, she sees her grandmother's old 
library and remembers her favorite book. Help Annie by writing a program, where she enters the title of the book she's looking for (text). 
Until Ani doesn't find her favorite book or doesn't check all the books in the library, 
the program should read the name of the next book (text) on a new line. When you receive the text "No More Books", 
then all the books are checked.
	• If Annie doesn't find the book she's looking for, print two lines:
		o "The book you search is not here!"
		o "You checked {number} books."
	• If she finds the book, print one line:
		o "You checked {number} books and found it."

Example Input and Output

Input			Output											Comments
Troy			You checked 2 books and found it.				The book Ani is looking for, in this case, 
Stronger														is Troy. The first book in the library is 
Life Style														Stronger, the second is Life Style, and 
Troy															the third book is the that Annie is 
																looking for – Troy and the program 
																looking for – Troy and the program 

Input			Output											Comments
The Spot														The book Ani is searching for is The 
Hunger Games	You checked 4 books.							Spot. The first book in the library is 
Harry Potter	The book you search is not here!				Hunger Games, the second is Harry 
Torronto														Potter, the third is Torronto and the 
Spotify															fourth is Spotify. Since there are no 
No More Books													more books in the library, the reading of 
																names ends. Ani did not find the book 
																she was looking for.

Input			Output
Bourne			You checked 10 books and found it.
True Story
Forever
More Space
The Girl
Spaceship
Strongest
Profit
Tripple
Stella
The Matrix
Bourne*/

string searchBook = Console.ReadLine();
string book = "";
int count = 0;

while (searchBook != book)
{
    book = Console.ReadLine();
	if (book == "No More Books")
	{
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {count} books.");
		return;
    }
	count++;
}
Console.WriteLine($"You checked {count - 1} books and found it.");