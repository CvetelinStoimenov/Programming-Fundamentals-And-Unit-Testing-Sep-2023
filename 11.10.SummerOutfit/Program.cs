int temperature = int.Parse(Console.ReadLine());
string TimeOfDay = Console.ReadLine();

if (TimeOfDay == "Evening")
{
    Console.WriteLine("It's " + temperature + " degrees, get your Shirt and Moccasins.");
}
else if (temperature >= 10 && temperature <= 18)
{
    if (TimeOfDay == "Morning")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Sweatshirt and Sneakers.");
    }
    else if (TimeOfDay == "Afternoon")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Shirt and Moccasins.");
    }
}
else if (temperature > 18 && temperature <= 24)
{
    if (TimeOfDay == "Morning")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Shirt and Moccasins.");
    }
    else if (TimeOfDay == "Afternoon")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your T-Shirt and Sandals.");
    }
}
else if (temperature >= 25)
{
    if (TimeOfDay == "Morning")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your T-Shirt and Sandals.");
    }
    else if (TimeOfDay == "Afternoon")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Swim Suit and Barefoot.");
    }
}