/*
 9.	Orders
Write a program that:
    •	Reads a string on the first line from the console, representing a product - "coffee",  "water", "coke" or "snacks"
    •	Reads an integer on the second line from the console, representing the quantity of the product
    •	Create a method that calculates and prints the total price of an order
    •	The method should receive two parameters: product and quantity
    •	The prices for a single item of each product are:
        	coffee – 1.50
        	water – 1.00
        	coke – 1.40
        	snacks – 2.00
    •	Print the result, rounded to the second decimal place

Example Input / Output

Input	Output		Input	Output		Input	Output
water   5.00        coffee  3.00        snacks  12
5                   2                   6

*/
static double GetOrdersSum(string product, int quantity, double sum)
{
    if (product == "coffee")
    {
        sum = quantity * 1.50;
    }
    else if (product == "water")
    {
        sum = quantity * 1.00;
    }
    else if (product == "coke")
    {
        sum = quantity * 1.40;
    }
    else if (product == "snacks")
    {
        sum = quantity * 2.00;
    }

    return sum;
}
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double sum = 0;

sum = GetOrdersSum(product, quantity, sum);

Console.WriteLine($"{sum:f2}");
