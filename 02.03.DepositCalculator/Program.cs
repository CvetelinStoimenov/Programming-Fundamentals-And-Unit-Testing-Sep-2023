/*3. Deposit Calculator

     Write a program that calculates how much you will receive at the end of the deposit period at a certain interest rate. Use the following formula:

     amount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12

     Input

     From the console read 3 lines:

     1. Deposited amount – real number in the range [100.00 ... 10000.00]

     2. Term of the deposit (in months) – an integer in the range [1... 12]

     3. Annual interest rate – real number in the range [0.00 ... 100.00]

     Output

     Print the amount on the console at the end of the term.

     Example Input/Output
     Input 200
           3
           5.7
     Output 202.85

     1. We calculate the accumulated interest: 200 * 0.057 (5.7%) = 11.40 BGN.
     2. We calculate the interest for 1 month: 11.40 BGN / 12 months = 0.95 BGN.
     3. The total amount is: 200 BGN + 3 * 0.95 BGN = 202.85 BGN

     Input 2350
           6
           7
     Output 2432.25

     1. We calculate the accumulated interest: 2350 * 0.07 (7%) = 164.50 BGN.
     2. We calculate the interest for 1 month: 164.50 BGN / 12 months = 13.7083... Lv.
     3. The total amount is: 2350 BGN + 6 * 13.7083... = 202.85 BGN

  */

double depositedAmount = double.Parse(Console.ReadLine());
int termOfDeposi = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());
double rate = annualInterestRate / 100;


double amount = depositedAmount + termOfDeposi * (depositedAmount * rate) / 12;
Console.WriteLine(amount);