/*
 2.	Middle Elements
Write a program that:
    •	Reads an array of integer numbers from the console, separated by single space
    •	Array length will always be even number.
    •	Calculate the average value of the elements in the middle of the array
    •	Print the result formatted to the second digit

Example Input / Output

Input	                Output	    Comments
3 4 6 7 8 9             6.5         Middle elements are: 6 and 7
                                    Average value: (6 + 7) / 2 = 13 / 2 = 6.50

Input	                Output	    Comments
12 34 98 42 65 12       70.00       Middle elements are: 98 and 42
                                    Average value: (98 + 42) / 2 = 140 / 2 = 70*/

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int firstDigit = numbers[numbers.Count / 2 - 1];
int secondDigit = numbers[numbers.Count / 2]; 
double result = Math.Abs((firstDigit + secondDigit) / 2.0);

Console.WriteLine($"{ result:f2}");
