/*
4.	Numbers Ending in 7
Write a program that prints numbers ending in 7 in given range: 
    •	Reads an integer number n – end of the range
    •	Prints all numbers from 7 to n, ending in 7

Example Input / Output

Input	Output		Input	Output		Input	Output
27  	7   		40	    7           50      7
        17                  17                  17
        27                  27                  27
                            37                  37
                                                47*/

int n = int.Parse(Console.ReadLine());

for (int i = 7; i <= n; i += 10)
{
    Console.WriteLine(i);
}

//int i = 7;

//while (i <= n)
//{
//    Console.WriteLine(i);
//    i += 10;
//}