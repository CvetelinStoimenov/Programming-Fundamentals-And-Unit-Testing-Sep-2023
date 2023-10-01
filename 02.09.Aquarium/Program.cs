/*
 9. Aquarium

    For his birthday, Lyubomir received an aquarium in the shape of a parallelepiped. Initially, 
    we read from the console in separate rows its dimensions – length, width and height in centimeters. 
    It is necessary to calculate how many liters of water the aquarium will collect, 
    if it is known that a certain percentage of its capacity is occupied by sand, plants, heater and pump.

    One liter of water is equal to one cubic decimeter (1 l = 1 dm3).
    Write a program that calculates the liters of water that are needed to fill the aquarium.
    Input
    From the console read 4 lines:
    1. Length in cm – an integer number in the range [10 ... 500]
    2. Width in cm – an integer number in the range [10 ... 300]
    3. Height in cm – an integer number in the range [10... 200]
    4. Percentage – floating point number in the range [0.000 ... 100.000]

    Output
    Print one number on the console:
    · the liters of water that the aquarium will collect, rounded to the second decimal place.
    Example Input/Output 

Input 85
      75
      47
      17

 Output 248.69
        Volume of the aquarium: 85 * 75 * 47 = 299625 cm3
        Volume in liters: 299625 * 0.001 or 299625 / 1000 => 299.625 liters
        Occupied space: 17% = 0.17
        Required liters: 299.625 * (1 - 0.17) = 248.68875 liters

Input 105
      77
      89
      18.5

 Output 586.45
        Volume of the aquarium: 105 * 77 * 89 = 719565 cm3
        Volume in liters: 719565 * 0.001 or 719565 / 1000 => 719.565 liters
        Occupied space: 18.5% = 0.185
        Required liters: 719.565 * (1 - 0.185) = 586.445475 liters

 */


int Length = int.Parse(Console.ReadLine());
int Width = int.Parse(Console.ReadLine());
int Height = int.Parse(Console.ReadLine());
float Percentage = float.Parse(Console.ReadLine());

//Volume of the aquarium: 85 * 75 * 47 = 299625 cm3

double aquariumVol = Length * Width * Height;

//Volume in liters: 299625 * 0.001 or 299625 / 1000 => 299.625 liters

double VolLiters = aquariumVol / 1000;

//Occupied space: 17 % = 0.17

double OccupiedSpace = Percentage / 100;

//Required liters: 299.625 * (1 - 0.17) = 248.68875 liters

double Requiredliters = VolLiters * (1 - OccupiedSpace);

Console.WriteLine("{0:0.00}", Requiredliters);