/*
6.	Steps
Gabi wants to start a healthy lifestyle and has set a goal to walk 10,000 steps every day. However, on some days, 
she feels very tired from work and wants to go home before reaching her goal. Write a program that reads from the 
console how many steps she takes each time she goes out during the day. When she reaches her goal, the program should
display "Goal reached! Good job!" and how many steps she exceeded the goal by: "{difference} steps over the goal!"
If she wants to go home before reaching her goal, she will enter the command "Going home" and input the steps she 
took while going home. After that, if she hasn't reached her goal, the program should display: "{difference} 
more steps to reach goal."

Example Input and Output

Input	    Output	
1000        Goal reached! Good job!
1500        1000 steps over the goal!
2000
6500

Input	    Output
1500        2500 more steps to reach goal.
300
2500
3000
Going home
200

Input	    Output
1500        Goal reached! Good job!
3000        298 steps over the goal!
250
1548
2000
Going home
2000

Input	    Output
125         Goal reached! Good job!
250         1765 steps over the goal!
4000
30
2678
4682*/

int stepsCounter = 0;
int TotalSteps = 0;

while (TotalSteps <= 10000)
{ 
    string input = Console.ReadLine();
    if (input == "Going home")
    {
        stepsCounter = int.Parse(Console.ReadLine());
        TotalSteps += stepsCounter;
        break;
    }

    stepsCounter = int.Parse(input);
    TotalSteps += stepsCounter;
}

if (TotalSteps >= 10000)
{
    TotalSteps = TotalSteps - 10000;
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{TotalSteps} steps over the goal!");
}
else
{
    TotalSteps = 10000 - TotalSteps; 
    Console.WriteLine($"{TotalSteps} more steps to reach goal.");
}