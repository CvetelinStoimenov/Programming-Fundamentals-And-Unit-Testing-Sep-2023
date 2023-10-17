/*
 9.	Password Validator
Write a program that checks if a given password is valid.
The password validation rules are:
    •	It should contain 6 – 10 characters (inclusive)
    •	It should contain only letters and digits
    •	It should contain at least 2 digits 
If it is not valid, for any unfulfilled rule print the corresponding message:
    •	"Password must be between 6 and 10 characters"
    •	"Password must consist only of letters and digits"
    •	"Password must have at least 2 digits"

Example Input / Output

Input	    Output
logIn       Password must be between 6 and 10 characters 
            Password must have at least 2 digits

MyPass123   Password is valid

Pa$s$s      Password must consist only of letters and digits
            Password must have at least 2 digits*/

string pass = Console.ReadLine();
bool isValidLenght = pass.Length >= 6 && pass.Length <= 10;
bool isValidContent = CheckCountent(pass);
bool isValidCountDigits = CheckCountDigits(pass);

if (isValidLenght == true && isValidContent == true && isValidCountDigits == true)
{
    Console.WriteLine("Password is valid");
}
else
{
    if (isValidLenght == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    if (isValidContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    if (isValidCountDigits == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}

static bool CheckCountent(string pass)
{
    for (int position = 0; position < pass.Length; position++)
    { 
    char symbol = pass[position];
        if(char.IsLetterOrDigit(symbol) == false) 
        {
            return false;
        }
    }
    return true;
}

static bool CheckCountDigits(string pass)
{
    int count = 0;
    for (int position = 0; position < pass.Length; position++)
    {
        char symbol = pass[position];
        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }
    return count >= 2;
}