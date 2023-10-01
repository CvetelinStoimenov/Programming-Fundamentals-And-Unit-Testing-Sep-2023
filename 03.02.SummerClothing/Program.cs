/*2.Summer Clothing
Summer weather can be quite unpredictable, and Victor needs your assistance.Write a program that, 
based on the time of day and the temperature, recommends to Victor what clothes to wear. 
Your friend has different plans for each stage of the day that require varied clothing, as indicated in the table.
Two lines are read from the console:
· Temperature - an integer in the range[10... 42]
· Text, time of day - with possibilities - "Morning", "Afternoon", "Evening"

Time of day / degrees                       Morning                         Afternoon                   Evening

    10 <= temperature <= 18               Clothing = Sweatshirt             Clothing = Shirt            Clothing = Shirt
                                          Shoes = Sneakers                  Shoes = Moccasins           Shoes = Moccasins

    18 < temperature <= 24                Clothing = Shirt                  Clothing = T-Shirt          Clothing = Shirt
                                          Shoes = Moccasins                 Shoes = Sandals             Shoes = Moccasins

    temperature >= 25                     Clothing = T-Shirt                Clothing = Swim             Clothing = Shirt
                                          Shoes = Sandals                   Suit Shoes = Barefoot       Shoes = Moccasin

Print on the console on a single line: "It's {temperature} degrees, get your {clothing} and {shoes}."

Example Input/Output

Input 16
      Morning

Output It's 16 degrees, get your Sweatshirt and Sneakers.

                        In the morning, when the degrees are 16, 
                        Victor takes a sweatshirt and sneakers.

Input 22
      Afternoon

Output It's 22 degrees, get your T-Shirt and Sandals.

Input 28
      Evening

Output It's 28 degrees, get your Shirt and Moccasins.
*/

int temperature = int.Parse(Console.ReadLine());
string TimeOfDay = Console.ReadLine();

if (TimeOfDay == "Evening")
{
    Console.WriteLine("It's " + temperature + " degrees, get your Shirt and Moccasins.");
}
else if (temperature >= 10 && temperature <= 18)
{
    if (TimeOfDay == "Morning")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Sweatshirt and Sneakers.");
    }
    else if (TimeOfDay == "Afternoon")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Shirt and Moccasins.");
    }
}
else if (temperature > 18 && temperature <= 24)
{
    if (TimeOfDay == "Morning")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Shirt and Moccasins.");
    }
    else if (TimeOfDay == "Afternoon")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your T-Shirt and Sandals.");
    }
}
else if (temperature >= 25)
{
    if (TimeOfDay == "Morning")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your T-Shirt and Sandals.");
    }
    else if (TimeOfDay == "Afternoon")
    {
        Console.WriteLine("It's " + temperature + " degrees, get your Swim Suit and Barefoot.");
    }
}
                    /* chatGPT code
                     
                    using System;

                    namespace _02.SummerClothing
                    {
                        internal class Program
                        {
                            static void Main(string[] args)
                            {
                                int temperature = int.Parse(Console.ReadLine());
                                string timeOfDay = Console.ReadLine();

                                string clothing = "";
                                string shoes = "";

                                if (timeOfDay == "Evening")
                                {
                                    clothing = "Shirt";
                                    shoes = "Moccasins";
                                }
                                else if (temperature >= 10 && temperature <= 18)
                                {
                                    if (timeOfDay == "Morning")
                                    {
                                        clothing = "Sweatshirt";
                                        shoes = "Sneakers";
                                    }
                                    else if (timeOfDay == "Afternoon")
                                    {
                                        clothing = "Shirt";
                                        shoes = "Moccasins";
                                    }
                                }
                                else if (temperature > 18 && temperature <= 24)
                                {
                                    if (timeOfDay == "Morning")
                                    {
                                        clothing = "Shirt";
                                        shoes = "Moccasins";
                                    }
                                    else if (timeOfDay == "Afternoon")
                                    {
                                        clothing = "T-Shirt";
                                        shoes = "Sandals";
                                    }
                                }
                                else if (temperature >= 25)
                                {
                                    if (timeOfDay == "Morning")
                                    {
                                        clothing = "T-Shirt";
                                        shoes = "Sandals";
                                    }
                                    else if (timeOfDay == "Afternoon")
                                    {
                                        clothing = "Swim Suit";
                                        shoes = "Barefoot";
                                    }
                                }

                                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
                            }
                        }
                    }
                    */