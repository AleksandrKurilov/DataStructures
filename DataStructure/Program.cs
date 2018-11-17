using System;

namespace DataStructure
{
    class Program
    {
        static void Main()
        {
            TryStackByLinkedList();

            Console.ReadKey();
        }

        private static void TryStackByLinkedList()
        {
            var stack = new StackByLinkedList<string>();
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");
            stack.Push("Five");
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
