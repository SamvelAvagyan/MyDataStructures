using System;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.LinkedList<int> linkedList;
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(11);
            list.AddLast(12);
            list.AddFirst(5);
            list.AddAfter(11, 20);
            list.AddAfter(12, 25);
            list.AddAfter(1100, 17);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.RemoveLast();
            list.RemoveFirst();

            Console.WriteLine("\n==================================");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
