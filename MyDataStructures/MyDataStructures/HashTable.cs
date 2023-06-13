using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructures
{
    class HashTable<TKey, TValue>
    {
        private List<TValue>[] items;

        public HashTable(int size)
        {
            items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)
        {
            var hash = GetHash(key);

            if(items[hash] == null)
            {
                items[hash] = new List<TValue>() { value };
            }
            else
            {
                items[hash].Add(value);
            }
        }

        public bool Search(TKey key, TValue value)
        {
            var hash = GetHash(key);
            return items[hash]?.Contains(value) ?? false;
        }

        public int GetHash(TKey key)
        {
            return Encoding.ASCII.GetBytes(key.ToString().Substring(0, 1))[0] % items.Length;
        }
    }
}
