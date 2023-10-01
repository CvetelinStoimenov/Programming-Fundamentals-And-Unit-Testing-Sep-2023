/*
4.	Number Operations
Write a program to evaluate operations, which:

•	Reads 2 real numbers and math operator (string) from the console
•	Possible given values for the math operator are: "+", "-", "*", "/"
•	Apply the operator with given numbers
•	Print output in the following format, where result is formatted to the second digit:
"{N1} {operator} {N2} = {result}"

Example Input / Output
Input		Output						Input			Output
10			10 + 12 = 22.00				22				22 - 9 = 13.00
12										9
+										-


Input		Output						Input			Output
7.6			7.6 * 8.2 = 62.32			56              56 / 10 = 5.60 
8.2										10
										/
*/
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string op = Console.ReadLine();
double result = 0;

if (op == "+")
{
	result = num1 + num2;
}
else if (op == "-")
{
	result = num1 - num2;
}
else if (op == "*")
{ 
	result = num1 * num2;
}
if (op == "/")
{ 
	result = num1 /	num2;
}

Console.WriteLine($"{num1} {op} {num2} = {result:f2}");