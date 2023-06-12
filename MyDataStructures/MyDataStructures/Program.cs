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
        }
    }
}
