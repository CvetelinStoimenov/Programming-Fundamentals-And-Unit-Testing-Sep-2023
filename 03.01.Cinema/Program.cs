/*1. Cinema
    In a cinema hall, the chairs are arranged in a rectangular shape with r-rows and c-columns. There are three types of screenings with tickets at different prices:
        · Premiere – premiere screening, at a price of 12.00 leva.
        · Normal – standard screening, at a price of 7.50 leva.
        · Discount – screening for children and students at a reduced price of 5.00 leva.
    Write a program that reads the type of screening (string), the number of rows and the number of columns in the hall (integers) entered by the user,
    and calculates the total ticket revenue at a full hall. The result should be presented in a format similar to the examples provided, showing 2 decimal places.

    Example Input/Output

Input Premiere
      10
      12

 Output 1440.00 leva

Input Normal
      21
      13

 Output 2047.50 leva

Input Discount
      12
      30

 Output 1800.00 leva

* Hint: To ensure the result is displayed with precisely two decimal places, use the following syntax: Console.WriteLine("{0:f2} leva", income).
*/

//Guidelines
//1.Read the input from the console.

string screening = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

//2.Create an income variable of type "double" with an initial value of zero

double income = 0.00;

//3.Make a series of checks, assigning the corresponding price to the variable "income" for each type of screening("Premiere, Normal, Discount"),
//and finally print the result. 

if (screening == "Premiere")
{
    income = rows * columns * 12.00;
}
else if (screening == "Normal")
{
    income = rows * columns * 7.50;
}
else if (screening == "Discount")
{
    income = rows * columns * 5;
}

Console.WriteLine($"{income:f2} leva");