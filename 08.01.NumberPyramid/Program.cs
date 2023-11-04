/*
 Write a program that reads a whole number n entered by the user and prints a pyramid of numbers as shown in the examples:

Input	Output
7	    1
        2 3
        4 5 6
        7

Input	Output
10	    1
        2 3
        4 5 6
        7 8 9 10

Input	Output
12	    1
        2 3
        4 5 6
        7 8 9 10
        11 12

Input	Output
15	    1
        2 3
        4 5 6
        7 8 9 10
        11 12 13 14 15*/

int pyramidCount = int.Parse(Console.ReadLine() ?? "0");

int current = 1;
bool isBiger = false;

for (int rows = 1; rows <= pyramidCount; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        if (current > pyramidCount)
        { 
            isBiger = true;
            break;
        }
        Console.Write(current + " ");
        current++;
    }
    if (isBiger)
    {
        break;
    }
    Console.WriteLine();
}

//Lector code 1:
int n = int.Parse(Console.ReadLine() ?? "0"); // the number from the input

int row = 1; // the row we're curently printing
for (int cur = 1; cur <= n;) // let's process all numbers
{
    for (int print = 0; print < row && cur <= n; print++) // we print the current row either if the row finishes, OR if the row goes after `n`
        Console.Write($"{cur++} "); // print the current number, increase it AFTER the printing

    Console.WriteLine(); // finish the line
    row++;
}

//Lector code 2:

int n1 = int.Parse(Console.ReadLine() ?? "0"); // the number from the input

int row1 = 1;
int curRow = 0;
for (int cur = 1; cur <= n1; cur++)
{
    Console.Write(cur + " ");

    curRow++;

    if (curRow >= row1)
    {
        Console.WriteLine();
        row++;
        curRow = 0;
    }
}

//Lector ode 3:


int n2 = int.Parse(Console.ReadLine() ?? "0"); // the number from the input

int current1 = 1; // we start with `1`, and go until `n`, inclusive
bool isBigger = false; // the indication for the end of the whole processing

// let's start printing out rows
for (int rows = 1; rows <= n2; rows++)
{
    // for each row, we print "rows" numbers
    // row 1 -> 1 number, "1 " 
    // row 2 -> 2 numbers, "2 3 "
    // row 3 -> 3 numbers, "4 5 6 ", ......
    for (int cols = 1; cols <= rows; cols++)
    {
        // check if we printed out all `n` numbers!
        if (current1 > n2)
        {
            // we're done!
            isBigger = true;
            break; // get out of the nested cycle for `cols`
        }
        Console.Write(current1 + " "); // print the number, add a space after it
        current1++; // let's go to the next number
    }

    // the nested cycle indicated that we're done!
    if (isBigger)
        break; // get out of the main cycle, too

    Console.WriteLine(); // finish the new line from the previous cycle
}

//Lector code 4:

int n3 = int.Parse(Console.ReadLine() ?? "0");

int current3 = 1;
bool isBigger3 = false;
for (int rows = 1; rows <= n3; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        if (current3 > n3)
        {
            isBigger3 = true;
            break;
        }

        Console.Write(current3 + " ");
        current3++;
    }

    Console.WriteLine();
    if (isBigger3)
        break;
}