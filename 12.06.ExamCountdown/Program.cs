/*
6.	Exam Countdown
Write a program to print a countdown to an exam:
    •	Read an integer number d: the count of days before an exam
    •	For each day d…1 print: "{currentDay} days before the exam"
    •	At the end print: "The exam has come"

Example Input / Output

Input	Output
3	    3 days before the exam
        2 days before the exam
        1 days before the exam
        The exam has come		

Input	Output
4	    4 days before the exam
        3 days before the exam
        2 days before the exam
        1 days before the exam
        The exam has come
*/
int n = int.Parse(Console.ReadLine());

for (int i = n; i > 0; i--)
{
    Console.WriteLine($"{i} days before the exam");
}
Console.WriteLine("The exam has come");

//while (n > 0)
//{
//    Console.WriteLine($"{n} days before the exam");
//    n--;
//}
//Console.WriteLine("The exam has come");