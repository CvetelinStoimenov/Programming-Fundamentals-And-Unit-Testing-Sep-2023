/*
5.	Equal Arrays
Write a program that:
    •	Read two arrays with the same length from the console
    •	Check whether they are identical or not
        o	If the arrays are identical, print: "Arrays are identical."
        o	If the arrays are NOT identical, print: "Arrays are not identical."
Note: Arrays are identical if their elements are equal. 

Example Input / Output

Input	    Output
10 20 30    Arrays are identical.
10 20 30


1 2 3 4 5   Arrays are not identical.
1 2 4 3 5

1           Arrays are not identical.
10*/

int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
bool isIdentical = true;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != secondArray[i])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
    isIdentical = true;
}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}