/*
5.Journey
Oddly, many individuals tend to plan their vacations well in advance. A young programmer, for instance, 
possesses a specific budget and a certain amount of free time during a particular season. Your task is to 
create a program that takes the budget and the season as inputs from the console, and produces an output 
detailing where the programmer will relax and how much he will spend.
The budget determines the choice of destination, while the and the season impacts how much 
of the budget will be spent. In the summer, camping is the chosen option, while in the winter, 
a hotel stay is preferred. However, if the destination is in Europe, a hotel stay will be selected no matter of the season.
Each camping site or hotel has a price associated with it, which corresponds to a specific percentage of the budget: 

•	If the budget is 100 leva or less - the destination will be somewhere in Bulgaria
    o	Summer - 30% of the budget
    o	Winter - 70% of the budget

•	If the budget is 1 000 leva or less - the destination will be somewhere in the Balkans
    o	Summer - 40% of the budget
    o	Winter - 80% of the budget

•	More than 1 000 leva - somewhere in Europe
    o	When traveling around Europe, regardless of the season, you will spend 90% of the budget.

Input

The input is read from the console - two lines, provided by the user:

•	First line - Budget, floating point number in the range [10.00...5000.00].
•	Second line - One of two possible seasons:  "summer" or "winter"

Output

Two lines must be printed as an output, on the console.

•	First line - "Somewhere in {destination}" among "Bulgaria", "Balkans" and "Europe"
•	Second line - "{holidayType} - {amountSpent}"
    o	Holidays can be between "Camp" and "Hotel"
    o	The amount must be rounded to the second decimal place.

Example Input/Output

Input	        Output
50
summer          Somewhere in Bulgaria
                Camp - 15.00

75
winter	        Somewhere in Bulgaria
                Hotel - 52.50

312
summer	        Somewhere in Balkans
                Camp - 124.80

678.53
winter	        Somewhere in Balkans
                Hotel - 542.82

1500
summer	        Somewhere in Europe
                Hotel - 1350.00*/
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string holidayType = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        budget = budget * 0.3;
        holidayType = "Camp";
    }
    else
    {
        budget = budget * 0.7;
        holidayType = "Hotel";
    }
}
else if (budget > 100 && budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        budget = budget * 0.4;
        holidayType = "Camp";
    }
    else
    {
        budget = budget * 0.8;
        holidayType = "Hotel";
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    budget = budget * 0.9;
    holidayType = "Hotel";
}
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{holidayType} - {budget:f2}");