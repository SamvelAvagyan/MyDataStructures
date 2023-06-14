using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(12);
            tree.Add(7);
            tree.Add(15);
            tree.Add(13);
            tree.Add(17);
            tree.Add(16);
            tree.Add(8);
            tree.Add(2);
            tree.Add(5);

            foreach(var item in tree.Preorder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            foreach (var item in tree.Postorder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            foreach (var item in tree.Inorder())
            {
                Console.Write(item + " ");
            }
        }
    }
}
