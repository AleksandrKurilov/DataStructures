using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("Billy");
            list.Add("Liam");
            list.Add("Harry");
            list.Add("Alex");
            list.Add("Ron");
            list.Add("Mason");
            list.Add("Ethan");

            list.AppendFirst("Emma");

            list.Remove("Liam");

            Console.WriteLine($"В списке {list.Count} элементов");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
