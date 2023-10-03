/*4.Fishing Boat
Tony and his friends were passionate about fishing. They were so enthusiastic about it that they opted to go fishing by boat. 
The rental cost of the boat depends on both the season and the number of fishermen.
The price depends on the season:

•	The price for renting the boat in the spring is 3000 BGN.
•	The price for renting the boat in the summer and autumn is 4200 BGN.
•	The price for renting the boat in winter is 2600 BGN.

The group receives a discount based on the number of people.

•	If the group is up to 6 people including – a discount of 10%.
•	If the group is from 7 to 11 people – a discount of 15%.
•	If the group is from 12 people and more – a discount of 25%. 

Furthermore, the fishermen receive an extra 5% discount if the total count of fishermen is even. This additional 
discount is applied after deducting the discounts mentioned above, except during the autumn season. 
In autumn, this extra discount does not apply.
Write a program to calculate whether the fishermen will be able to gather enough money for the fishing trip. 

Input

You will have to read three values from the Console:

•	Group Budget - integer in the range [1... 8000]
•	Season - string: "Spring", "Summer", "Autumn", "Winter"
•	Fishermen Count - integer in the range [4... 18]

Output

The result should be printed on the Console on a single line:

•	If the budget is sufficient:
"Yes! You have {moneyLeft} leva left."

•	If the budget is not enough:
"Not enough money! You need {moreMoney} leva."

The value of the currency must be formatted to the second decimal place.
 
Example Input/Output

Input		Output						Comments

3000		Not enough money!			During the summer season, the fishing tourism expense is 4200 BGN
Summer		You need 570.00 leva.		With 11 fishermen, a 15% discount is applied, resulting in a cost of 3570 BGN
11										(4200 - 15% = 3570 BGN). Since the number of fishermen is odd,
										no additional discount is applied. As 3000 BGN is less than 3570 BGN,
										there is a shortage of 570.00 BGN.

Input		Output						Input			Output

3600		Not enough money!			2000			Yes! You have 50.00 leva left.
Autumn		You need 180.00 leva.		Winter
6										13
*/

int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermenCount = int.Parse(Console.ReadLine());
double costBoat = 0;

if (season == "Spring")
{
	costBoat = 3000;
	if (fishermenCount <= 6)
	{
		costBoat = costBoat * 0.9;

	}
	else if (fishermenCount >= 7 && fishermenCount <= 11)
	{
		costBoat = costBoat * 0.85;
	}
	else
	{
        costBoat = costBoat * 0.75;
    }
}
else if (season == "Summer" || season == "Autumn")
{
	costBoat = 4200;
    if (fishermenCount <= 6)
    {
        costBoat = costBoat * 0.9;

    }
    else if (fishermenCount >= 7 && fishermenCount <= 11)
    {
        costBoat = costBoat * 0.85;
    }
    else
    {
        costBoat = costBoat * 0.75;
    }
}
else if (season == "Winter")
{
    costBoat = 2600;
    if (fishermenCount <= 6)
    {
        costBoat = costBoat * 0.9;

    }
    else if (fishermenCount >= 7 && fishermenCount <= 11)
    {
        costBoat = costBoat * 0.85;
    }
    else
    {
        costBoat = costBoat * 0.75;
    }
}

if (fishermenCount % 2 == 0 && season != "Autumn")
{
    costBoat = costBoat * 0.95;
}

if (budget >= costBoat)
{
    Console.WriteLine($"Yes! You have {budget - costBoat:f2} leva left.");
}
else 
{
    Console.WriteLine($"Not enough money! You need {costBoat - budget:f2} leva.");
}

//Lector code:


switch (season)
{
    case "Spring": costBoat = 3000; break;
    case "Summer":
    case "Autumn": costBoat = 4200; break;
    case "Winter": costBoat = 2600; break;
}

if (fishermenCount <= 6)
{
    costBoat = costBoat * 0.9;
}
else if (fishermenCount >= 7 && fishermenCount <= 11)
{
    costBoat = costBoat * 0.85;
}
else if (fishermenCount >= 12)
{
    costBoat = costBoat * 0.75;
}

if (fishermenCount % 2 == 0 && season != "Autumn")
{
    costBoat = costBoat * 0.95;
}

if (budget >= costBoat)
{
    Console.WriteLine($"Yes! You have {budget - costBoat:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {costBoat - budget:f2} leva.");
}