/*
 5.	Bomb Numbers
Write a program that:
    •	Reads a sequence of integer numbers from the first line of the console
    •	Read a special bomb number (integer) and its power (integer) from the second line of the console
    •	Detonate every occurrence of the special bomb number and according to its power - his neighbors from left and right
    •	 Detonations are performed from left to right, and all detonated numbers disappear
    •	Print the sum of the remaining elements in the sequence
*/

List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int bombNumber = bomb[0];
int bombPower = bomb[1];

for (int i = 0; i < input.Count; i++)
{
    if (input[i] == bombNumber)
    {
        int startIndex = i - bombPower;
        int removeCount = bombPower + bombPower + 1;

        if (startIndex < 0)
        {
            removeCount -= Math.Abs(startIndex);
            startIndex = 0;
        }
        if (startIndex + removeCount > input.Count) 
        {
            removeCount = input.Count - startIndex;
        }
        
        input.RemoveRange(startIndex, removeCount);
        i = startIndex - 1;
    }
}

int sum = input.Sum();
Console.WriteLine(sum);