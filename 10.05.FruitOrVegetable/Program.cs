/*string product = Console.ReadLine();

if (product == "banana"
    || product == "apple"
    || product == "kiwi"
    || product == "cherry"
    || product == "lemon")

{
    Console.WriteLine("fruit");
}
else if (product == "cucumber"
          || product == "pepper"
          || product == "carrot")
{
    Console.WriteLine("vegetable");
}
else
{
    Console.WriteLine("unknown");
}
*/
string product = Console.ReadLine();

switch (product)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
        Console.WriteLine("fruit");
        break;
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("vegetable");
        break;
    default: Console.WriteLine("unknown");
        break;
}