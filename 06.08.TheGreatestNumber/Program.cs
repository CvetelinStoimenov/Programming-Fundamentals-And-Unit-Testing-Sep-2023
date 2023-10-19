/*
 8.	Greatest Number
Write a program that reads integers entered by the user until the command "Stop" is received, 
and finds the largest number among them. Input one number per line.

Example Input/Output

Input	Output
100     100
99
80
70
Stop

Input	Output
-1      -1
-2
Stop

Input	Output
-10     20
20
-30
Stop

Input	Output
45      99
-20
7
99
Stop

Input	Output
45      999
-20
7
99
Stop

*/
int maxNum = int.MinValue;

while (true)
{
    string command = Console.ReadLine();

    if (command == "Stop")
    {
        break;
    }

    int compNum = int.Parse(command);
    if (compNum > maxNum)
    {
        maxNum = compNum;
    }

}
Console.WriteLine(maxNum);