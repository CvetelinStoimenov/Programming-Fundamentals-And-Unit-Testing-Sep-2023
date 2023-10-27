/*
 6.	*Cards Game
You will be given two hands of cards, which will be integer numbers. Assume that you have two players. 
You must find the winning deck and, respectively, the winner.
You start from the beginning of both hands. Compare the cards from the first deck to those from the second. 
The player, who has a bigger card, takes both cards and puts them on the back of his hand - the second player's card is last,
and the first person's card (the winning one) is before it (second to last), 
and the player with the smaller card must remove the card from his deck. 
If both players' cards have the same values - no one wins, and the two cards must be removed from the decks. 
The game is over when one of the decks is left without any cards. 
You have to print the winner on the console and the sum of the left cards: 
"{First/Second} player wins! Sum: {sum}".

Example Input / Output

Input	            Output
20 30 40 50         First player wins! Sum: 240
10 20 30 40

Input	            Output
10 20 30 40 50      Second player wins! Sum: 50
50 40 30 30 10*/

List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> secondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


//for (int i = 0; i < firstPlayer.Count; i++)
//{
//while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
//{
//    if (firstPlayer[i] == secondPlayer[i])
//    {
//        firstPlayer.RemoveAt(i);
//        secondPlayer.RemoveAt(i);
//    }

//    else if (firstPlayer[i] > secondPlayer[i])
//    {
//        firstPlayer.Add(firstPlayer[i]);
//        firstPlayer.Add(secondPlayer[i]);
//        firstPlayer.RemoveAt(i);
//        secondPlayer.RemoveAt(i);
//    }
//    else
//    {
//        secondPlayer.Add(secondPlayer[i]);
//        secondPlayer.Add(firstPlayer[i]);
//        firstPlayer.RemoveAt(i);
//        secondPlayer.RemoveAt(i);
//    }
//}

//}

//if (firstPlayer.Count == 0)
//{
//    int sum = secondPlayer.Sum();
//    Console.WriteLine($"Second player wins! Sum: {sum}");
//}
//else
//{
//    int sum = firstPlayer.Sum();
//    Console.WriteLine($"First player wins! Sum: {sum}");
//}

//Lector code:
while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
{
    if (firstPlayer[0] > secondPlayer[0])
    {
        firstPlayer.Add(secondPlayer[0]);
        firstPlayer.Add(firstPlayer[0]);
    }
    else if (firstPlayer[0] < secondPlayer[0])
    {
        secondPlayer.Add(firstPlayer[0]);
        secondPlayer.Add(secondPlayer[0]);
    }

    firstPlayer.RemoveAt(0);
    secondPlayer.RemoveAt(0);
}

if (firstPlayer.Count > 0)
{
    int sum = firstPlayer.Sum();
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else if(secondPlayer.Count > 0)
{
    int sum = secondPlayer.Sum();
    Console.WriteLine($"Second player wins! Sum: {sum}");
}