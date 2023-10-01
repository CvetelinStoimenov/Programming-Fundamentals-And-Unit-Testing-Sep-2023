/*
3. New Home

    Martin and Nelly are buying a new house not far from Sofia. 
Nelly loves flowers so much that she convinces you to write a program to calculate how much it will cost them, 
to plant a certain number of flowers and whether the available budget will be enough for them. Different flowers come at different prices.

Flower                          Roses       Dahlias         Tulips      Narcissus       Gladiolus
Price per piece in BGN          5           3.80            2.80        3               2.50

The following discounts exist:

· If Nelly buys more than 80 Roses - 10% discount from the final price;
· If Nelly buys more than 90 Dahlias - 15% discount from the final price;
· If Nelly buys more than 80 Tulips - 15% discount from the final price;
· If Nelly buys less than 120 Narcissus - the price is increased by 15%;
· If Nelly buys less than 80 Gladiolus - the price in increased by 20%;

Three lines should be read from the console:
· Type of flowers - text with options - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
· Flowers count - an integer in the range [10... 1000]
· Budget - an integer in the range [50... 2500]

Print the result on the console on a single line:
· If their budget is enough - "Hey, you have a great garden with {flowersCount} {flowersType} and {sumLeft} leva left."
· If their budget is NOT enough, "Not enough money, you need {neededMoney} leva more."
The sum should be formatted to the second decimal place.

Example Input/Output

Input               Output                                  Comments

Roses               Not enough money, you need 25.00        Nelly wants 55 Roses. The price of one rose is 5 BGN, 
55                  leva more.                              therefore for 55 pieces Nelly will have to pay: 55 * 5 = 275.
250                                                         However, she has a 250 leva budget. Because 275 > 250, she is short of 25 leva.


Input               Output 

Tulips
88                  Hey, you have a great garden with 
260                 88 Tulips and 50.56 leva left.

Input               Output
Narcissus           Not enough money, you need
119                 50.55 leva more.
360
 */

string typeOfFlowers = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double sum = 0;

if (typeOfFlowers == "Roses")
{
    sum = flowersCount * 5.0;
    if (flowersCount > 80)
    {
        sum *= 0.9;
    }

}
else if (typeOfFlowers == "Dahlias")
{
    sum = flowersCount * 3.8;
    if (flowersCount > 90)
    {
        sum *= 0.85;
    }
}

else if (typeOfFlowers == "Tulips")
{
    sum = flowersCount * 2.8;
    if (flowersCount > 80)
    {
        sum *= 0.85;
    }
}

else if (typeOfFlowers == "Narcissus")
{
    sum = flowersCount * 3.0;
    if (flowersCount < 120)
    {
        sum *= 1.15;
    }
}

else if (typeOfFlowers == "Gladiolus")
{
    sum = flowersCount * 2.5;
    if (flowersCount < 80)
    {
        sum *= 1.2;
    }
}

if (sum <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeOfFlowers} and {budget - sum:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
}
/* ChatGPT code:
 string typeOfFlowers = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double sum = 0;

switch (typeOfFlowers)
{
case "Roses":
sum = flowersCount * 5.00;
if (flowersCount > 80)
{
sum *= 0.90; // Apply a 10% discount
}
break;
case "Dahlias":
sum = flowersCount * 3.80;
if (flowersCount > 90)
{
sum *= 0.85; // Apply a 15% discount
}
break;
case "Tulips":
sum = flowersCount * 2.80;
if (flowersCount > 80)
{
sum *= 0.85; // Apply a 15% discount
}
break;
case "Narcissus":
sum = flowersCount * 3.00;
if (flowersCount < 120)
{
sum *= 1.15; // Increase the price by 15%
}
break;
case "Gladiolus":
sum = flowersCount * 2.50;
if (flowersCount < 80)
{
sum *= 1.20; // Increase the price by 20%
}
break;
}

if (sum <= budget)
{
Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeOfFlowers} and {budget - sum:f2} leva left.");
}
else
{
Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
}
*/