/*
 You are invited to a 30th birthday party where the birthday person is having a large cake. 
However, they don't know how many pieces the guests can take before the cake is finished. 
Your task is to write a program that calculates the number of pieces guests have taken before 
the cake runs out. You will receive the dimensions of the cake (width and length - 
integers in the range [1...1000]), and then on each line, until you receive the 
command "STOP" or until the cake is finished, you will get the number of pieces guests take from it.

Note: Each cake piece has a size of 1x1 cm.

Print one of the following lines on the console:
"{number of pieces} pieces are left." - if you reach STOP and there are cake pieces left
"No more cake left! You need {number of missing pieces} pieces more."

Example Input and Output

Input	Output	                                        
10      No more cake left! You need 1 pieces more.
10
20
20
20
20

Comments
The cake has a length of 10  and a width of 10 
=> The number of pieces = 10 * 10 = 100 
1st take -> 100 - 20 = 80
2nd take -> 80 - 20 = 60
3rd take -> 60 - 20 = 40
4th take -> 40 - 20 = 20
5th take-> 20 - 21 = -1 < 0
=> No more cake left, 1 piece is not enough



Input	Output	                                        
21      8 pieces are left.
10
2
2
4
6
STOP

Comments
The cake has a length of 10 and a width of 2
=> The number of pieces = 10 * 2 = 20 
1st take -> 20 - 2 = 18
2nd take -> 18 - 4 = 14
3rd take -> 14 - 6 = 8
4th take -> STOP command
=> Pieces left: 
*/

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int totalPieces = width * length;

while (totalPieces > 0)
{ 
    string command = Console.ReadLine();

    if (command == "STOP")
    {

        break;
    }
    else
    {
        totalPieces -= int.Parse(command);
    }
}

if (totalPieces >= 0)
{
    Console.WriteLine($"{totalPieces} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {-totalPieces} pieces more.");
}
