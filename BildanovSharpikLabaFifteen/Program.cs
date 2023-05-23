using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaFifteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(5);
            string[] keys = { "E", "A", "S", "Y", "Q", "U", "T", "I", "O", "N" };

            foreach (string key in keys)
            {
                hashTable.Add(key);
            }

            Console.WriteLine("Исходная хэш таблица:");
            hashTable.PrintTable();

            Console.WriteLine("\nУдаление 'Q' из хэш таблицы:");
            hashTable.Remove("Q");
            hashTable.PrintTable();

            Console.WriteLine("\nПоиск 'U' в хэш таблице:");
            bool found = hashTable.Contains("U");
            Console.WriteLine($"Найдено ли 'U' в таблице : {found}");

            Console.WriteLine("\nФинальная хэш таблица:");
            hashTable.PrintTable();
        }
    }
}
