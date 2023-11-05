/*
Calculate Average Grade
Write a program that:
    •	Reads an integer number N (count of the students) from the console
    •	For each student (from first to the last (N)): read from the console his grade (floating-point number) 
    •	Print the average grade of the students, formatted to the second digit

Example Input / Output

Input	Output	Comments
5       4.34
3.40
4.50
3.30
5.90
4.60

Input	Output	Comments
3       4.30
4.40
5.30
3.20

*/

int countOfTheStudents = int.Parse(Console.ReadLine());
double averageGrade = 0;

for (int i = 0; i < countOfTheStudents; i++)
{ 
    double grade = double.Parse(Console.ReadLine());
    averageGrade += grade;
}

averageGrade /= countOfTheStudents;

Console.WriteLine($"{averageGrade:f2}");