string product  = Console.ReadLine();
string day  = Console.ReadLine();

if (day == "Weekday")
{
    if (product == "Banana")
    {
        Console.WriteLine("2.50");
    }
    else if (product == "Apple")
    {
        Console.WriteLine("1.30");
    }
    else if (product == "Kiwi")
    {
        Console.WriteLine("2.20");
    }
}
else
{
    if (product == "Banana")
    {
        Console.WriteLine("2.70");
    }
    else if (product == "Apple")
    {
        Console.WriteLine("1.60");
    }
    else if (product == "Kiwi")
    {
        Console.WriteLine("3.00");
    }
}