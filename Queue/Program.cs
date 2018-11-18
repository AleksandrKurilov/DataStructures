using System;

namespace Queue
{
    class Program
    {
        static void Main()
        {
            QueueStructure<string> queue = new QueueStructure<string>();

            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");
            queue.Enqueue("Five");
            queue.Enqueue("Six");

            Console.WriteLine($"Количество элементов в очереди = {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Clear();

            try
            {
                Console.WriteLine(queue.Dequeue());
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }
    }
}
