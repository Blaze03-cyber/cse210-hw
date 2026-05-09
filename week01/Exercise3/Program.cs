using System;

class Program
{
    static void Main(string[] args)
    {
        // For Part 1 and 2, where the user specified the number...
        // Console.WriteLine("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // For Part 3, where we use a random number...
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;

        // we could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        Console.WriteLine("Congratulations! You guessed it!");
    }
}
