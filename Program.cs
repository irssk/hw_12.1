using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Fibonacci number: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            try
            {
                int result = FibonacciCalculator.GetFibonacci(n);
                Console.WriteLine($"Fibonacci number by number {n}: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Incorrect number entered.");
        }
    }
}