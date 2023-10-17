/*4.Letter Combinations
Write a program to generate 3-letter combinations under certain conditions:
    •	Read a start letter s, end letter e and excluded letter x
    •	Generate all combinations of 3 letters in the range [s…e], excluding x
    •	Print all combinations on the first line
    •	Print combinations count on the second line

Example Input / Output

Input       Output
a           aaa aac aca acc caa cac cca ccc
c           8
b

Input       Output
d           ddd ddf ddg dfd dff dfg dgd dgf dgg fdd fdf fdg ffd fff ffg fgd fgf fgg 
g           gdd gdf gdg gfd gff gfg ggd ggf ggg 
e           27*/

char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());
int sumOfLetters = 0;

for (char firstCh = startLetter; firstCh <= endLetter; firstCh ++)
{
    for (char secondCh = startLetter; secondCh <= endLetter; secondCh++)
    {
        for (char thirdCh = startLetter; thirdCh <= endLetter; thirdCh ++)
        {
            if (firstCh != excludedLetter && secondCh != excludedLetter && thirdCh != excludedLetter)
            {
                Console.Write($"{firstCh}{secondCh}{thirdCh} ");
                sumOfLetters++;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(sumOfLetters);