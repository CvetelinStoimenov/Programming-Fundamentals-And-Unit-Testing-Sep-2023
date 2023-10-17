/*
 6.	Vowels Count
Write a program that:
    •	Read a text (string) from the console
    •	Create a method that receives a text
    •	Find the count of the vowels contained in the text
    •	Print the count of the vowels in the text

Example Input / Output

Input	    Output
SoftUni     3
Cats        1
JS          0*/

string text = Console.ReadLine();
Console.WriteLine(GetVowelsCount(text));

int GetVowelsCount(string text)
{
    int count = 0;

    for (int position = 0; position <= text.Length - 1; position++)
    { 
        char symbol = text[position];
        if (symbol == 'A' || symbol == 'a'
            || symbol == 'E' || symbol == 'e'
            || symbol == 'I' || symbol == 'i'
            || symbol == 'O' || symbol == 'o'
            || symbol == 'U' || symbol == 'u')
        {
            count++;
        }
    }

    return count;
}


//ChatGPT code
//string text = Console.ReadLine();
//int vowelCount = CountVowels(text);
//Console.WriteLine(vowelCount);

//static int CountVowels(string text)
//{
//    int count = 0;
//    text = text.ToLower(); // Convert the text to lowercase for case-insensitive matching

//    foreach (char character in text)
//    {
//        if ("aeiou".Contains(character))
//        {
//            count++;
//        }
//    }

//    return count;
//}