/*
 10.	Graduation
Write a program that calculates the average grade of a student throughout their education. 
On the first line, you will receive the student's name, and on each subsequent line, you will receive their annual grades. 
A student advances to the next grade if their annual grade is greater than or equal to 4.00. If a student is failed more than once, 
they are expelled, and the program ends, printing the student's name and the grade in which they were expelled.
Upon successful graduation from the 12th grade, print:
"{student's name} graduated. Average grade: {average grade from the entire education}"
In the case that a student is expelled from school, print:
"{student's name} has been excluded at {grade in which they were expelled} grade"
The value should be formatted to the second decimal place.

Example Input/Output

Input	Output
Gosho   Gosho graduated. Average grade: 5.53
5
5.5
6
5.43
5.5
6
5.55
5
6
6
5.43
5

Input	Output
Mimi    Mimi has been excluded at 8 grade
5
6
5
6
5
6
6
2
3*/

string studentName = Console.ReadLine();
double sumGrade = 0;
double averageGrade = 0;
bool isExpelled = false;
int year = 0;
int fail = 0;

while (year < 12)
{
    double grade = double.Parse(Console.ReadLine());
    sumGrade += grade;

    if (grade < 4)
    {
        fail++;
        if (fail >= 2)
        {
            isExpelled = true;
            break;
        }
    }

    year ++;
}

if (isExpelled)
{
    Console.WriteLine($"{studentName} has been excluded at {year} grade");
}
else
{
    averageGrade = sumGrade / 12;
    Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
}