/*
 6.Number Processor
Write a program to process a sequence of commands:
    •	Read an initial number from the input
    •	Read an execute a sequence of the following commands:
        o   "Inc" – add 1 to the number (increment)
        o   "Dec" – subtract 1 from the number (decrement)
        o   "End" – print the number and stop the program

Example Input / Output

Input	Output
5       6
Inc
End	

Input	Output
5       4
Dec
End

Input	Output
7       8
Inc
Inc
Dec
End
*/

//int num = int.Parse(Console.ReadLine());

//while (true)
//{ 
//    string input = Console.ReadLine();
//    if (input == "Inc")
//    {
//        num++;
//    }
//    else if (input == "Dec")
//    {
//        num--;
//    }
//    else if (input == "End")
//    {
//        break;
//    }
//}
//Console.WriteLine(num);

//Lector code:

int num = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (command != "End")
{
    if (command == "Inc")
    {
        num++;
    }
    else if (command == "Dec")
    {
        num--;
    }
    command = Console.ReadLine();

}
Console.WriteLine(num);