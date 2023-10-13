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

//Lector code:

//повтаряме: въвеждаме данни
//стоп: input == "End"
//продължаваме: input != "End"
double balance1 = 0; //баланс на сметката

string input = Console.ReadLine(); //входни данни: "500" или "End"

while (input != "End")
{
    //входни данни са число под формата на текст "500"
    //"500" -> double 500
    double money = double.Parse(input); //пари, които внасяме / теглим
    if (money >= 0)
    {
        //внасяне
        balance += money;
        Console.WriteLine($"Increase: {money:F2}");
    }
    else //money < 0
    {
        //теглим
        balance -= Math.Abs(money);
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }


    input = Console.ReadLine();
}

//входни данни == "End"
Console.WriteLine($"Balance: {balance:F2}");