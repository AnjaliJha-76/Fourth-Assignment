using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_assignment
{
    internal class A4Q4
    {
        public class Stack<T>
        {
            // Internal list to store the stack elements
            private List<T> _items = new List<T>();

            // Push method to add an item to the stack
            public void Push(T item)
            {
                _items.Add(item); // Add the item to the end of the list (top of the stack)
            }

            // Pop method to remove and return the top item from the stack
            public T Pop()
            {
                if (_items.Count == 0)
                    throw new InvalidOperationException("Stack is empty.");

                // Get the last item (top of the stack)
                T item = _items[_items.Count - 1];
                _items.RemoveAt(_items.Count - 1); // Remove it
                return item;
            }

            // Indexer to access elements in the stack by their index
            public T this[int index]
            {
                get
                {
                    // Validate index
                    if (index < 0 || index >= _items.Count)
                        throw new IndexOutOfRangeException("Invalid index.");
                    return _items[index];
                }
            }

            // Property to get the count of items in the stack
            public int Count
            {
                get { return _items.Count; }
            }
        }

        public static void Generic()
        {
            // Create a generic stack of integers
            Stack<int> intStack = new Stack<int>();

            // Push items onto the stack
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            // Access elements using indexer
            Console.WriteLine("Access stack using indexer:");
            for (int i = 0; i < intStack.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {intStack[i]}");
            }

            // Pop items from the stack
            Console.WriteLine("\nPop items from stack:");
            while (intStack.Count > 0)
            {
                Console.WriteLine($"Popped: {intStack.Pop()}");
            }

            // Create a generic stack of strings
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Apple");
            stringStack.Push("Banana");
            stringStack.Push("Cherry");

            // Access elements using indexer
            Console.WriteLine("\nAccess string stack using indexer:");
            for (int i = 0; i < stringStack.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {stringStack[i]}");
            }

            // Pop items from the string stack
            Console.WriteLine("\nPop items from string stack:");
            while (stringStack.Count > 0)
            {
                Console.WriteLine($"Popped: {stringStack.Pop()}");
            }
        }
    }

}
    

