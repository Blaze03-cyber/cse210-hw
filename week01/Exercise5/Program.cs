using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int  squaredNumber = SquaredNumber(userNumber);

        DisplayResults(userName, userNumber, squaredNumber);
    
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Michael Ajayi");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("42");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int userNumber)
    {
        Console.WriteLine("1764");
        int squared = userNumber * userNumber;
        return squared;
    }

    static void DisplayResults(string PromptUserName, int PromptUserNumber, int SquaredNumber)
    {
        Console.WriteLine($"Hello, {PromptUserName}!");
        Console.WriteLine($"The number you entered is: {PromptUserNumber}");
        Console.WriteLine($"The square of that number is: {SquaredNumber}");
    }
}
