/*
6.Operations
Write a program that reads two integers (N1 and N2) along with an operator to perform a mathematical 
operation between them. The possible operations are: Addition(+), Subtraction(-), Multiplication(*), 
Division(/), and Modular Division (%). For Addition, Subtraction, and Multiplication, the result 
and whether it is even or odd should be printed on the console. For regular Division, the quotient should be printed. 
For Modular Division, the remainder should be displayed. It should be considered that the divisor can be equal to 0 (zero),
and division by zero is not possible. In this case, a special message should be printed.

Input

From the console are read 3 lines entered by the user:

•	N1 – an integer value in the range [0...40 000]
•	N2 – an integer value in the range [0...40 000]
•	Operator – one symbol among the following: "+", "-", "*", "/", "%"

Output

Print one line on the console:

•	If the operation is division:
    o   "{N1} / {N2} = {result}" - result formatted to second decimal place

•	If the operation is modular division: 
    o   "{N1} % {N2} = {remainder}"

•	In the case of division by 0 (zero): 
    o   "Cannot divide {N1} by zero"

Example Input/Output

Input	        Output	                        Input	      Output	            Input	     Output
10              10 + 12 = 22 - even	123         123           123 / 12 = 10.25      112          Cannot divide 112 by zero
12                                              12                                  12
+                                               /                                   /

10	            10 - 1 = 9 - odd	10          10            10 % 3 = 1	        10          Cannot divide 10 by zero
1                                               3                                   0
-                                               %                                   %

7	            7 * 3 = 21 - odd
3
*

*/

double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
string op = Console.ReadLine();
double sum = 0;

//My code
//if (n2 == 0)
//{
//    Console.WriteLine($"Cannot divide {n1} by zero");
//    return;
//}
//else if (op == "+")
//{
//    sum = n1 + n2;
//}
//else if (op == "-")
//{
//    sum = n1 - n2;
//}
//else if (op == "*")
//{
//    sum = n1 * n2;
//}
//else if (op == "/")
//{
//    sum = n1 / n2;
//    Console.WriteLine($"{n1} {op} {n2} = {sum:f2}");
//    return;
//}
//else if (op == "%")
//{
//    sum = n1 % n2;
//}


//if (sum % 2 == 0 && op != "/" && op != "%")
//{
//    Console.WriteLine($"{n1} {op} {n2} = {sum} - even");
//}
//else if (op != "/" && op != "%")
//{
//    Console.WriteLine($"{n1} {op} {n2} = {sum} - odd");
//}
//else
//{
//    Console.WriteLine($"{n1} {op} {n2} = {sum}");
//}

//Lector code:
string modDiv = "";

switch (op)
{
    case "*":
    case "-":
    case "+":
        switch (op)
        {
            case "*":
                sum = n1 * n2; 
                break;
            case "-":
                sum = n1 - n2;
                break;
            case "+":
                sum = n1 + n2;
                break;
        }
        if (sum % 2 == 0)
        {
            modDiv = "even";
        }
        else
        {
            modDiv = "odd";
        }
        Console.WriteLine($"{n1} {op} {n2} = {sum} - {modDiv}");
        break;

    case "%":
    case "/":
        if (n2 != 0)
        {
            if (op == "/")
            {
                sum = n1 / n2;
                Console.WriteLine($"{n1} {op} {n2} = {sum:f2}");
            }
            else
            {
                sum = n1 % n2;
                Console.WriteLine($"{n1} {op} {n2} = {sum}");
            }
        }
        else 
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        break;
}