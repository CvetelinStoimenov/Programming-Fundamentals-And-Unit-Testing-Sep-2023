/*
4.Vowel Sum
Write a program to sum N vowels, according to the table below:
    •	Read an integer number N: the count of characters
    •	Read N characters and for each vowel character adds its value from the table to the result

Example Input / Output

Input   Output
2       3
a
e

Input   Output
3       8
i
x
u

Input   Output
3       5
o
g
a*/

int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < n; i++)
{
    string vowel = Console.ReadLine();

    if (vowel == "a")
    {
        int value = 1;
        sum = sum + value;
    }
    else if (vowel == "e")
    {
        int value = 2;
        sum = sum + value;
    }
    else if (vowel == "i")
    {
        int value = 3;
        sum = sum + value;
    }
    else if (vowel == "o")
    {
        int value = 4;
        sum = sum + value;
    }
    else if (vowel == "u")
    {
        int value = 5;
        sum = sum + value;
    }
}

Console.WriteLine(sum);


//while (n > 0)
//{
//    string vowel = Console.ReadLine();

//    if (vowel == "a")
//    {
//        int value = 1;
//        sum = sum + value;
//    }
//    else if (vowel == "e")
//    {
//        int value = 2;
//        sum = sum + value;
//    }
//    else if (vowel == "i")
//    {
//        int value = 3;
//        sum = sum + value;
//    }
//    else if (vowel == "o")
//    {
//        int value = 4;
//        sum = sum + value;
//    }
//    else if (vowel == "u")
//    {
//        int value = 5;
//        sum = sum + value;
//    }
//    n--;
//}
