/*
 8. Basketball equipment

    Jesse decides he wants to play basketball, but he needs equipment to train. Write a program that calculates the expenses of Jesse if he starts training, 
    knowing how much is the fee for basketball training for a period of 1 year.
    • Basketball sneakers – their price is 40% less than the fee for one year
    • Basketball team – its price is 20% cheaper than that of sneakers
    • Basketball – its price is 1 / 4 of the price of the basketball team
    • Basketball accessories – their price is 1 / 5 of the price of the basketball

    Input
    From the console read 1 row:
    · The annual basketball training fee – an integer in the range [0... 9999]
    Output
    Print on the console how much Jesse will spend if he starts playing basketball.

    Example Input/Output 
  Input 365

 Output 811.76
        Price of training per year: 365
        Price of basketball sneakers: 365 – 40% = 219
        Price per basketball team: 219 – 20% = 175.20
        Price of basketball: 1 / 4 from 175.20 = 43.80
        Price of basketball accessories: 1 / 5 from 43.80 = 8.76
        Total price for the equipment: 365 + 219 + 175.20 + 43.80 + 8.76 = 811.76

 Input 550

 Output 1223.2
        Price of training per year: 550
        Price of basketball sneakers: 550 – 40% = 330
        Price per basketball team: 330 – 20% = 264
        Basketball price: 1/4 of 264 = 66
        Price of basketball accessories: 1 / 5 from 66 = 13.20
        Total price for the equipment: 550 + 330 + 264 + 66 + 13.20 = 1223.2

 */

int trainingFee = int.Parse(Console.ReadLine());

//Price of training per year: 365
//Price of basketball sneakers: 365 – 40 % = 219

//double sneakers = trainingFee * 0.6;
double sneakers = trainingFee - (trainingFee * 0.4);

//Price per basketball team: 219 – 20 % = 175.20

//double team = sneakers * 0.8;
double team = sneakers - (sneakers * 0.2);

//Price of basketball: 1 / 4 from 175.20 = 43.80

double basketball = team * 0.25;

//Price of basketball accessories: 1 / 5 from 43.80 = 8.76

double accessories = basketball * 0.2;

//Total price for the equipment: 365 + 219 + 175.20 + 43.80 + 8.76 = 811.76

double TotalCost = trainingFee + sneakers + team + basketball + accessories;

Console.WriteLine(TotalCost);