/*
The "Train the trainers" course is near its end, and the final assessment is approaching. Your task is to assist the jury that will evaluate the presentations by creating a program that calculates the average grade for each student's presentation and finally the overall average success.
Read from the console, the number of jury members: n - an integer in the range [1…20]
Then, the name of the presentation is read on a separate line: a string
For each presentation, n grades are read on separate lines - real numbers in the range [2.00…6.00]
After calculating the average grade for a specific presentation, print on the console:
"{presentation name} - {average grade}."
Upon receiving the command Finish, print on the console:
"Student's final assessment is {overall average success}." and the program finishes. 
All grades should be formatted to two decimal places.

Example Input and Output

Input	    Output	                Comments
2           While-Loop - 5.75.      2 – The number of people in the jury, so you will receive 2 grades per presentation. 
While-Loop  For-Loop - 5.75.        (6.00 + 5.50) / 2 = 5.75
6.00        Student's final         (5.84 + 5.66) / 2 = 5.75
5.50        assessment is 5.75.     (6.00 + 5.50 + 5.84 + 5.66) / 4 = 5.75 
For-Loop
5.84
5.66
Finish

Input                   Output
3                       Arrays - 4.92.
Arrays                  Lists - 5.75.
4.53                    Student's final assessment is 5.34.
5.23
5.00
Lists
5.83
6.00
5.42
Finish

Input                   Output
2                       Objects and Classes - 5.00.
Objects and Classes     Dictionaries - 4.82.
5.77                    RegEx - 3.15.
4.23                    Student's final assessment is 4.32.
Dictionaries
4.62
5.02
RegEx
2.88
3.42
Finish*/

int juryJembers = int.Parse(Console.ReadLine());
string presentationName = "";
double grade = 0;
int count = 0;
double allgrade = 0;
double averageGrade = 0;
double overallAverageSuccess = 0;

while (true)

{
    presentationName = Console.ReadLine();
    double sum = 0;
    if (presentationName == "Finish")
    {
        break;
    }
    for (int i = 0; i < juryJembers; i++)
    { 
        grade = double.Parse(Console.ReadLine());
        allgrade += grade;
        sum += grade;
        count++;
    }
    averageGrade = sum / juryJembers;
    Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
}
overallAverageSuccess = allgrade / count;
Console.WriteLine($"Student's final assessment is {overallAverageSuccess:f2}.");


//Lector code:

int juryMembers = int.Parse(Console.ReadLine() ?? "0");

double studentGradesSum = 0;
int numberOfPresentations = 0;

for (; ; numberOfPresentations++)
{
    String presName = Console.ReadLine() ?? "Finish";

    if (presName == "Finish")
        break; // done with all presentations

    double presentationGrades = 0;

    // read the evaluation of each jury member
    for (int curJury = 0; curJury < juryMembers; curJury++)
        presentationGrades += double.Parse(Console.ReadLine() ?? "0");

    // print out the current presentation score
    Console.WriteLine($"{presName} - {presentationGrades / juryMembers:f2}.");

    // accumulate the current presentation score to the global score
    studentGradesSum += presentationGrades;
}

// print out the student's final results
// note how we calculate the final results directly during printout, to avoid additional variable
Console.WriteLine($"Student's final assessment is {studentGradesSum / numberOfPresentations / juryMembers:f2}.");

//Lector code 1:

int juriMembers = int.Parse(Console.ReadLine());

double totalGradesSum = 0;
int presentationCount = 0;
while (true)
{
    String presName = Console.ReadLine();

    if (presName == "Finish")
        break;

    presentationCount++;

    double presentationAverage = 0;

    for (int juryMember = 1; juryMember <= juriMembers; juryMember++)
    {
        double curGrade = double.Parse(Console.ReadLine());

        presentationAverage += curGrade;
        totalGradesSum += curGrade;
    }

    Console.WriteLine($"{presName} - {presentationAverage / juriMembers:f2}.");
}

Console.WriteLine($"Student's final assessment is {totalGradesSum / (presentationCount * juriMembers):f2}.");