/*
 Write a program that:
    •	Creates two empty integer arrays
    •	Reads an integer number N from the console
    •	Reads two integer numbers on the next N lines 
    •	Form two integer arrays as shown below

Example Input / Output

Input	Output
4       1 10 31 20
1 5     5 9 81 41
9 10
31 81
41 20

Input	Output
2       80 19
80 23   23 31
31 19*/


int numberOfRow = int.Parse(Console.ReadLine());
List<int> firstList = new List<int>();
List<int> secondList = new List<int>();

for (int i = 0; i < numberOfRow; i++)
{
    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
    int num1 = numbers[0];
    int num2 = numbers[1];

    if (i % 2 == 0)
    {
        firstList.Add(num1);
        secondList.Add(num2);
    }
    else
    {
        firstList.Add(num2);
        secondList.Add(num1);
    }
}

Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));