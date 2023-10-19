/*
7.	Account Balance
Write a program that calculates the total amount of money in an account after making a certain number of deposits. 
On each line, you will receive the amount that you need to deposit into the account, until you receive the command "NoMoreMoney". 
For each received amount, you should output "Increase: " + the amount and add it to the account balance. 
If you receive a number less than 0, you should output "Invalid operation!" and the program should terminate. 
When the program finishes, it should print "Total: " + the total amount in the account formatted to two decimal 
places after the decimal point.

Example Input/Output

Input	        Output
5.51            Increase: 5.51
69.42           Increase: 69.42
100             Increase: 100.00
NoMoreMoney     Total: 174.93

Input       	Output
120             Increase: 120.00
45.55           Increase: 45.55
-150            Invalid operation!
                Total: 165.55*/
double sum = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "NoMoreMoney")
    {
        break;
    }
    double amount = double.Parse(command);
    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    
    sum += amount;
    Console.WriteLine($"Increase: {amount:f2}");
}
Console.WriteLine($"Total: {sum:f2}");