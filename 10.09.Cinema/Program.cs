string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double total = 0;

if (type == "Premiere")
{
    total = rows * seats * 12.00;
}
else if (type == "Normal")
{
    total = rows * seats * 7.50;
}
else
{
    total = rows * seats * 5.00;
}

Console.WriteLine($"{total:f2}");