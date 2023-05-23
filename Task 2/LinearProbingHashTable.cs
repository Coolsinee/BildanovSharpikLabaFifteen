using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class HashTable
    {
        private string[] table;
        private int size;

        public HashTable(int size)
        {
            this.size = size;
            table = new string[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }

        private int HashFunction(char c)
        {
            return 11 * ((int)c - 64) % size; // ASCII код 'A' равен 65
        }

        private int LinearProbing(int hashValue, int i)
        {
            return (hashValue + i) % size;
        }

        public void Insert(string key)
        {
            int hashValue = HashFunction(key[0]);

            for (int i = 0; i < size; i++)
            {
                int index = LinearProbing(hashValue, i);
                if (table[index] == null)
                {
                    table[index] = key;
                    return;
                }
            }

            throw new Exception("Хеш-таблица переполнена");
        }

        public void PrintTable()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"[{i}]: ");
                if (table[i] != null)
                {
                    Console.WriteLine(table[i]);
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }   
}   
