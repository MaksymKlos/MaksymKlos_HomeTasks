using System;
using System.Collections.Generic;


namespace Event
{
    public class StringCollector
    {
        private static List<string> _strings = new List<string>();
        private static int _count = 0;
        private static int _indexer = -1;
        public static void AddToList(string str)
        {
            _count++;
            _strings.Add(str);
            Console.WriteLine("Enter string was added to StringCollector");
            Console.WriteLine();
        }
        public static void PrintList()
        {
            for (int i = 0; i < _count; i++)
            {
                _indexer++;
                Console.Write($"String: {_strings[i]}\n");
            }
        }
    }
}
