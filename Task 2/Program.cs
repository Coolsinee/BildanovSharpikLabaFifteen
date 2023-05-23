using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(5);
            string[] keys = { "E", "A", "S", "Y", "Q", "U", "T", "I", "O", "N" };

            foreach (string key in keys)
            {
                hashTable.Insert(key);
            }

            hashTable.PrintTable();
        }
    }
}
