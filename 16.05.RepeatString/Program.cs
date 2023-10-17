/*
5.	Repeat String
Write a program that:
    •	Reads a text (string) and repeat count (integer number) from the console
    •	Write a method that receives a string and a repeat count 
    •	The method should return a new string, containing the initial one, repeated count 
        times without space

Example Input / Output

Input	Output
abc     abcabcabc
3*/

static string RepeatString(string text, int repeat)
{
    string output = "";
    for (int i = 0; i < repeat; i++)
    { 
    output += text;
    }
    return output;
}

string text = Console.ReadLine();
int repeat = int.Parse(Console.ReadLine());
string result = RepeatString(text, repeat);
Console.WriteLine(result);