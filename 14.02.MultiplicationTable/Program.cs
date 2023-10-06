/*
 2.	Multiplication Table
Write a program that prints a multiplication table:
    •	Reads an integer number n from the console
    •	Print a multiplication table of size 10 for given integer n in the following format:
                  "{n} x {i} = {result}" for each i in the range [1…10]

Example Input / Output

Input	Output
2       2 x 1 = 2
        2 x 2 = 4
        2 x 3 = 6
        2 x 4 = 8
        2 x 5 = 10
        2 x 6 = 12
        2 x 7 = 14
        2 x 8 = 16
        2 x 9 = 18
        2 x 10 = 20

Input	Output
3       3 x 1 = 3
        3 x 2 = 6
        3 x 3 = 9
        3 x 4 = 12
        3 x 5 = 15
        3 x 6 = 18
        3 x 7 = 21
        3 x 8 = 24
        3 x 9 = 27
        3 x 10 = 30

Input	Output
5       5 x 1 = 5
        5 x 2 = 10
        5 x 3 = 15
        5 x 4 = 20
        5 x 5 = 25
        5 x 6 = 30
        5 x 7 = 35
        5 x 8 = 40
        5 x 9 = 45
        5 x 10 = 50*/
int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
    int result = n * i;
    Console.WriteLine($"{n} x {i} = {result}");
    }