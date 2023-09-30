using System.Formats.Asn1;

string type = Console.ReadLine();
double area = 0;

if (type == "square")
{
    double num1 = double.Parse(Console.ReadLine());
    area = num1 * num1;
}
else if (type == "rectangle")
{
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    area = num1 * num2;
}
else if (type == "circle")
{
    double num1 = double.Parse(Console.ReadLine());
    area = Math.PI * num1 * num1;
}
else
{
    Console.WriteLine("Invalid figure.");
}

Console.WriteLine($"{area:f2}");