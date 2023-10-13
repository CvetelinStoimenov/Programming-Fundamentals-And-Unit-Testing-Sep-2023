/*7.Sum of Digits Calculator
Write a program that:
    •	Continuously read integers until "End" is entered from the console
        o	Print the sum of digits for each integer, use the following format: 
        "Sum of digits = {sum}"
    •	Finally, print "Goodbye"

Example Input / Output

Input	Output
157     Sum of digits = 13
99      Sum of digits = 18
5       Sum of digits = 5
438     Sum of digits = 15
End     Goodbye		

Input	Output
107     Sum of digits = 8
345     Sum of digits = 12
98      Sum of digits = 17
23      Sum of digits = 5
End     Goodbye*/


while (true)
{ 
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    int digit = int.Parse(command);
    int sum = 0;

    while (digit > 0)
    {
        int lastDigit = 0;
        lastDigit = digit % 10;
        digit /= 10;
                
        sum += lastDigit;
    }
    Console.WriteLine($"Sum of digits = {sum}");
}
Console.WriteLine("Goodbye");