using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("What is your first name? Michael");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? Ajayi");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName} Ajayi, {firstName} Michael {lastName} Ajayi");
    }
}
