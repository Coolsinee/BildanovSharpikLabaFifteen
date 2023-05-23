using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaFifteen
{
    class HashTable
    {
        private int size;
        private List<List<string>> table;

        public HashTable(int size)
        {
            this.size = size;
            table = new List<List<string>>(size);

            for (int i = 0; i < size; i++)
            {
                table.Add(new List<string>());
            }
        }

        private int HashFunction(string key)
        {
            int sum = 0;
            foreach (char c in key)
            {
                sum += (int)c;
            }
            return (11 * sum) % size;
        }

        public void Add(string key)
        {
            int index = HashFunction(key);
            table[index].Add(key);
        }

        public void Remove(string key)
        {
            int index = HashFunction(key);
            table[index].Remove(key);
        }

        public bool Contains(string key)
        {
            int index = HashFunction(key);
            return table[index].Contains(key);
        }

        public void PrintTable()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Index {i}: ");
                foreach (string key in table[i])
                {
                    Console.Write($"{key} ");
                }
                Console.WriteLine();
            }
        }
    }
}
