string drink = Console.ReadLine();
string extra = Console.ReadLine();
double price = 0;
double Coffee = 1;
double Tea = 0.60;
double Sugar = 0.40;


if (drink == "coffee")
{
    if (extra == "sugar")
    {
        price = Coffee + Sugar;
    }
    else
    {
        price = Coffee;
    }
}

else if (drink == "tea")
{
    if (extra == "sugar")
    {
        price = Tea + Sugar;
    }
    else
    {
        price = Tea;
    }
}


Console.WriteLine($"Final price: ${price:f2}"); 