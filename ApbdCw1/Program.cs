using System;

namespace ApbdCw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please enter numbers separated by spaces:");
            string input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: No input provided.");
                return;
            }
            
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[parts.Length];
            
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    Console.WriteLine($"Error: '{parts[i]}' is not a valid integer.");
                    return;
                }
            }
            
            double average = StatisticsHelper.CalculateAverage(numbers);
            Console.WriteLine($"Average: {average}");
        }
int min = StatisticsHelper.CalculateMin(numbers);
Console.WriteLine($"Minimum: {min}");
    }
}