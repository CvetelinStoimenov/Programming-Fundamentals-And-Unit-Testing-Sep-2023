int daysToStay = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string assessment = Console.ReadLine();

double totalCost = 0;
int nights = daysToStay - 1;

if (typeOfRoom == "room for one person")
{
    totalCost = nights * 118;
}
else if (typeOfRoom == "apartment")
{
    if (daysToStay < 10)
    {
        totalCost = (nights * 155) * 0.7;
    }
    else if (daysToStay >= 10 && daysToStay <= 15)
    {
        totalCost = (nights * 155) * 0.65;
    }
    else if (daysToStay > 15)
    {
        totalCost = (nights * 155) * 0.5;
    }
}
else if (typeOfRoom == "president apartment")
{
    if (daysToStay < 10)
    {
        totalCost = (nights * 235) * 0.9;
    }
    else if (daysToStay >= 10 && daysToStay <= 15)
    {
        totalCost = (nights * 235) * 0.85;
    }
    else if (daysToStay > 15)
    {
        totalCost = (nights * 235) * 0.8;
    }
}

if (assessment == "positive")
{
    totalCost *= 1.25;
}
else if (assessment == "negative")
{
    totalCost *= 0.9;
}

Console.WriteLine($"{totalCost:f2}");