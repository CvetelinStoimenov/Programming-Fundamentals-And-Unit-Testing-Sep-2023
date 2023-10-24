/*
 4.	Exam Preparation
Write a program where Marin solves exam problems until he receives the message "Enough" from his teacher. For each solved problem, 
he receives a grade. The program should stop reading data when the command "Enough" is given or when Marin receives a certain number 
of poor grades.

A poor grade is any grade that is less than or equal to 4.

Input
    •	On the first line - number of poor grades - an integer in the range [1…5]
    •	After that, read multiple pairs of lines:
        o	Problem name - text (string)
        o	Grade - an integer in the range [2…6]
Output
    •	If Marin reaches the command "Enough," print on 3 lines:
        o	"Average score: {average grade}"
        o	"Number of problems: {total number of problems}"
        o	"Last problem: {name of the last problem}"
    •	If he receives the specified number of poor grades:
        o	"You need a break, {number of poor grades} poor grades."
Format the average grade to have two decimal places after the decimal point.

Example Input and Output

Input	        Output	                
3               Average score: 5.25
Money           Number of problems: 4
6               Last problem: Bus
Story
4
Spring Time
5
Bus
6
Enough

Comments
The allowed number of poor grades is 3.
The first problem is called Money, and Marin's grade is 6.
The second problem is Story, and Marin's grade is 4.
The third problem is Spring Time, and Marin's grade is 5.
The fourth problem is Bus, and Marin's grade is 6.
The next command is Enough, and the program ends.
Average grade: 21 / 4 = 5.25
Number of solved problems: 4
Last problem: Bus

Input	        Output	
2               You need a break, 2 
Income          poor grades.
3
Game Info
6
Best Player
4

Comments
The number of poor grades is 2.
The first problem is Income, and Marin's grade is 3.
The second problem is Game Info, and Marin's grade is 6.
The third problem is Best Player, and Marin's grade is 4.
Marin has reached the allowed number of poor grades; it's time for a break.
*/

int poorGrade = int.Parse(Console.ReadLine());
int countPoorGrade = 0;
int countProblems = 0;
int grade = 0;
double sumGrade = 0;
string problemName = "";

while (poorGrade > countPoorGrade)
{
    sumGrade = sumGrade + grade;
    string lastProblem = problemName;
    problemName = Console.ReadLine();

    if (problemName == "Enough")
    {
        double averageScore = sumGrade / countProblems;
        Console.WriteLine($"Average score: {averageScore:f2}");
        Console.WriteLine($"Number of problems: {countProblems}");
        Console.WriteLine($"Last problem: {lastProblem}");
        return;
    }

    grade = int.Parse(Console.ReadLine());

    if (grade <= 4)
    {
        countPoorGrade++;
    }
    countProblems++;
}
Console.WriteLine($"You need a break, {poorGrade} poor grades.");