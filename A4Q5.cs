using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_assignment
{
    internal class A4Q5
    {
        public class Queue<T>
        {
            // Internal list to store the queue elements
            private List<T> _items = new List<T>();

            // Enqueue method to add an item to the queue
            public void Enqueue(T item)
            {
                _items.Add(item); // Add the item to the end of the list (end of the queue)
            }

            // Dequeue method to remove and return the first item from the queue
            public T Dequeue()
            {
                if (_items.Count == 0)
                    throw new InvalidOperationException("Queue is empty.");

                // Get the first item (front of the queue)
                T item = _items[0];
                _items.RemoveAt(0); // Remove the first item from the list (front of the queue)
                return item;
            }

            // Indexer to access elements in the queue by their index
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

            // Property to get the count of items in the queue
            public int Count
            {
                get { return _items.Count; }
            }
        }

        public static void Elements()
        {
            // Create a generic queue of integers
            Queue<int> intQueue = new Queue<int>();

            // Enqueue items into the queue
            intQueue.Enqueue(10);
            intQueue.Enqueue(20);
            intQueue.Enqueue(30);

            // Access elements using indexer
            Console.WriteLine("Access queue using indexer:");
            for (int i = 0; i < intQueue.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {intQueue[i]}");
            }

            // Dequeue items from the queue
            Console.WriteLine("\nDequeue items from queue:");
            while (intQueue.Count > 0)
            {
                Console.WriteLine($"Dequeued: {intQueue.Dequeue()}");
            }

            // Create a generic queue of strings
            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Apple");
            stringQueue.Enqueue("Banana");
            stringQueue.Enqueue("Cherry");

            // Access elements using indexer
            Console.WriteLine("\nAccess string queue using indexer:");
            for (int i = 0; i < stringQueue.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {stringQueue[i]}");
            }

            // Dequeue items from the string queue
            Console.WriteLine("\nDequeue items from string queue:");
            while (stringQueue.Count > 0)
            {
                Console.WriteLine($"Dequeued: {stringQueue.Dequeue()}");
            }
        }
    }
}
    

