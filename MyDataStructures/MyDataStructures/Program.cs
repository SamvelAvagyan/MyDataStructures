using System;
using System.Collections.Generic;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string, int> hashTable = new HashTable<string, int>(10);
            hashTable.Add("Armen", 18);
            hashTable.Add("Ashot", 27);
            hashTable.Add("Vardges", 35);
        }
    }
}
