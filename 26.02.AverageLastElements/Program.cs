/*
 Average Last Elements
Write a program that:
    •	Reads an array of integer numbers from the first line of the console, separated by single space
    •	Read an integer number N from the second line of the console
    •	Find average value of the last N elements in the array
    •	Print the average value formatted to the second decimal digit

Example Input / Output

Input	                    Output	    Comments
3 42 61 7 8 9 10 23         12.50       Last 4 numbers in the array are: 8 9 10 23
4                                       Average value is: (8 + 9 + 10 + 23) / 4 = 12.5

Input	                    Output	    Comments
12 34 98 42 65 12           39.67       Last 3 numbers in the array are: 42 65 12
3                                       Average value is: (42 + 65 + 12) / 3 = 39.67*/

int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int cutList = int.Parse(Console.ReadLine());
double sum = 0;

int[] lastNElements = arr.TakeLast(cutList).ToArray();

for (int i = 0; i < lastNElements.Length; i++)
{
    sum += lastNElements[i];
}


Console.WriteLine($"{sum / cutList:f2}");