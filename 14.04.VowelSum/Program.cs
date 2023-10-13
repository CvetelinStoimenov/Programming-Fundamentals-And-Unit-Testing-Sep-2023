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

//Lector code:

int countCharacters = int.Parse(Console.ReadLine());
//countCharacters = повтаряме: въвеждаме символ

int sumValues = 0; //сума от стойностите на гласните букви

for (int i = 1; i <= countCharacters; i++)
{
    char symbol = char.Parse(Console.ReadLine()); //въведения символ

    //проверка дали е гласна буква -> a, e, i, o, u
    //серия от проверки за точни стойности -> switch
    switch (symbol)
    {
        case 'a':
            //стойност = 1
            sumValues += 1; //sumValues++;
            break;
        case 'e':
            //стойност = 2
            sumValues += 2;
            break;
        case 'i':
            //стойност = 3
            sumValues += 3;
            break;
        case 'o':
            //стойност = 4
            sumValues += 4;
            break;
        case 'u':
            //стойност = 5
            sumValues += 5;
            break;
    }
}

//преминали през всички символи -> стойност -> сумирали
Console.WriteLine(sumValues);