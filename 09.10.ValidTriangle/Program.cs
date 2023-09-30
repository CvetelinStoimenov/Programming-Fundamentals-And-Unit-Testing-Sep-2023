int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}

/*GPT-3.5

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool isValidTriangle = true;

if (a + b < c || a + c < b || b + c < a)
{
    isValidTriangle = false;
}

// Print the result: valid / invalid
if (isValidTriangle)
{
    Console.WriteLine("Valid triangle.");
}
else
{
    Console.WriteLine("Invalid triangle.");
}*/