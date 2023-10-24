/*
 1.	Change List
Write a program that:
    •	Reads a list of integers from the console and receives commands to manipulate the list
    •	Then until you receive "end", you will receive different commands:
        o	"Delete {element}" – delete all elements in the array, which are equal to the given element
        o	"Insert {element} {position}" – insert the element at the given position
    •	When you receive the "end" command, print the final state of the list (separated by spaces)

Example Input / Output

Input	                                Output
1 2 3 4 5 5 5 6                         1 10 2 3 4 6
Delete 5
Insert 10 1
Delete 5
end



Input	                                Output
20 12 4 319 21 31234 2 41 23 4          20 12 50 319 50 21 31234 2 41 23
Insert 50 2
Insert 50 5
Delete 4
end
*/

//Lector code:
List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string command = Console.ReadLine();


while (command != "end")
{

    string[] commandParts = command.Split(' ');
    string commandName = commandParts[0];
    int element = int.Parse(commandParts[1]);

    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));