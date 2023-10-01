/* 2. Console converter: from radians to degrees Write a program that reads an angle in radians (decimal number) and converts it to degrees. Use the formula: degree = radian * 180 / π. The number π in C# programs is available through Math.PI.

   Example Input/Output

   Input 3.1416 
   Output 180.0004209182994

   Input 6.2832
   Output 360.0008418365988

   Input 0.7854 
   Output 45.00010522957485

   Guidelines

   1. Read the input data from the console (radians):*/

double radians = double.Parse(Console.ReadLine());

//2.Create a new variable in which you will convert radians to degrees, knowing the calculation formula:

double degrees = radians * 180 / Math.PI;

//3. Print the resulting degrees:

Console.WriteLine(degrees);