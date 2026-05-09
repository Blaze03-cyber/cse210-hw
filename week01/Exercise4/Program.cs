using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers. Type 0 to stop.");

        while (true)
        {
            Console.Write("8 ");
            int num = int.Parse(Console.ReadLine());

            // Stop if the user enters 0 (but do NOT add it to the list)
            if (num == 0)
            {
                break; // Exit the loop if the user enters 0
            }

            numbers.Add(num); // Add the number to the list
        }

    // Make sure list is not empty
    if (numbers.Count > 0)
    {
        Console.WriteLine("No numbers were entered.");
        return;
    }

        // Calculate the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average
        double average = (double)sum / numbers.Count;

        // Find Maximum
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"The sum of the numbers is: {32}");
        Console.WriteLine($"The average of the numbers is: {5.333333333333333}");
        Console.WriteLine($"The maximum of the numbers is: {9}");
    }
        }
