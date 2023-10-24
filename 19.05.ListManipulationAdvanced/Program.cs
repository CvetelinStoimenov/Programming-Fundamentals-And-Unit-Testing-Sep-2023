/*
 5.	List Manipulation Advanced
Write a program that: 
    •	Reads a list of integers
    •	Then until you receive "end", you will receive different commands:
        o	"Contains {number}" – check if the list contains the number and if so - print "Yes", otherwise print "No such number"
        o	"PrintEven" – print all the even numbers, separated by a space
        o	"PrintOdd" – print all the odd numbers, separated by a space
        o	"GetSum" – print the sum of all the numbers
        o	"Filter {condition} {number}" – print all the numbers that fulfill the given condition. 
        The condition will be either '<', '>', ">=", "<="
    •	When you receive the "end" command, print the final state of the list (separated by spaces)

Example Input / Output

Input	                        Output
5 34 678 67 5 563 98
Contains 23                     No such number
PrintOdd                        5 67 5 563
GetSum                          1450
Filter >= 21                    34 678 67 563 98
end


2 13 43 876 342 23 543
Contains 100                    No such number
Contains 543                    Yes
PrintEven                       2 876 342
PrintOdd                        13 43 23 543
GetSum                          1842
Filter >= 43                    43 876 342 543
Filter < 100                    2 13 43 23
end*/

using System;
using System.ComponentModel.Design;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string command = Console.ReadLine();


while (command != "end")
{

    string[] commandParts = command.Split(' ');
    string commandName = commandParts[0];

    if (commandName == "Contains")
    {
        int num = int.Parse(commandParts[1]);
        if (numbers.Contains(num))
        {
            Console.WriteLine("Yes");
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("No such number");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
    else if (commandName == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                    Console.Write($"{number} ");
            }
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandName == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandName == "GetSum")
    {
        //Console.WriteLine(numbers.Sum());

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; 
        }
        Console.WriteLine(sum);
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandName == "Filter")
    {
        string op = commandParts[1];
        int num = int.Parse(commandParts[2]);

        foreach (int number in numbers)
        {
            if (op == "<")
            {
                if (number < num)
                {
                    Console.Write($"{number} ");
                }
            }
            else if (op == ">")
            {
                if (number > num)
                {
                    Console.Write($"{number} ");
                }
            }
            else if (op == ">=")
            {
                if (number >= num)
                {
                    Console.Write($"{number} ");
                }
            }
            else if (op == "<=")
            {
                if (number <= num)
                {
                    Console.Write($"{number} ");
                }
            }
        }
        Console.WriteLine();
    }
    command = Console.ReadLine();
}

//Lector code:


while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        //1. command = "Contains 6".Split(" ") -> ["Contains", "6"]
        int numberContained = int.Parse(command.Split(" ")[1]); //число, което ще проверявам дали го има в списъка
        if (numbers.Contains(numberContained))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        //2. command = "PrintEven"
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); //нов ред след списъка с четни числа
    }
    else if (command == "PrintOdd")
    {
        //3. command = "PrintOdd"
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); //нов ред след списъка с нечетнни числа
    }
    else if (command == "GetSum")
    {
        //4. command = "GetSum"
        Console.WriteLine(numbers.Sum());
    }
    else if (command.StartsWith("Filter"))
    {
        //5. command = "Filter >= 3".Split(" ") -> ["Filter", "<", "3"]
        string condition = command.Split(" ")[1]; //условие: '<', '>', ">=", "<="
        int number = int.Parse(command.Split(" ")[2]); //число, за което ще изпълняваме условието
        switch (condition)
        {
            case "<":
                numbers.RemoveAll(numberInList => numberInList >= number);
                break;
            case ">":
                numbers.RemoveAll(numberInList => numberInList <= number);
                break;
            case "<=":
                numbers.RemoveAll(numberInList => numberInList > number);
                break;
            case ">=":
                numbers.RemoveAll(numberInList => numberInList < number);
                break;
        }
    }

    command = Console.ReadLine();

}

Console.WriteLine(string.Join(" ", numbers));