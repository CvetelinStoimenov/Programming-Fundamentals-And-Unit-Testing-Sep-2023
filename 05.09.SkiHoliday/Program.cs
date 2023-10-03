/*
9.Ski Holiday

Atanas decided to spend his vacation in Bansko and go skiing. Before he goes, however, 
he must book a hotel and calculate how much his stay will cost. The following types of accommodation are available, 
each with its corresponding prices for stay:
    	"room for one person" - 118.00 BGN per night
    	"apartment" - 155.00 BGN per night 
    	"President Apartment" – 235.00 BGN per night

Based on the number of days he plans to stay in the hotel (example: 11 days = 10 nights) and the type of room he chooses,
he may be eligible for various discounts. 

The available reductions are as follows:

type of room	        Less than 10 days	        between 10 and 15 days inclusive	    more than 15 days
room for one person	    does not use a discount	    does not use a discount	                does not use a discount
apartment	            30% of the final price	    35% of the final price	                50% of the final price
president apartment	    10% of the final price	    15% of the final price	                20% of the final price

After the stay, Atanas' assessment of the hotel's services can be positive or negative.  
If his assessment is "positive", Atanas adds 25% of it to the price with the already deducted discount. 
If his assessment is "negative", he deducts 10% from the price. 

Input

The input is read from the console and consists of three lines:
    •	First line   - days to stay - integer in the range [0...365]
    •	Second line – type of room - "room for one person", "apartment" or "president apartment"
    •	Third line - assessment - "positive" or "negative"

Output

One line should be printed as an output, on the console:
    •	The price for his stay at the hotel, formatted to the second decimal place.

Example Input/Output

Entrance	            Exit	                Comments
14	                    1637.19	                14 days => 13 nights => 13 * 155.00 = 2015 BGN
apartment                                       10 < 13 nights < 15 => 2015 – 35%= 1309.75 BGN
positive                                        The assessment is positive => 1309.75 + 25% = 1637.1875 -> 1637.19 BGN


Entrance	            Exit	    Entrance	            Exit	    Entrance	Exit
30	                    4906.80	    12	                    1622.50	    2	        135.62
president apartment                 room for one person                 apartment
negative                            positive                            positive*/

int daysToStay = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string assessment = Console.ReadLine();
double totalCost = 0;
int nights = daysToStay - 1;

if (typeOfRoom == "room for one person")
{
        totalCost = nights * 118.00;
}
else if (typeOfRoom == "apartment")
{
    if (daysToStay < 10)
    {
        totalCost = (nights * 155.00) * 0.7;
    }
    else if (daysToStay >= 10 && daysToStay <= 15)
    {
        totalCost = (nights * 155.00) * 0.65;
    }
    else
    {
        totalCost = (nights * 155.00) * 0.5;
    }
}
else if (typeOfRoom == "president apartment")
{
    if (daysToStay < 10)
    {
        totalCost = (nights * 235.00) * 0.9;
    }
    else if (daysToStay >= 10 && daysToStay <= 15)
    {
        totalCost = (nights * 235.00) * 0.85;
    }
    else
    {
        totalCost = (nights * 235.00) * 0.8;
    }
}

if (assessment == "positive")
{
    totalCost = totalCost * 1.25;
}
else
{
    totalCost = totalCost * 0.9;
}

Console.WriteLine($"{totalCost:f2}");

//Lector code:
//int daysToStay = int.Parse(Console.ReadLine());
//string typeOfRoom = Console.ReadLine();
//string assessment = Console.ReadLine();
//double basePrice = 0;

//switch (typeOfRoom)
//{
//    case "room for one person":
//        basePrice = (daysToStay - 1) * 118.0;
//        break;
//    case "apartment":
//        basePrice = (daysToStay - 1) * 155.00;
//        if (daysToStay < 10)
//        {
//            basePrice *= 0.7;
//        }
//        else if (daysToStay >= 10 && daysToStay < 15)
//        {
//            basePrice *= 0.65;
//        }
//        else
//        {
//            basePrice *= 0.5;
//        }
//        break;
//    case "president apartment":
//        basePrice = (daysToStay - 1) * 235.00;
//        if (daysToStay < 10)
//        {
//            basePrice *= 0.9;
//        }
//        else if (daysToStay >= 10 && daysToStay < 15)
//        {
//            basePrice *= 0.85;
//        }
//        else
//        {
//            basePrice *= 0.8;
//        }
//        break;
//}

//if (assessment == "positive")
//{
//    basePrice *= 1.25;
//}
//else if (assessment == "negative")
//{
//    basePrice *= 0.9;
//}

//Console.WriteLine($"{basePrice:f2}");
