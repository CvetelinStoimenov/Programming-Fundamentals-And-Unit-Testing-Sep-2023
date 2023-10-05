/*
7.	Latin Letters
Write a program to print the Latin letters in certain range:
    •	Read two letters (chars), each on separate line
    •	Print all letters in the specified range inclusively
Input	Output
a
c	    a b c		

Input	Output		
f
q	    f g h i g k l m o p q
		
Input	Output
W
Z	    W X Y Z
*/

char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());

for (char i = start; i <= end; i++)
{
    Console.Write(i + " ");
}

//while (start <= end)
//{
//    Console.Write(start + " ");
//    start++;
//}
