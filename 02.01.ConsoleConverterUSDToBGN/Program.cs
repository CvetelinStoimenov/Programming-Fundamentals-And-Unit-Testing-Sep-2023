/*1.Console Converter: USD to BGN

    Write a program to convert US dollars(USD) to Bulgarian leva(BGN).Use a fixed rate between dollar and lev: 1 USD = 1.79549 BGN.

    Example Input/ Output

    Input 22 
    Output 39.50078

    Input 100
    Output 179.549

    Input 12.5
    Output 22.443625

    Guidelines

    1.Read the input data from the console(US dollars):*/

double usd = double.Parse(Console.ReadLine());

//2. Create a new variable in which you will convert from US dollars to Bulgarian leva, knowing the exchange rate:

double bgn = usd * 1.79549;

//3. Print the received Bulgarian leva.

Console.WriteLine(bgn);