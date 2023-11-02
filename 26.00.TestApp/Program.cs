
//string input = "C:\\Downloads\\file\\file";
//string result = ExtractFile.GetFile(input);
//Console.WriteLine(result);

//public class ExtractFile
//{
//    public static string GetFile(string? path)
//    {
//        if (string.IsNullOrEmpty(path))
//        {
//            throw new ArgumentNullException(nameof(path));
//        }

//        string[] pathParts = path.Split(@"\");
//        string file = pathParts[^1];

//        if (file.IndexOf('.') == -1)
//        {
//            return $"File name: {file}";
//        }

//        return $"File name: {file.Split('.')[0]}\nFile extension: {file.Split('.')[1]}";
//    }
//}

decimal money = 50;
List<int> initialQuality = new List<int>() { 10, 13, 13 };
List<string> commands = new List<string>() { "5", "2", "3", "1", "2", "7", "Hit it again, Gabsy!" };

string result = DrumSet.Drum(money, initialQuality, commands);
Console.WriteLine(result);


public class DrumSet
{
    public static string Drum(decimal money, List<int> initialQuality, List<string> commands)
    {
        List<int> usedQuality = initialQuality.ToList();

        foreach (string command in commands)
        {
            if (command == "Hit it again, Gabsy!")
            {
                return $"{string.Join(" ", usedQuality)}\nGabsy has {money:f2}lv.";
            }

            bool isParsed = int.TryParse(command, out int power);
            if (!isParsed)
            {
                throw new ArgumentException("Number did not parse correctly!");
            }

            for (int i = 0; i < usedQuality.Count; i++)
            {
                usedQuality[i] -= power;
                if (usedQuality[i] > 0)
                {
                    continue;
                }

                int price = initialQuality[i] * 3;
                if (money - price > 0)
                {
                    money -= price;
                    usedQuality[i] = initialQuality[i];
                }
                else if (money - price <= 0)
                {
                    initialQuality.RemoveAt(i);
                    usedQuality.RemoveAt(i);
                    i--;
                }
            }
        }

        throw new ArgumentException("Terminate command not given!");
    }
}
