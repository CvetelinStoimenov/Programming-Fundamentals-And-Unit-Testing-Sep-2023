/* 4. Mandatory Literature

For the summer holidays, there are a certain number of books on Joro's list of mandatory literature. Since Joro prefers to play with friends outside, your task is to help him calculate how many hours a day he should devote to read the necessary literature.

Input

Read 3 lines from the console:

1. Number of pages in the current book – an integer in the range [1... 1000]

2. Pages that he reads in 1 hour – an integer in the range [1... 1000]

3. The number of days he needs to finish the book – an integer in the range [1... 1000]

Hint: For the operands of integer types, the result of the / operator is of an integer type and equals the quotient of the two operands rounded towards zero.

Output

Print on the console the number of hours that Joro has to spend reading each day.

Example Input/Output

Input 212
      20
      2

Output 5

Total reading time of the book: 212 pages / 20 pages per hour = 10 hours total
Required hours per day: 10 hours / 2 days = 5 hours per day


Input 432
      15
      4

Output 7

Total reading time of the book: 432 pages / 15 pages per hour = 28 hours total
Required hours per day: 28 hours / 4 days = 7 hours per day
*/

int pageNum = int.Parse(Console.ReadLine());
int pageHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int hours = (pageNum / pageHour) / days;

Console.WriteLine(hours);