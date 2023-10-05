/*
5.	Numbers From 1 to N over 3
Write a program that prints numbers in given range over 3: 
    •	Reads an integer number n – end of the range
    •	Prints all numbers from 1 to n, over 3 (inclusively)
    
Example Input / Output

Input	Output		Input	Output		Input	Output
10	    1           17      1           20      1
        4                   4                   4
        7                   7                   7
        10                  10                  10
                            13                  13  
                            16                  16
                                                19
*/
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i += 3)
{
    Console.WriteLine(i);
}

//int i = 1;

//while (i <= n)
//{
//    Console.WriteLine(i);
//    i += 3;
//}