/*9.Smallest Number
Write a program that reads integers entered by the user until the command "Stop" is received, 
and finds the smallest number among them. Input one number per line.

Example Input/Output
Input	Output
100     70
99
80
70
Stop	

Input	Output
-10     -30
20
-30
Stop

Input	Output
45      -20
-20
7
99
Stop

Input	Output
999     999
Stop

Input	Output
-1      -2
-2
Stop*/
int minNum = int.MaxValue;

while (true)
{
    string command = Console.ReadLine();

    if (command == "Stop")
    {
        break;
    }

    int compNum = int.Parse(command);
    if (compNum < minNum)
    {
        minNum = compNum;
    }

}
Console.WriteLine(minNum);