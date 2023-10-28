/*
7.	Coins
Vending machine manufacturers aim to make their machines return the least amount of coin change possible. 
Write a program that takes an amount - the change that needs to be returned, and calculates how it can be 
done with the minimum possible number of coins.
Hint: Coins accepted by the vending machine: 2 leva, 1 lev, 50 stotinki, 20 stotinki, 10 stotinki, 5 stotinki, 
2 stotinki, 1 stotinka
 
Example Input and Output

Input	Output	Comments
1.23	4       Our change is 1 leva and 23 stotinki. The machine returns it with 4 coins: a 1-lev coin, a 20-
                stotinki coin, a 2-stotinki coin, and a 1-stotinka coin.

Input	Output	Comments
2	    1       Our change is 2 leva. The machine returns it with 1 coin of 2 leva.

Input	Output	Comments
0.56	3       Our change is 56 stotinki. The machine returns it with 3 coins: 
                a coin of 50 stotinki, a coin of 5 stotinki, and a coin of 1 stotinka.

Input	Output	Comments
2.73	5       Our change is 2 leva and 73 stotinki. The machine returns it with 5 coins: 
                a coin of 2 leva, a coin of 50 stotinki, a coin of 20 stotinki, a coin of 2 stotinki, 
                and a coin of 1 stotinka.*/
//My code:

//double change = double.Parse(Console.ReadLine());
//change = Math.Round(change * 100, 2);
//int countCoins = 0;

//while (change > 0)
//{
//    if (change >= 200)
//    {
//        change -= 200;
//        countCoins ++;
//    }
//    else if (change >= 100)
//    {
//        change -= 100;
//        countCoins++;
//    }
//    else if (change >= 50)
//    {
//        change -= 50;
//        countCoins++;
//    }
//    else if (change >= 20)
//    {
//        change -= 20;
//        countCoins++;
//    }
//    else if (change >= 10)
//    {
//        change -= 10;
//        countCoins++;
//    }
//    else if (change >= 5)
//    {
//        change -= 5;
//        countCoins++;
//    }
//    else if (change >= 2)
//    {
//        change -= 2;
//        countCoins++;
//    }
//    else if (change >= 1)
//    {
//        change -= 1;
//        countCoins++;
//    }
//}

//Console.WriteLine(countCoins);

//Lector code 01:
//double value = double.Parse(Console.ReadLine());

//int coins = 0;

////let's go to stotinki
//int stotinki = (int)(value * 100); // we need to cast from bigger to smaller type

//int curStotinkiCoin = 200; // start with the largest stotinki coin (2 leva)

//while (curStotinkiCoin != 0)
//{
//    coins += stotinki / curStotinkiCoin;
//    stotinki = stotinki % curStotinkiCoin;

//    // now we need to switch to the next smaller coin
//    switch (curStotinkiCoin)
//    {
//        case 200: curStotinkiCoin = 100; break;
//        case 100: curStotinkiCoin = 50; break;
//        case 50: curStotinkiCoin = 20; break;
//        case 20: curStotinkiCoin = 10; break;
//        case 10: curStotinkiCoin = 5; break;
//        case 5: curStotinkiCoin = 2; break;
//        case 2: curStotinkiCoin = 1; break;
//        case 1: curStotinkiCoin = 0; break; // this is the end of the cycle
//    }
//}

//Console.WriteLine(coins);

//Lector code 02:

double value = double.Parse(Console.ReadLine());

int coins = 0;

double curStotinkiCoinValue = 2.00; // start with the largest stotinki coin (2 leva)

while (value != 0)
{
    if (value >= curStotinkiCoinValue)
    {
        coins++; // another coin there!
        value = Math.Round(value - curStotinkiCoinValue, 2); // we must round here, otherwise we'll be in double "precision trouble"
    }
    else
        // the current value is less than the current coin value
        // go to the lesser coin value
        switch (curStotinkiCoinValue)
        {
            case 2.00: curStotinkiCoinValue = 1.00; break;
            case 1.00: curStotinkiCoinValue = 0.50; break;
            case 0.50: curStotinkiCoinValue = 0.20; break;
            case 0.20: curStotinkiCoinValue = 0.10; break;
            case 0.10: curStotinkiCoinValue = 0.05; break;
            case 0.05: curStotinkiCoinValue = 0.02; break;
            case 0.02: curStotinkiCoinValue = 0.01; break;
            case 0.01: curStotinkiCoinValue = 0; break; // this is the end of the cycle
        }
}

Console.WriteLine(coins);