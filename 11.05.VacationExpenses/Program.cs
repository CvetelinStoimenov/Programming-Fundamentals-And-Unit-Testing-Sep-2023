/*
5.Vacation Expenses
Write a program, which calculates vacation expenses:
•	From the console read: season(string), accommodation type(string) and count of the days (integer)
    o Season will be one of the following: "Spring", "Summer", "Autumn" and "Winter"
    o	Accommodation type will be one of the following: "Hotel" and "Camping
•	Based on the table below, you have to calculate expenses for the vacation with the given accommodation type, season and count of the days. 
•	For the calculation: use price per night (extracted from the table below) multiplied by count of the days.
•	Print the total expenses, formatted to the second digit after the decimal point

Season      Hotel       Camping         Discount
Spring      30          10              20%
Summer      50          30              0%
Autumn      20          15              30%
Winter      40          10              10%
 
Example Input / Output

Input	        Output	                Comments
Winter	        180.00	                Season is Winter, accommodation type is Hotel
Hotel                                   Based on table, price per night is 40, and the discount is 10% or 0.10
5                                       Total expenses = 5 * 40 – 10% = 200 – 10% = 180.00



Input	        Output	                Comments
Summer	        300.00	                Season is Summer, accommodation type is Camping
Camping                                 Based on table, price per night is 30, and the discount is 0%
10                                      Total expenses = 10 * 30 = 300*/

string season = Console.ReadLine();
string type = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double cost = 0;

if (season == "Spring")
{
    if (type == "Hotel")
    {
        cost = 30 * days;
        cost = cost - (cost * 0.2);
        //cost = days * 30 * (1-0.20);
        //cost = days * 30 * 0.80;
    }
    else 
    {
        cost = 10 * days;
        cost = cost - (cost * 0.2);
    }
}
else if (season == "Summer")
{
    if (type == "Hotel")
    {
        cost = 50 * days;
    }
    else
    {
        cost = 30 * days;
    }
}
else if (season == "Autumn")
{
    if (type == "Hotel")
    {
        cost = 20 * days;
        cost = cost - (cost * 0.3);
    }
    else
    {
        cost = 15 * days;
        cost = cost - (cost * 0.3);
    }
}
else if (season == "Winter")
{
    if (type == "Hotel")
    {
        cost = 40 * days;
        cost = cost - (cost * 0.1);
    }
    else
    {
        cost = 10 * days;
        cost = cost - (cost * 0.1);
    }
}

Console.WriteLine($"{cost:f2}");