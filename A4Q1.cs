using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_assignment
{
    internal class A4Q1
    {
        public class Pair<T1, T2>
        {
            // Properties to store the pair of values
            public T1 First { get; set; }
            public T2 Second { get; set; }

            // Constructor to initialize the pair of values
            public Pair(T1 first, T2 second)
            {
                First = first;
                Second = second;
            }

            // Method to display the pair of values
            public void PrintPair()
            {
                Console.WriteLine($"First: {First}, Second: {Second}");
            }
        }

        public static void String()
        {
            // Test case 1: Pair of an integer and a string
            Pair<int, string> intStringPair = new Pair<int, string>(1, "One");
            Console.Write("Pair 1 - ");
            intStringPair.PrintPair();

            // Test case 2: Pair of a string and a double
            Pair<string, double> stringDoublePair = new Pair<string, double>("Pi", 3.14159);
            Console.Write("Pair 2 - ");
            stringDoublePair.PrintPair();

            // Test case 3: Pair of a boolean and a char
            Pair<bool, char> boolCharPair = new Pair<bool, char>(true, 'A');
            Console.Write("Pair 3 - ");
            boolCharPair.PrintPair();
        }
    }

}
