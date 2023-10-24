/*
5.	Vacation Savings
Jessie has decided to save money for a vacation and she wants your help to determine if she will 
manage to save the required amount. Every day she either saves or spends a portion of her money. 
If she wants to spend more than she currently has, she will spend all of her money and end up with 0 leva.

Input
Read from the console:
    •	The money needed for the vacation - a real number in the range [1.00...25000.00]
    •	Available money - a real number in the range [0.00...25000.00]
    •	Then repeatedly read two lines:
        o	Action type - a text with options "spend" and "save"
        o	Amount to save / spend - a real number in the range [0.01… 25000.00]

Output
The program should end in the following cases:
    •	If for 5 consecutive days Jessie only spends money, the console output should be:
        o	"You can't save the money."
        o	"{Total number of days passed}"
    •	If Jessie saves enough money for the vacation, console outputs:
        o	"You saved the money for {total number of days passed} days."

Example Input and Output

Input	Output
2000    You saved the money for 2 days.
1000
spend
1200
save
2000

Comments
Money Needed for the Vacation: 2000
Available Money: 1000
spend - subtract the next number from the available money
            (1000 - 1200 = -200, which is less than 0
               => available money= 0)
        ~ consecutive days of spending = 1
        - total days: 1
save - add the next number to the available money
           (0 + 2000 = 2000)
        ~ consecutive days of spending = 0
        - total days: 2
Available Money (2000) >= Money Needed for the Vacation (2000)

Input	Output
110     You can't save the money. 5
60
spend
10
spend
10
spend
10
spend
10
spend
10


Comments
Money Needed for the Vacation: 110
Available Money: 60
spend – subtract the next number from the available money (60 - 10 = 50)
        ~ consecutive days of spending = 1
         - total days: 1
spend – subtract the next number from the available money (50 - 10 = 40)
        ~ consecutive days of spending = 2
         - total days: 2
spend – subtract the next number from the available money (40 - 10 = 30)
        ~ consecutive days of spending = 3
         - total days: 3
spend – subtract the next number from the available money (30 - 10 = 20)
        ~ consecutive days of spending = 4
         - total days: 4
spend – subtract the next number from the available money (20 - 10 = 10)
        ~ consecutive days of spending = 5
        - total days: 5
5 consecutive days of spending => available money: 10
Available Money (10) < Money Needed for the Vacation (110)

Input	Output
250     You saved the money for 4 days.
150
spend
50
spend
50
save
100
save
100

Comments
Money Needed for the Vacation: 250
Available Money: 150
spend - subtract the next number from the available money (150 - 50 = 100)
        ~ consecutive days of spending = 1
        - total days: 1
spend - subtract the next number from the available money (100 - 50 = 50)
        ~ consecutive days of spending = 2
        - total days: 2
save - add the next number to the available money (50 + 100 = 150)
        ~ consecutive days of spending = 0
        - total days: 3
save - add the next number to the available money (150 + 100 = 250)
        ~ consecutive days of spending = 0
         - total days: 4
Available Money (250) >= Money Needed for the Vacation (250)*/

double neededMoney = double.Parse(Console.ReadLine());
double ownedMoney = double.Parse(Console.ReadLine());

int spendingCounter = 0;
int daysCounter = 0;

while (ownedMoney < neededMoney && spendingCounter < 5)
{
    daysCounter++;
    string actionType = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());

    if (actionType == "spend")
    {
        ownedMoney = ownedMoney - amount;
        if (ownedMoney <= 0)
        {
            ownedMoney = 0;
        }
        spendingCounter++;
    }
    else
    {
        ownedMoney = ownedMoney + amount;
        spendingCounter = 0;
    }

}

if (spendingCounter >= 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCounter);
}
if (ownedMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}