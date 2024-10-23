using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_assignment
{
    internal class A4Q3
    {
        public static void Integer()
        {
            while (true) // Loop to allow multiple checks
            {
                try
                {
                    // Accept integer input from the user
                    Console.Write("Enter a positive integer: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    // Validate that the input is a positive integer
                    if (number <= 0)
                    {
                        throw new ArgumentException("Number must be a positive integer.");
                    }

                    // Check if the number is prime
                    if (IsPrime(number))
                    {
                        Console.WriteLine($"{number} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is not a prime number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Ask if the user wants to check another number
                Console.Write("Do you want to check another number? (y/n): ");
                string continueCheck = Console.ReadLine().ToLower();
                if (continueCheck != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Goodbye!");
        }

        // Method to check if a number is prime
        static bool IsPrime(int num)
        {
            if (num == 1) return false; // 1 is not a prime number
            if (num == 2) return true;  // 2 is the only even prime number

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) // If divisible by any number other than 1 and itself
                {
                    return false;
                }
            }

            return true;
        }
    }
}
    

