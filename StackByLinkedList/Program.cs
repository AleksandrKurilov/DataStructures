using System;

namespace StackByLinkedList
{
    class Program
    {
        static void Main()
        {
            var stack = new StackByLinkedList<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine($"В стеке {stack.Count} элементов");

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
