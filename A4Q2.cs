using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_assignment
{
    internal class A4Q2
    {
        public static void Subject()
        {
            try
            {
                // Array to store marks of five subjects
                int[] marks = new int[5];
                string[] subjects = { "Math", "Science", "English", "History", "Physical Education" };
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write($"Enter marks for {subjects[i]} (0-100): ");
                    marks[i] = int.Parse(Console.ReadLine());

                    // Validate input marks
                    if (marks[i] < 0 || marks[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException("Marks must be between 0 and 100.");
                    }
                }

                // Calculate average marks
                double average = CalculateAverage(marks);

                // Display grade based on average marks
                string grade = CalculateGrade(average);

                Console.WriteLine($"\nAverage Marks: {average:F2}");
                Console.WriteLine($"Grade: {grade}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric marks.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to calculate average marks
        static double CalculateAverage(int[] marks)
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return total / 5.0; // There are 5 subjects
        }

        // Method to assign grade based on average marks
        static string CalculateGrade(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
    

