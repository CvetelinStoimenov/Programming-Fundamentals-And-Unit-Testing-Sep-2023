/*
 4.	List Manipulation Basics
Write a program that: 
    •	Reads a list of integers
    •	Then until you receive "end", you will receive different commands:
        o	"Add {number}": add a number to the end of the list
        o	"Remove {number}": remove a number from the list
        o	"RemoveAt {index}": remove a number at a given index
        o	"Insert {number} {index}": insert a number at a given index
    •	When you receive the "end" command, print the final state of the list (separated by spaces)

Note: All the indices will be valid!

Example Input / Output

Input	                        Output
4 19 2 53 6 43                  4 53 6 8 43 3
Add 3
Remove 2
RemoveAt 1
Insert 8 3
end

Input	                        Output
23 1 456 63 32 87 9 32          4 53 6 8 43 3
Remove 5
Add 1
Insert 14 2
RemoveAt 3
Add 34
end*/

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string command = Console.ReadLine();


while (command != "end")
{

    string[] commandParts = command.Split(' ');
    string commandName = commandParts[0];
    int element = int.Parse(commandParts[1]);

    if (commandName == "Remove")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }
    else if (commandName == "Add")
    {
        numbers.Add(element);
    }
    else if (commandName == "RemoveAt")
    {
        numbers.RemoveAt(element);
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));