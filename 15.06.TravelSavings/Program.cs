/*
 6.	Travel Savings
Write a program that calculate the money collection for multiple travel destinations:
    •	Read a destination (string) and needed budget (floating-point number) for the destination
    •	Read many times amounts of collected money, until they are enough for the destination (starting from 0)
        o	Print: 
            "Collected: {sum}" where sum is formatted to 2nd digit
            or
            "Going to {destination}"

    •	Read another destination and budget and collect money again
    •	A destination "End" ends the program

Example Input / Output

Input	Output		
Bali    Collected: 800.00
3500    Collected: 2600.00
800     Collected: 3600.00
1800    Going to Bali!
1000    Collected: 5000.00
Brazil  Going to Brazil!
4600
5000
End

Input	Output
Spain   Collected: 1000.00
4000    Collected: 2500.00
1000    Collected: 4000.00
1500    Going to Spain!
1500    Collected: 400.00
Greece  Collected: 900.00
800     Going to Greece!
400
500
End
*/

while (true)
{
    string destination = Console.ReadLine();
    if (destination == "End")
    {
        break;
    }

    double budget = double.Parse(Console.ReadLine());
    string amounts = "";
    double sum = 0;

    while (budget > sum)
    {
        amounts = Console.ReadLine();

        sum += double.Parse(amounts);
        Console.WriteLine($"Collected: {sum:f2}");
    }

    Console.WriteLine($"Going to {destination}!");
    budget = 0;
}