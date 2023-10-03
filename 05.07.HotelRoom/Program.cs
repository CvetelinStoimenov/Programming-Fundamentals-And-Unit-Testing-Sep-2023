/*
   7.Hotel room
A hotel provides 2 types of rooms, studio and apartment. Your task is to create a program that computes the total 
cost of a stay for both the studio and the apartment. The prices are determined by the month of the stay:

May and October	            June and September	            July and August
Studio – 50 BGN/night	    Studio – 75.20 BGN/night	    Studio – 76 BGN/night
Apartment – 65 BGN/night	Apartment – 68.70 BGN/night	    Apartment – 77 BGN/night

The following discounts are also available:

•	For a studio, for more than 7 nights in May and October: 5 % discount.
•	For a studio, for more than 14 nights in May and October: 30 % discount.
•	For a studio, for more than 14 nights in June and September: 20 % discount.
•	For an apartment, for more than 14 nights, no matter the month: 10 % discount.

Input

The input is read from the console and contains exactly 2 lines entered by the user:

•	Month - string("May", "June", "July", "August", "September" or "October")
•	Count of nights - an integer in the range [1 ... 200]

Output

Print 2 lines on the console:

•	On the first line: " Apartment: {price for the entire stay} lv."
•	On the second line: " Studio: {price for the entire stay} lv."

The price for the entire stay formatted to the second decimal place.

Example Input/Output

Input	        Output	                    Comments
May             Apartment: 877.50 lv.
15	            Studio: 525.00 lv.          The month is May and the stay is more than 14 nights,
                                            so we reduce the price of the studio by 30% (50 – 15 = 35)
                                            and of the apartment - by 10% (65 - 6.5 = 58.5). 
                                            The whole stay in an apartment - 877.50 BGN
                                            The whole stay in a studio - 525.00 BGN


Input	        Output	                    Input	        Output
June	        Apartment: 961.80 lv.       August          Apartment: 1386.00 lv.
14              Studio: 1052.80 lv.         20              Studio: 1520.00 lv.*/

string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
double studio = 0;
double apartment = 0;

if (month == "May" || month == "October")
{
    studio = 50;
    apartment = 65;
    if (nights > 7 && nights <= 14)
    {
        studio = studio * 0.95;
    }
    else if (nights > 14)
    {
        studio = studio * 0.70;
        apartment = apartment * 0.90;
    }
}
else if (month == "June" || month == "September")
{
    studio = 75.20;
    apartment = 68.70;
    if (nights > 14)
    {
        studio = studio * 0.80;
        apartment = apartment * 0.90;
    }
}
else if (month == "July" || month == "August")
{
    studio = 76;
    apartment = 77;
    if (nights > 14)
    {
        apartment = apartment * 0.90;
    }
}

Console.WriteLine($"Apartment: {apartment * nights:f2} lv.");
Console.WriteLine($"Studio: {studio * nights:f2} lv.");

//Lector code:

switch (month)
{
    case "May":
    case "October":
        studio = 50;
        apartment = 65;
        break;
    case "June":
    case "September":
        studio = 75.20;
        apartment = 68.70;
        break;
    case "July":
    case "August":
        studio = 76;
        apartment = 77;
        break;
}

double studioPrice = studio * nights;
double apartmentPrice = apartment * nights;

if (nights > 14)
{
    if (month == "May" || month == "October")
    {
        studioPrice *= 0.7;
    }
    else if (month == "June" || month == "September")
    {
        studioPrice *= 0.8;
    }
    apartmentPrice *= 0.9;
}
else if (nights >= 7 && (month == "May" || month == "October"))
{
    studioPrice *= 0.95;
}

Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {studioPrice:f2} lv.");