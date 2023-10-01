/*
 The restaurant opens its doors and offers several menus at preferential prices:
• Chicken menu – 10.35 lv.
• Menu with fish – 12.40 lv.
• Vegetarian menu – 8.15 lv.

Write a program that calculates how much it will cost a group of people to order takeaways.
The group will also order a dessert, the price of which is equal to 20% of the total bill (excluding delivery).
The delivery price is 2.50 BGN and is finally charged.

Input
From the console read 3 lines:
· Number of chicken menus – integer in the range [0 ... 99]
· Number of menus with fish – integer in the range [0 ... 99]
· Number of vegetarian menus – an integer in the range [0 ... 99]

Output
Print out only one line on the console: "{order price}"
Example Input/Output

  Input 2
        4
        3

 Output 116.2
        Price for chicken menus: 2 pieces * 10.35 = 20.70
        Price for the menus with fish: 4 pieces * 12.40 = 49.60
        Price for vegetarian menus: 3 pieces * 8.15 = 24.45
        Total cost of menus: 20.70 + 49.60 + 24.45 = 94.75 
        Price of dessert: 20% from 94.75 = 18.95
        Delivery price: 2.50 (conditional)
        Total order price: 94.75 + 18.95 + 2.50 = 116.20

  Input 9
        2
        6

 Output 202.72
        Price for chicken menus: 9 pieces * 10.35 = 93.15
        Price for fish menus: 2 pieces * 12.40 = 24.80
        Price for vegetarian menus: 6 pieces * 8.15 = 48.90
        Total cost of menus: 93.15 + 24.80 + 48.90 = 166.85 
        Price of dessert: 20% from 166.85 = 33.37
        Delivery price: 2.50 (conditional)
        Total order price: 166.85 + 33.37 + 2.50 = 202.72

 */

int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegeMenus = int.Parse(Console.ReadLine());

//Price for chicken menus: 9 pieces * 10.35 = 93.15

double chickenMenusPrice = chickenMenus * 10.35;

//Price for fish menus: 2 pieces * 12.40 = 24.80

double fishMenusPrice = fishMenus * 12.40;

//Price for vegetarian menus: 6 pieces * 8.15 = 48.90

double vegeMenusPrice = vegeMenus * 8.15;

//Total cost of menus: 93.15 + 24.80 + 48.90 = 166.85

double TotalMenuCost = chickenMenusPrice + fishMenusPrice + vegeMenusPrice;

//Price of dessert: 20 % from 166.85 = 33.37

double dessertPrice = TotalMenuCost * 0.2;

//Delivery price: 2.50(conditional)

//Total order price: 166.85 + 33.37 + 2.50 = 202.72

double TotalCost = TotalMenuCost + dessertPrice + 2.5;


Console.WriteLine(TotalCost);