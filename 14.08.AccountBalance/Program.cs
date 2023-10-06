/*
 8.	Account Balance
Write a program to calculate an account balance:
    •	Read a sequence of incomes / expenses, until "End" is read
    •	Add the money to the balance (starting form 0)
    •	Print "Increase: {money} " or "Decrease: {money}", where value is formatted to the second decimal digit
    •	Finally, print the account balance, formatted to the second decimal digit

Example Input / Output

Input	    Output		                Input	Output
500         Increase: 500.00            200     Increase: 200.00
15.5        Increase: 15.50             300     Increase: 300.00
-80.35      Decrease: 80.35             -100    Decrease: 100.00
End         Balance: 435.15             End     Balance: 400.00*/

string command = "";
double balance = 0;

while (true)
{
    command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    balance += double.Parse(command);
    if (double.Parse(command) > 0)
    {
        Console.WriteLine($"Increase: {double.Parse(command):f2}");
    }
    else if (double.Parse(command) < 0)
    {
        Console.WriteLine($"Decrease: {-double.Parse(command):f2}");
    }
}
Console.WriteLine($"Balance: {balance:f2}");