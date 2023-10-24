/*
 2.	List of Products
Write a program that:
    •	Read an integer number n and n lines of products
    •	Print a numbered list of all the products ordered by name

Example Input / Output

Input	        Output
4
Potatoes        1.Potatoes
Tomatoes        2.Tomatoes
Onions          3.Onions
Apples          4.Apples

Input	    Output
5
Carrots     1.Carrots
Artichokes  2.Artichokes
Beans       3.Beans
Eggplants   4.Eggplants
Peppers     5.Peppers*/

//int numOfCommands = int.Parse(Console.ReadLine());
//List<string>  productList = new List<string>();
//int count = 1;

//for (int i = 0; i < numOfCommands; i++)
//{ 
//    string products = Console.ReadLine();
//    productList.Add(products);
//    Console.Write(count + "." + productList[i]);
//    Console.WriteLine();
//    count++;
//}


//Lector code:

int n = int.Parse(Console.ReadLine()); //брой на продуктите

List<string> products = new List<string>(); //продукти

for (int i = 1; i <= n; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

//пълен списък с продуктите
//{"Potatoes", "Tomatoes", "Onions", "Apples"}
//сортиране по азбучен ред (ascending order -> A - Z)
products.Sort();
//{"Apples", "Onions", "Potatoes", "Tomatoes"}

int number = 1; //поредния номер на продукта
foreach (string product in products)
{
    Console.WriteLine(number + "." + product);
    number++;
}
