using System;
using System.Collections.Generic;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOnArray<int> stack = new StackOnArray<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
        }
    }
}
