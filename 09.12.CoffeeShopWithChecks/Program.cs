string drink = Console.ReadLine();
string extra = Console.ReadLine();
double price = 0;
double Coffee = 1;
double Tea = 0.60;
double Sugar = 0.40;

if (drink != "coffee" && drink != "tea")
{
    Console.WriteLine("Unknown drink");
    return;
}
else if (drink == "coffee" || drink == "tea")
{
    if (drink == "coffee")
    {
        if (extra == "sugar")
        {
            price = Coffee + Sugar;
        }
        else if (extra == "no")
        {
            price = Coffee;
        }
        else
        {
            Console.WriteLine("Unknown extra");
            return;
        }
    }

    else if (drink == "tea")
    {
        if (extra == "sugar")
        {
            price = Tea + Sugar;
        }
        else if (extra == "no")
        {
            price = Tea;
        }
        else
        {
            Console.WriteLine("Unknown extra");
            return;
        }
    }
    Console.WriteLine($"Final price: ${price:f2}");
}


