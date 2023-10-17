/*
7.Greater of Two Values
Write a program that:
    •	Reads a type (string) and two values of this type from the console
    •	Entered type can be one of the following values: "int", "char" or "string"
    •	Create methods which can compare int, char or string
    •	Return the biggest of the two values

Example Input / Output

Input	Output		Input	Output		Input	Output
int     16          char    z           string  bbb
2                   a                   aaa
16                  z                   bbb*/
static int FindGreatherNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }

}

static char FindGreatherChar(char ch1, char ch2)
{
    if (ch1 > ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
}

static string FindGreatherString(string str1, string str2)
{
    if (str1.CompareTo(str2) > 0)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}

string type = Console.ReadLine();

if (type == "int")
{
    int firstValue = int.Parse(Console.ReadLine());
    int secondtValue = int.Parse(Console.ReadLine());
    Console.WriteLine(FindGreatherNumber(firstValue, secondtValue));
}
else if (type == "char")
{
    char firstValue = char.Parse(Console.ReadLine());
    char secondtValue = char.Parse(Console.ReadLine());

    Console.WriteLine(FindGreatherChar(firstValue, secondtValue));
}
else if (type == "string")
{
    string firstValue = Console.ReadLine();
    string secondtValue = Console.ReadLine();
    Console.WriteLine(FindGreatherString(firstValue, secondtValue));
}

