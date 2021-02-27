using System;
using System.Collections.Generic;

namespace Delegate
{
    public class AlphaNumericCollector
    {
        private static List<string> _strings = new List<string>();
        public static void AddToList(string str)
        {
            _strings.Add(str);
            Console.WriteLine("Enter string was added to AlphaNumericCollector");
            Console.WriteLine();
        }
        public static void PrintList()
        {
            foreach (var str in _strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
