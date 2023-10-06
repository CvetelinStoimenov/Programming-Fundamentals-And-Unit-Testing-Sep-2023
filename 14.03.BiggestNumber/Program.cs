/*
 3.	Biggest Number
Write a program to find the biggest among given n numbers:
    •	Read an integer number n (the amount of input numbers) and n integer numbers from the console
    •	Find and print the biggest number

Example Input / Output

Input	Output
3       90
40
90
50

Input	Output
4       -3
-40
-3
-90
-50	

Input	Output
2		7
1
7
*/

int n = int.Parse(Console.ReadLine());
int maxNum = int.MinValue;

for (int i = 0; i < n; i++)
{
    int compNum = int.Parse(Console.ReadLine());
    if (compNum > maxNum)
    {
        maxNum = compNum;
    }
}

Console.WriteLine(maxNum);

//while (n > 0)
//{
//    int compNum = int.Parse(Console.ReadLine());
//    if (compNum > maxNum)
//    {
//        maxNum = compNum;
//    }
//    n--;
//}